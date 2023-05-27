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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public bool Add(Brand brand)
        {
            _brandDal.Add(brand);
            return true;
        }

        public bool Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return true;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(Guid brandId)
        {
            return _brandDal.Get(b=>b.Id == brandId);
        }

        public bool Update(Brand brand)
        {
            _brandDal.Update(brand);
            return true;
        }
    }
}
