using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReadingTimeManager : IReadingTimeService
    {
        IReadingTimeDal _readingTimeDal;
        public ReadingTimeManager(IReadingTimeDal readingTimeDal)
        {
            _readingTimeDal=readingTimeDal;
        }
        public IDataResult<ReadingTime> GetById(Guid id)
        {
            var result=_readingTimeDal.Get(r=>r.Id==id);
            if(result!=null)
                return new SuccessDataResult<ReadingTime>(result);
            return new ErrorDataResult<ReadingTime>();
        }

        public IDataResult<List<ReadingTime>> GetAll()
        {
            var result = _readingTimeDal.GetAll();
            if (result != null)
                return new SuccessDataResult<List<ReadingTime>>(result);
            return new ErrorDataResult<List<ReadingTime>>();
        }
    }
}
