using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TourP.Entities.DTO.ContentDTO
{
   public class ContentUpdateDTO
    {
        public int Id { get; set; }
        public string ContentDescription { get; set; }
        [JsonIgnore]
        public int AdsId { get; set; }
    }
}
