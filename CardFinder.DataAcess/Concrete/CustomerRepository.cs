using Card.Entities;
using CardFinder.DataAcess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFinder.DataAcess.Concrete
{
    public class CustomerRepository : ICardRepository<Customer>
    {
        public Customer CreateCard(Customer card)
        {
            using (var cardDbContext = new CardDbContext())
            {
                cardDbContext.customers.Add(card);
                cardDbContext.SaveChanges();
                return card;
            }
        }

        public void DeleteCard(int id)
        {
            using (var cardDbContext = new CardDbContext())
            {
                var deletecard = GetCardById(id);
                cardDbContext.customers.Remove(deletecard);
                cardDbContext.SaveChanges();
            }
        }

        public List<Customer> GetAllCards()
        {
            using (var cardDbContext = new CardDbContext())
            {
                return cardDbContext.customers.ToList();

            }
        }

        public Customer GetCardById(int id)
        {

            using (var cardDbContext = new CardDbContext())
            {
                return cardDbContext.customers.Find(id);

            }
        }

        public Customer UpdateCard(Customer card)
        {
            using(var cardDbContext = new CardDbContext())
            {
                cardDbContext.customers.Update(card);
                return card;
            }
        }
    }
}
