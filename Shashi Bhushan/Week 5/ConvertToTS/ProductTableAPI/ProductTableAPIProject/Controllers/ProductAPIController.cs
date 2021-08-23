using Microsoft.AspNetCore.Mvc;
using ProductTableAPIProject.Data;
using ProductTableAPIProject.Models;

namespace ProductTableAPIProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductAPIController : ControllerBase
    {
        private readonly ProductTableData _tableData;

        public ProductAPIController(ProductTableData tableData)
        {
            _tableData = tableData;
        }

        [HttpGet]
        public ProductRow[] GetPage(int page)
        {
            int pageSize = 3;
            int productTableSize = _tableData.TableData.Table.Count;
            int pageNum = (page > productTableSize / pageSize) ? (productTableSize / pageSize) : ((page < 1) ? 1 : page);
            return _tableData.TableData.Table.GetRange((pageNum - 1) * pageSize, pageSize).ToArray();
        }
    }
}
