using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Web.Models;

namespace Pokedex.Web.Servicio
{
    public class ClassPruebaInterfazGlobal : IServicio<MiClasePrueba>
    {
        public void Create(MiClasePrueba obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MiClasePrueba Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<MiClasePrueba> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MiClasePrueba obj)
        {
            throw new NotImplementedException();
        }
    }
}
