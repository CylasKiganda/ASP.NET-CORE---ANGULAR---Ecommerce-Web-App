

using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public IProductRepository _repo { get; }
         
        public ProductsController(IProductRepository repo )
        {
            _repo = repo;
            
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>>  GetProduct(int id){
            var prod = await _repo.GetProductByIdAsync(id);
            return prod;
        }
        [Route("/api/[controller]/counts/")]
        public async Task<ActionResult<int>> GetTotalProductCount(){
            var count = await _repo.GetProductsAsync();
            return count.Count;
        }

        [Route("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands(){
            return  Ok(await _repo.GetProductBrandsAsync());
        }

    }
}