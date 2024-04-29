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
        private ICardRepository<Cardd> _cardRepository;
        public CardManager()
        {
            _cardRepository = new CardRepository();
        }
        public Cardd Create(Cardd K)
        {
            return _cardRepository.CreateCard(K);
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