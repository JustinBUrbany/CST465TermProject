using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTermProject.Repositories
{
    public interface IDogRepository
    {
        List<string> GetDogTypes();
    }
}
