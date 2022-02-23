using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DotNetCoreCamp.Models
{
    public class CityAndWriter
    {
        public List<Cities> Cities { get; set; }
        public List<Writer> writers { get; set; }
    }
}
