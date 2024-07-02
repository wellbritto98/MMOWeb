using AutoMapper;
using SimpleApiTemplate.Data.Dtos.ExampleDtos;
using SimpleApiTemplate.Models;

namespace SimpleApiTemplate.Data.AutoMapperProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<Example, InsertExampleDto>().ReverseMap();
        CreateMap<Example, ReadExampleDto>().ReverseMap();
        CreateMap<Example, UpdateExampleDto>().ReverseMap();
    }
    
}