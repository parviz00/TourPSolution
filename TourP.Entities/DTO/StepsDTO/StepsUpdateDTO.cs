using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourP.Entities.DTO.StepsDTO
{
  public  class StepsUpdateDTO
    {
        public int Id { get; set; }
        public string StepTitle { get; set; }
        public string StepDescription { get; set; }
        public int AdsId { get; set; }
    }
}
