using repository_pattern.Interfaces;
using repository_pattern.Models;

namespace repository_pattern.Services
{
    public class Dbvservices
    {
        private readonly IRepository<Desbravador> _dbvRepository;

        public Dbvservices(IRepository<Desbravador> dbvRepository)
        {
            _dbvRepository = dbvRepository;
        }

        public void Adddesbravador(Desbravador desbravador) => _dbvRepository.Add(entity: desbravador);

        public void UpdateDesbravador(Desbravador desbravador)
        {
            _dbvRepository.Update(entity: desbravador);
        }

        public void DeleteDesbravador(Desbravador desbravador)
        {
            _dbvRepository.Delete(desbravador);
        }

        public Desbravador GetDesbravadorById(int id)
        {
            return _dbvRepository.GetById(id);
        }

        public IEnumerable<Desbravador> GetAlldesbradors()
        {
            return _dbvRepository.GetAll();
        }

        internal void AddDesbravador(Desbravador model)
        {
            throw new NotImplementedException();
        }
    }
}
