# SQL Test Assignment

Attached is a mysqldump of a database to be used during the test.

Below are the questions for this test. Please enter a full, complete, working SQL statement under each question. We do not want the answer to the question. We want the SQL command to derive the answer. We will copy/paste these commands to test the validity of the answer.

**Example:**

_Q. Select all users_

- Please return at least first_name and last_name

																																			


------

**— Test Starts Here —**

Assumptions:
1) Listing Table Status -> Basic =2, Premium =3
2) User Table Status -> Active =1, Inactive =2


1. Select users whose id is either 3,2 or 4
- Please return at least: all user fields

Ans: select id,first_name,last_name,email,status,created from users where id in (3,2,4)

2. Count how many basic and premium listings each active user has
- Please return at least: first_name, last_name, basic, premium

Ans: 
SELECT u.first_name, u.last_name,
SUM(CASE WHEN l.status = 2 THEN 1 ELSE 0 END) AS Basic,
SUM(CASE WHEN l.status = 3 THEN 1 ELSE 0 END) AS Premium
FROM users u join listings l
ON u.id = l.user_id
WHERE u.status=1
GROUP BY u.first_name, u.last_name

3. Show the same count as before but only if they have at least ONE premium listing
- Please return at least: first_name, last_name, basic, premium

Ans:
SELECT u.first_name, u.last_name,
SUM(CASE WHEN l.status = 2 THEN 1 ELSE 0 END) AS basic,
SUM(CASE WHEN l.status = 3 THEN 1 ELSE 0 END) AS premium
FROM users u join listings l
ON u.id = l.user_id
WHERE u.status=1
GROUP BY u.first_name, u.last_name
having SUM(CASE WHEN l.status = 3 THEN 1 ELSE 0 END) > 0

4. How much revenue has each active vendor made in 2013
- Please return at least: first_name, last_name, currency, revenue

Ans:

SELECT u.first_name, u.last_name, c.currency,
SUM(c.price) AS revenue
FROM users u join listings l ON u.id = l.user_id
JOIN clicks c on l.id = c.listing_id
WHERE u.status=1 and YEAR(c.created) = 2013
GROUP BY u.first_name, u.last_name, c.currency

5. Insert a new click for listing id 3, at $4.00
- Find out the id of this new click. Please return at least: id

Ans:
INSERT INTO clicks(listing_id,price,currency,created)
VALUES(3,4.00,'USD',SYSDATETIME())
SELECT SCOPE_IDENTITY() as id


6. Show listings that have not received a click in 2013
- Please return at least: listing_name

Ans:
SELECT data.name AS listing_name FROM
(SELECT l.name, SUM(CASE WHEN YEAR(c.created) = 2013 THEN 1 ELSE 0 END) as ClickCounter FROM listings l
LEFT JOIN clicks c ON l.id = c.listing_id
GROUP BY l.name) as data
WHERE data.ClickCounter < 1

7. For each year show number of listings clicked and number of vendors who owned these listings
- Please return at least: date, total_listings_clicked, total_vendors_affected

Ans:
SELECT YEAR(c.created) as date, count(*) as total_listings_clicked, count( DISTINCT l.user_id) as total_vendors_affected
 FROM clicks c
LEFT JOIN listings l ON c.listing_id = l.id
GROUP BY YEAR(c.created)


8. Return a comma separated string of listing names for all active vendors
- Please return at least: first_name, last_name, listing_names

Ans:
SELECT DISTINCT u.first_name, u.last_name, 
  STUFF((SELECT distinct ', ' + l1.name
         FROM listings l1
         WHERE l.user_id = l1.user_id
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)')
        ,1,1,'') listing_names
FROM listings l
JOIN users u ON l.user_id = u.id
WHERE u.status = 1