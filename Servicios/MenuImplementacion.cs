namespace FicheroLeerArchvivo_modificar_insetar_guardar_ej6.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        public int MenuPrincipal()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Insertar linea");
            Console.WriteLine("2.Modificar linea");
            Console.WriteLine("3.Leer archivo");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
           
        }
    }
}