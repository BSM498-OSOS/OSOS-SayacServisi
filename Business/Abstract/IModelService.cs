﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService
    {
        bool Add(Model model);
        bool Delete(Model model);
        bool Update(Model model);
        Model GetById(string modelId);
        List<Model> GetAll();
    }
}