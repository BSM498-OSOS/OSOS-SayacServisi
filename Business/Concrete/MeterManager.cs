using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MeterManager : IMeterService
    {
        private readonly IMeterDal _meterDal;

        public MeterManager(IMeterDal meterDal)
        {
            _meterDal = meterDal;
        }

        public bool Add(Meter meter)
        {
            _meterDal.Add(meter);
            return true;
        }

        public bool Delete(Meter meter)
        {
            _meterDal.Delete(meter);
            return true;
        }

        public List<Meter> GetAll()
        {
            return _meterDal.GetAll();
        }

        public Meter GetById(string meterId)
        {
            return _meterDal.Get(m => m.Id == meterId);
        }

        public bool Update(Meter meter)
        {
            _meterDal.Update(meter);
            return true;
        }
    }
}
