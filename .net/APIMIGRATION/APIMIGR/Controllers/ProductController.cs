﻿using APIMIGR.Models;
using APIMIGR.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMIGR.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class ProductController : ControllerBase

    {

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)

        {

            _productRepository = productRepository;

        }

        // GET: api/Product

        [HttpGet]

        public IActionResult Get()

        {

            var products = _productRepository.GetProducts();

            return new OkObjectResult(products);

        }

        // GET: api/Product/5

        [HttpGet("{id}", Name = "Get")]

        public IActionResult Get(int id)

        {

            var product = _productRepository.GetProductByID(id);

            return new OkObjectResult(product);

        }

        // POST: api/Product

        [HttpPost]

        public IActionResult Post([FromBody] Product product)

        {

            using (var scope = new TransactionScope())

            {

                _productRepository.InsertProduct(product);

                scope.Complete();

                return CreatedAtAction(nameof(Get), new { id = product.Id }, product);

            }

        }

        // PUT: api/Product/5

        [HttpPut]

        public IActionResult Put([FromBody] Product product)

        {

            if (product != null)

            {

                using (var scope = new TransactionScope())

                {

                    _productRepository.UpdateProduct(product);

                    scope.Complete();

                    return new OkResult();

                }

            }

            return new NoContentResult();

        }

        // DELETE: api/ApiWithActions/5

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)

        {

            _productRepository.DeleteProduct(id);

            return new OkResult();

        }

    }
}
