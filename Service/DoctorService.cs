using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DoctorService : BaseService
    {
        BasicRepository _repository;

        public DoctorService()
        {
            _repository = repository;
        }

        public IEnumerable<patientLimited> getAllLimitedDatabase()
        {
            return _repository.getAllLimitedDatabase();
        }
    }
}