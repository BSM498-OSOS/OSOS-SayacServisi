using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMeterService
    {
        IResult Add(Meter meter);
        IResult Delete(Meter meter);
        IResult Update(Meter meter);
        IDataResult<Meter> GetById(Guid meterId);
        IDataResult<List<Meter>> GetAll();

        IDataResult<MeterWithCompleteInfoDto> GetWithCompleteInfoById(Guid meterId);
        IDataResult<List<MeterWithCompleteInfoDto>> GetAllWithCompleteInfo();
    }
}
