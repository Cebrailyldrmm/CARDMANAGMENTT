using Card.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFinder.DataAcess.Abstract
{
    public interface ICardRepository<T> where T : class
    {

        List<T> GetAllCards();

        T GetCardById(int id);
        T CreateCard(T card);
        T UpdateCard(T card);
        void DeleteCard(int id);
        
    }
}
