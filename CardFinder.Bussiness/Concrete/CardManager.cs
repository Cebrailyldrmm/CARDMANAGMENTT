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
    public class CardManager : IServices<Cardd>
    {
        public Cardd Create(Cardd K)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cardd> GetAllCards()
        {
            throw new NotImplementedException();
        }

        public Cardd GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cardd Update(Cardd K)
        {
            throw new NotImplementedException();
        }
    }
}
/*
        private ICardRepository<Cardd> _cardRepository;
        public CardManager() {
            _cardRepository = new CardRepository();
        }
        public Cardd Create(Cardd K)
        {
            return _cardRepository.CreateCardd(K);
        }

        public void Delete(int id)
        {
          _cardRepository.DeleteCard(id);
        }

        public List<Cardd> GetAllCards()
        {
            return _cardRepository.GetAllCards(); ;
        }

        public Cardd GetById(int id)
        {
            return _cardRepository.GetCardById(id);
        }

        public Cardd Update(Cardd K)
        {
            return _cardRepository.UpdateCard(K);
        }*/