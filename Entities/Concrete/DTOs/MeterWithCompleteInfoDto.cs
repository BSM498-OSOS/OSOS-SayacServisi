﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class MeterWithCompleteInfoDto:IDto
    {
        public Guid Id { get; set; }
        public Guid ModelId { get; set; }
        public String ModelName { get; set; }
        public Guid BrandId { get; set; }
        public String BrandName { get; set; }
        public Guid ReadingTimeId { get; set; }
        public String ReadingTimeName { get; set; }
        public int SerialNo { get; set; }
    }
}
