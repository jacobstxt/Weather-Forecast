using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DataModels
{
    [Table("tbl_weather")]
    public class WeatherEntity
    {    
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;

        public string Location { get; set; }  
        public float Temperature { get; set; }  
        public string WeatherCondition { get; set; }  
    }
}
