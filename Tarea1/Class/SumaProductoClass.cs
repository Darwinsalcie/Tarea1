
namespace SumaProducto.Class
{
    public class Sumaproducto
    {
        public void sumaymultiplica()
        {

            int num1 = 0, num2 = 0;   //variables de los números
            int suma = 0, producto = 0;    //variables de las operaciones

            Console.WriteLine("\nSumador y multplicador de números:\n\n");

            while (true)                                                                        //manejo de errores
            {

                try
                {
                    Console.Write("Ingresa el primer número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("¡Solo se admiten números!");
                }

            }

            while (true)                                                                        //manejo de errores para num2
            {
                try
                {
                    Console.Write("Ingresa el segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (Exception)
                {

                    Console.WriteLine("¡Solo se admiten números!");
                }
            }


            suma = num1 + num2;                                                                 //operación de suma
            producto = num1 * num2;                                                             //operación de multiplicacion                   


            Console.WriteLine($"\nEl resultado {num1} + {num2} es: {suma}   |   El resultado de {num1} X {num2} es: {producto}\n");  //Se imprime la suma y la multpilicaición




            Console.Write("press any key to continue...");
            Console.ReadKey(true);


        }
    }

}
