using AutoMapper;
using SimpleApiTemplate.Models;
using SimpleApiTemplate.Controllers.GenericController;
using SimpleApiTemplate.Services.Interfaces;
using SimpleApiTemplate.Data.Dtos.ExampleDtos;

namespace SimpleApiTemplate.Controllers;

public class ExampleController : GenericController<Example, InsertExampleDto, ReadExampleDto, UpdateExampleDto>
{
    public ExampleController(IExampleRepository repository, IMapper mapper,  IHttpContextAccessor httpContextAccessor) : base( repository, mapper, httpContextAccessor)
    {
        
    }
    
}