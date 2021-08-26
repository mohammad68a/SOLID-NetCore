using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;

namespace Ecommerce.Repositories
{
    public interface ITaxRepository
    {
        ITax GetByLocation(string country, string state);
    }
}
