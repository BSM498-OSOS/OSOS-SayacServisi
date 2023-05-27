﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        bool Add(Brand brand);
        bool Delete(Brand brand);
        bool Update(Brand brand);
        Brand GetById(Guid brandId);
        List<Brand> GetAll();
    }
}
