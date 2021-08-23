using System.Collections.Generic;
using ProductTableAPIProject.Models;

namespace ProductTableAPIProject.Data
{
    public class ProductTableData
    {
        public ProductTable TableData { get; set; }

        public ProductTableData()
        {
            this.TableData = new ProductTable
            {
                Table = new List<ProductRow> {
                    new ProductRow { Id = 1, Name = "P1", Price = 1000},
                    new ProductRow { Id = 2, Name = "P2", Price = 2000},
                    new ProductRow { Id = 3, Name = "P3", Price = 3000},
                    new ProductRow { Id = 4, Name = "P4", Price = 4000},
                    new ProductRow { Id = 5, Name = "P5", Price = 5000},
                    new ProductRow { Id = 6, Name = "P6", Price = 4000},
                    new ProductRow { Id = 7, Name = "P7", Price = 3000},
                    new ProductRow { Id = 8, Name = "P8", Price = 2000},
                    new ProductRow { Id = 9, Name = "P9", Price = 1000},
                    new ProductRow { Id = 10, Name = "P10", Price = 2000},
                    new ProductRow { Id = 11, Name = "P11", Price = 3000},
                    new ProductRow { Id = 12, Name = "P12", Price = 4000},
                    new ProductRow { Id = 13, Name = "P13", Price = 5000},
                    new ProductRow { Id = 14, Name = "P14", Price = 4000},
                    new ProductRow { Id = 15, Name = "P15", Price = 7000},
                }
            };
        }
    }
}