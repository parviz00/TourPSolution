using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourP.Entities.DTO.EntryDTO
{
  public  class EntryUpdateDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public int AdsId { get; set; }
    }
}
