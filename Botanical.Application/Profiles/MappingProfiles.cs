using AutoMapper;
using Botanical.Application.Features.Plants.Queries.GetPlantDetail;
using Botanical.Application.Features.Plants.Queries.GetPlantList;
using Domain.Entities;

namespace Botanical.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Plant, PlantDetail>().ReverseMap();
            CreateMap<Plant, List<PlantList>>().ReverseMap();
        }
    }
}
