using System;
/*1) Definir un arreglo de tipo STRING y del tamaño de los días semana. Se debe asignar los
correspondientes días para cada posición del arreglo. Luego utilizando un bucle FOR recorrer el
arreglo mostrando cada elemento del mismo por pantalla.*/
namespace TP8C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diasSemana = {"Lunes","Martes","Miercoles","Jueves","Viernes"};

            for (int i = 0; i < diasSemana.Length; i++)
            {
                Console.WriteLine("Dia de la semana "+(i+1)+" "+diasSemana[i]);
            }
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();
        }
    }
}
