using consumir_web_api.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumir_web_api.Servicios
{
   public interface IRickAndMortyService
    {
        public Task<List<PersonajesResponse>> Obtener();

    }
}
