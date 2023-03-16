using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Meter : IEntity
    {
        public String Id { get; private set; }
        public String ModelId { get;  set; }
        
        public String SerialNo { get; set; }
    }
}
