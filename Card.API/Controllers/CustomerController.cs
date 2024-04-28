using Card.Entities;
using CardFinder.Bussiness.Abstract;
using CardFinder.Bussiness.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Card.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IServices<Customer> _cardservicesy;

        public CustomerController()
        {
            _cardservicesy = new CustomerManager();
        }
        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customer> Get()
        {
            return _cardservicesy.GetAllCards();
        }
        /// <summary>
        /// Get By Id Customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Customer Getid(int id)
        {
            return _cardservicesy.GetById(id);
        }
        /// <summary>
        /// Create A Customer
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost]
        public Customer Post([FromBody] Customer card)
        {
            return _cardservicesy.Create(card);
        }
        /// <summary>
        /// Update A Customer
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPut]
        public Customer Put([FromBody] Customer card)
        {
            return _cardservicesy.Update(card);
        }
        /// <summary>
        /// Delete A Customer
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _cardservicesy.Delete(id);
        }
    }

}

