using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTarea.Dominio.Interfaces;

namespace AppTarea.Dominio.Interfaces.Repositorio
{
    public interface IRrepositorioLogin<TEntidad>
        :ILogin<TEntidad>, IAgregar<Usuario>
    {
    }
}
