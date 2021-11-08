using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.AdsDTO;
using TourP.Entities.DTO.ContentDTO;
using TourP.Entities.DTO.EntryDTO;
using TourP.Entities.DTO.StepsDTO;

namespace TourP.DataAccess.Mappings
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Ads, AdsAddDTO>().ReverseMap();
            CreateMap<Ads, AdsDeleteDTO>().ReverseMap();
            CreateMap<Ads, AdsGetDTO>().ReverseMap();
            CreateMap<Ads, AdsUpdateDTO>().ReverseMap();

            CreateMap<Content, ContentAddDTO>().ReverseMap();
            CreateMap<Content, ContentDeleteDTO>().ReverseMap();
            CreateMap<Content, ContentGetDTO>().ReverseMap();
            CreateMap<Content, ContentUpdateDTO>().ReverseMap();

            CreateMap<Entry, EntryAddDTO>().ReverseMap();
            CreateMap<Entry, EntryDeleteDTO>().ReverseMap();
            CreateMap<Entry, EntryGetDTO>().ReverseMap();
            CreateMap<Entry, EntryUpdateDTO>().ReverseMap();

            CreateMap<Steps, StepsAddDTO>().ReverseMap();
            CreateMap<Steps, StepsDeleteDTO>().ReverseMap();
            CreateMap<Steps, StepsGetDTO>().ReverseMap();
            CreateMap<Steps, StepsUpdateDTO>().ReverseMap();
        }
    }
}
