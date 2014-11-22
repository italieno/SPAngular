using System.Collections.Generic;
using SPA.Core.Models;

namespace SPA.Infra.Services
{
    public class DoSomethingService : IDoSomethingService
    {
        public IEnumerable<SampleModel> ReturnSomething()
        {
            return new List<SampleModel>(){
                new SampleModel()
                {
                    Id = 1,
                    Description = "API item 1"
                },
                new SampleModel()
                {
                    Id = 2,
                    Description = "API item 2"
                }
            };
        }

    }
}