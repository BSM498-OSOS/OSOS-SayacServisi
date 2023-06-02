using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMeterDal : EfEntityRepositoryBase<Meter, MeterDbContext>, IMeterDal
    {
        public List<MeterWithCompleteInfoDto> GetAllWithCompleteInfo()
        {
            using (var context = new MeterDbContext())
            {
                var result = (from m in context.Meters
                              join model in context.Models
                                 on m.ModelId equals model.Id
                             join b in context.Brands
                                 on model.BrandId equals b.Id
                              join r in context.ReadingTimes
                                  on m.ReadingTimeId equals r.Id
                              select new MeterWithCompleteInfoDto
                              {
                                  Id=m.Id,
                                  ModelId=m.ModelId,
                                  ModelName=model.Name,
                                  BrandId=model.BrandId,
                                  BrandName=b.Name,
                                  ReadingTimeId=m.ReadingTimeId,
                                  ReadingTimeName=r.Name,
                                  SerialNo=m.SerialNo
                              }).ToList();
                return result;
            }
        }

        public MeterWithCompleteInfoDto GetAllWithCompleteInfoById(Guid id)
        {
            using (var context = new MeterDbContext())
            {
                var result = from m in context.Meters
                              join model in context.Models
                                 on m.ModelId equals model.Id
                              join b in context.Brands
                                 on model.BrandId equals b.Id
                             join r in context.ReadingTimes
                                 on m.ReadingTimeId equals r.Id
                              where m.Id == id
                              select new MeterWithCompleteInfoDto
                              {
                                  Id = m.Id,
                                  ModelId = m.ModelId,
                                  ModelName = model.Name,
                                  BrandId = model.BrandId,
                                  BrandName = b.Name,
                                  ReadingTimeId = m.ReadingTimeId,
                                  ReadingTimeName = r.Name,
                                  SerialNo = m.SerialNo
                              };
                return result.FirstOrDefault();
            }
        }
    }
}
