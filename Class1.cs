using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMetodosTask
{
    public class Class1
    {    
        // Lista creada para almacenar las tareas
        public List<string> tareas = new List<string>();
        // Metodo que permite agregar una nota
        public  void AgregarTarea(String tarea) {
            tareas.Add(tarea);
        }
        // metodo que permite visualizar las notas
        public List<string> VisualizarTareas()
        {
            return tareas;
        }
        // Metodo que permite vizualizar en Mesage
        public  string MostrarTarea()
         {
             string info = "Tareas Almacenadas:\n";
             foreach (string t in tareas) {
                 info += t + "\n";
             }
             return info;
         }    
       //Metodo que permite eliminar una nota  
        public  void EliminarTarea(String tareaRemove) {
            tareas.Remove(tareaRemove);
        }
      
    }
}
