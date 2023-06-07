using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
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

        public IResult Add(Meter meter)
        {
            _meterDal.Add(meter);
            return new SuccessResult();
        }

        public IResult Delete(Meter meter)
        {
            _meterDal.Delete(meter);
            return new SuccessResult(); 
        }

        public IDataResult<List<Meter>> GetAll()
        {
            var result = _meterDal.GetAll();
            if(result!=null)
                return new SuccessDataResult<List<Meter>>(result);
            return new ErrorDataResult<List<Meter>>();
        }

        public IDataResult<List<MeterWithCompleteInfoDto>> GetAllWithCompleteInfo()
        {
            var result = _meterDal.GetAllWithCompleteInfo();
            if (result != null)
                return new SuccessDataResult<List<MeterWithCompleteInfoDto>>(result);
            return new ErrorDataResult<List<MeterWithCompleteInfoDto>>();
        }

        public IDataResult<Meter> GetById(Guid meterId)
        {
            var result=_meterDal.Get(m => m.Id == meterId);
            if(result!=null)
                return new SuccessDataResult<Meter>(result);
            return new ErrorDataResult<Meter>();
        }

        public IDataResult<Meter> GetBySerialNo(int serialNo)
        {
            var result = _meterDal.Get(m => m.SerialNo == serialNo);
            if (result != null)
                return new SuccessDataResult<Meter>(result);
            return new ErrorDataResult<Meter>();
        }

        public IDataResult<MeterWithCompleteInfoDto> GetWithCompleteInfoById(Guid meterId)
        {
            var result = _meterDal.GetAllWithCompleteInfoById(meterId);
            if (result != null)
                return new SuccessDataResult<MeterWithCompleteInfoDto>(result);
            return new ErrorDataResult<MeterWithCompleteInfoDto>();
        }

        public IDataResult<MeterWithCompleteInfoDto> GetWithCompleteInfoBySerialNo(int serialNo)
        {
            var result = _meterDal.GetAllWithCompleteInfoBySerialNo(serialNo);
            if (result != null)
                return new SuccessDataResult<MeterWithCompleteInfoDto>(result);
            return new ErrorDataResult<MeterWithCompleteInfoDto>();
        }

        public IResult Update(Meter meter)
        {
            _meterDal.Update(meter);
            return new SuccessResult();
        }

    }
}
