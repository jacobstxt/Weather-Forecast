using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelsDTO
{
    public class WeatherDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string Location { get; set; }
        public float Temperature { get; set; }
        public string WeatherCondition { get; set; }
    }
}
