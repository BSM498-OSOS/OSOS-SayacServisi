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
    public class ModelManager:IModelService
    {
        private readonly IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public bool Add(Model model)
        {
            _modelDal.Add(model);
            return true;
        }

        public bool Delete(Model model)
        {
            _modelDal.Delete(model);
            return true;
        }

        public List<Model> GetAll()
        {
            return _modelDal.GetAll();
        }

        public Model GetById(string modelId)
        {
            return _modelDal.Get(m=>m.Id == modelId);
        }

        public bool Update(Model model)
        {
            _modelDal.Update(model);
            return true;
        }
    }
}
