

namespace CalcularSueldo.Class
{
    public class Calcular
    {
        public void CalcularSueldo() {

            int horasTrabajadas = 0;
            int costoHoras = 0;
            decimal sueldo = 0;


            Console.WriteLine("\n\nDigite las horas trabajadas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el costo de las horas: ");
            costoHoras += Convert.ToInt32(Console.ReadLine());

            sueldo = (horasTrabajadas *  costoHoras);

            Console.WriteLine($"El sueldo es: {sueldo}\n\n");


            Console.Write("press any key to continue...");
            Console.ReadKey(true);


        }



    }
}
