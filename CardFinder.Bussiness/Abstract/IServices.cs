using Card.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFinder.Bussiness.Abstract
{
    public interface IServices<T> where T : class
    {
        List<T> GetAllCards();

        T GetById(int id);
        T Create(T K);
        T Update(T K);
        void Delete(int id);
        
    }
}
