using AutoMapper;
using ProjBiblioteca.Application.Services;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(a => a.Id,
                           opt => opt.MapFrom(src => src.AutorID))
                .ReverseMap();
        }
    }
}