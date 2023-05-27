using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMeterService
    {
        bool Add(Meter meter);
        bool Delete(Meter meter);
        bool Update(Meter meter);
        Meter GetById(Guid meterId);
        List<Meter> GetAll();
    }
}
