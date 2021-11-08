using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TourP.Entities.DTO.StepsDTO
{
   public class StepsAddDTO
    {
        public string StepTitle { get; set; }
        public string StepDescription { get; set; }
        public int AdsId { get; set; }
    }
}
