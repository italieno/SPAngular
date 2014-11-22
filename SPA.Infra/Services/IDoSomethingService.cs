using System.Collections.Generic;
using SPA.Core.Models;

namespace SPA.Infra.Services
{
    public interface IDoSomethingService
    {
        IEnumerable<SampleModel> ReturnSomething();
    }
}