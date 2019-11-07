using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantRService.Model
{
    public class PersonalPlant : Plant
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public DateTime LastWatered { get; set; }
        public DateTime NextWatered { get; set; }
        public string NName { get; set; }
        public int WDuration { get; set; }
        public int AId { get; set; }

    }
}
