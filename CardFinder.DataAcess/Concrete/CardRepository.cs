using Card.Entities;
using CardFinder.DataAcess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFinder.DataAcess.Concrete
{
    public class CardRepository : ICardRepository<Cardd>
    {
        public Cardd CreateCard(Cardd card)
        {
            using (var cardDbContext = new CardDbContext())
            {
                cardDbContext.cards.Add(card);
                cardDbContext.SaveChanges();
                return card;
            }
        }

        public void DeleteCard(int id)
        {

            using (var cardDbContext = new CardDbContext())
            {
                var deletecard = GetCardById(id);
                cardDbContext.cards.Remove(deletecard);
                cardDbContext.SaveChanges();
            }
        }

        public List<Cardd> GetAllCards()
        {
            using (var cardDbcontext = new CardDbContext())
            {
                return cardDbcontext.cards.ToList();
            }
        }

        public Cardd GetCardById(int id)
        {

            using (var cardDbcontext = new CardDbContext())
            {
                return cardDbcontext.cards.Find(id);
            }
        }

        public Cardd UpdateCard(Cardd card)
        {
            using (var carDbcontext = new CardDbContext())
            {
                carDbcontext.cards.Update(card);
                return card;
            }
        }
    }
}

