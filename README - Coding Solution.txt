1) Please take the codebase from Git Repository. Path is mentioned below:
https://github.com/kksingla027/Product_Importer.git

2) Solution is based on .net core 2.1 with VS2017

3) On starting, default api route will be http://localhost:50956/api/product

4) By default, api (http://localhost:50956/api/product/10) will fetch data from SQL data provider.
Considering our DB might change to Mongo in future, Please change the ProviderType = 2 in 
appSetting.json as below:

"Database": {
    "ProviderType": "2"
  },

Now hit the same api (http://localhost:50956/api/product/10), data will be fetched from Mongo data provider.

5) Product Import api is also designed in same controller. Implementation is not full-fledged as I gave more
emphasis on design part.

Thank you.....