using Card.Entities;
using CardFinder.Bussiness.Abstract;
using CardFinder.Bussiness.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Card.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private IServices<Cardd> _cardservicesy;

        public CardController()
        {
            _cardservicesy = new CardManager();
        }
        /// <summary>
        /// Get All Card
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Cardd> Get()
        {
            return _cardservicesy.GetAllCards();
        }
        /// <summary>
        /// Get By Id Card
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Cardd Getid(int id)
        {
            return _cardservicesy.GetById(id);
        }
        /// <summary>
        /// Create A Card
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost]
        public Cardd Post([FromBody] Cardd card)
        {
            return _cardservicesy.Create(card);
        }
        /// <summary>
        /// Update A Card
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPut]
        public Cardd Put([FromBody] Cardd card)
        {
            return _cardservicesy.Update(card);
        }
        /// <summary>
        /// Delete A Card
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _cardservicesy.Delete(id);
        }
    }
}

