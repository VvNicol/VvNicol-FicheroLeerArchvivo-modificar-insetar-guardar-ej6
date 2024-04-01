using FicheroLeerArchvivo_modificar_insetar_guardar_ej6.Servicios;

namespace FicheroLeerArchvivo_modificar_insetar_guardar_ej6.Controladores
{
    internal class Program
    {       
        static string archivo = "miArchivo.txt";
     
        static void Main(string[] args)
        {           
            MenuInterface mi = new MenuImplementacion();
            OperativaInterface oi = new OperativaImplementacion();

            bool esCerrado = false;
            int opcionElegida;

            using (StreamWriter sw = new StreamWriter(archivo))
            {
                sw.WriteLine("Texto 0        ");
                sw.WriteLine("Texto 1        ");
                sw.WriteLine("Texto 2        ");
                sw.WriteLine("Texto 3        ");
                sw.WriteLine("Texto 4        ");
                sw.WriteLine("Texto 5        ");
                sw.WriteLine("Texto 6        ");
                sw.WriteLine("Texto 7        ");
                sw.WriteLine("Texto 8        ");
                sw.WriteLine("Texto 9        ");
            }
            try {
                 do
                    {
                    opcionElegida = mi.MenuPrincipal();
                    switch (opcionElegida)
                    {
                        case 0:
                        esCerrado = true;
                             break;
                        case 1:
                             oi.InsertarTexto();
                             break;
                        case 2:
                             oi.ModificarLinea();
                             break;
                        case 3:
                             string line;
                             StreamReader sr = new StreamReader(archivo);
                             line = sr.ReadLine();
                             while(line != null)
                             {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                             }
                             sr.Close();  
                             break;
                        }
                    
                    } while (!esCerrado);

            } catch (IOException io)
            {
               Console.WriteLine("Error al leer o escribir : " + io.Message);
            }
        }
    }
}
