using Card.Entities;
using CardFinder.Bussiness.Abstract;
using CardFinder.DataAcess.Abstract;
using CardFinder.DataAcess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFinder.Bussiness.Concrete
{
    public class CustomerManager : IServices<Customer>
    {
       private ICardRepository<Customer> _customerRepository;

        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }
        public Customer Create(Customer K)
        {
           return _customerRepository.CreateCard(K);
        }

        public void Delete(int id)
        {
            _customerRepository.DeleteCard(id);
        }

        public List<Customer> GetAllCards()
        {
            return _customerRepository.GetAllCards();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetCardById(id);
        }

        public Customer Update(Customer K)
        {
            return _customerRepository.UpdateCard(K);
        }
    }
}
