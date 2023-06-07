using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMeterDal: IEntityRepository<Meter>
    {
        public List<MeterWithCompleteInfoDto> GetAllWithCompleteInfo();

        public MeterWithCompleteInfoDto GetAllWithCompleteInfoById(Guid id);

        MeterWithCompleteInfoDto GetAllWithCompleteInfoBySerialNo(int serialNo);
    }
}
