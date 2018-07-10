using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment2
{
    class Repository
    {
        public List<Stock> GetStockOnHand() {
            using (IDbConnection idbConnection = ConnectionFactory.OpenConnection()) {
                List<Product> productList = idbConnection.Query<Product>("Select ProductCode, ProductName, ProductStatus from Product").ToList();
                List<Stock> stockList = new List<Stock>();
                 IDictionary<string, int> stockDictionary;
        stockDictionary = idbConnection.Query("Select ProductCode, Quantity from Stock").ToDictionary(row =>(string)row.ProductCode, row=>(int)row.Quantity);  


                foreach (Product product in productList) {
                    
                    if (stockDictionary.ContainsKey(product.ProductCode)){

                        Stock stock = new Stock()
                        {
                            Product = product,
                            Quantity = stockDictionary[product.ProductCode]
                        };

                        stockList.Add(stock);
                    }
                    

                            
                }
                return stockList;
            }

           
        }
    }
}
