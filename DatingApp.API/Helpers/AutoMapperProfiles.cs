using AutoMapper;
using DatingApp.API.Models;
using DatingApp.API.DTOs;
using System.Linq;


namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<tblUser, UseerForListDto>()
             .ForMember(dest => dest.PhotoUrl, opt => {
                 opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
             })
             .ForMember(dest => dest.Age, opt => {
                 opt.ResolveUsing()
             })
            CreateMap<tblUser, UserForDetailDto>()
               .ForMember(dest => dest.PhotoUrl, opt => {
                 opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
             });
            CreateMap<tblPhoto, PhotosForDetailedDto>();
        }
    }
}