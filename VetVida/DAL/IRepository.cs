using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository <T> 
    {
        // Definición de la interfaz IRepository
        // Métodos para agregar, eliminar, buscar y listar entidades
        string Guardar(T entity);
        List<T> Consultar();
        string Modificar(T entity);
        string Eliminar(int id);
    }
}
