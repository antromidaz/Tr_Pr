using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entity;

namespace Service
{
    public class MedRegistratorService : BaseService
    {
        BasicRepository _repository;

        public MedRegistratorService()
        {
            _repository = repository;
        }

        public IEnumerable<patientLimited> getAllLimitedDatabase()
        {
            return _repository.getAllLimitedDatabase();
        }

        public void delete(int id)
        {
            _repository.delete(id);
        }
    }
}
