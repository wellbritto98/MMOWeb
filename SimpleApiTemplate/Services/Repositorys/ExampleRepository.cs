using SimpleApiTemplate.Data;
using SimpleApiTemplate.Models;
using SimpleApiTemplate.Services.Interfaces;
using SimpleApiTemplate.Services.Repositorys;
using SimpleApiTemplate.Services.GenericRepository;

namespace SimpleApiTemplate.Services.Repositorys;

public class ExampleRepository : GenericRepository<Example>, IExampleRepository
{
    public ExampleRepository(DataContext context) : base(context)
    {
    }
}