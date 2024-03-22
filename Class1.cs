using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LibreriaMetodosTask
{
    public class TareasManager
    {
        // Lista creada para almacenar las tareas
        public List<string> tareas = new List<string>();
        private string docPath;

        // Metodo que permite agregar una nota
        public void AgregarTarea(string tarea)
        {
            tareas.Add(tarea);
        }

        // metodo que permite visualizar las notas
        public List<string> VisualizarTareas()
        {
            return tareas;
        }

        // Metodo que permite vizualizar en Mensaje
        public string MostrarTareas()
        {
            string info = "Tareas Almacenadas:\n";
            foreach (string t in tareas)
            {
                info += t + "\n";
            }
            return info;
        }

        //Metodo que permite eliminar una nota  
        public void EliminarTarea(string tareaRemove)
        {
            tareas.Remove(tareaRemove);
        }

        //Metodo que permite guardar el archivo en txt
        public async Task regTextAsync(string cadena)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteTextAsync.txt")))
            {
                await outputFile.WriteAsync("This is a sentence.");
            }
        }
    }
}