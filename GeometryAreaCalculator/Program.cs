using GeometryAreaCalculator.Shapes;

namespace GeometryAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione una figura (Círculo: C, Rectángulo: R):");
                string shape = Console.ReadLine().ToUpper();

                Shape chosenShape = null;

                try
                {
                    switch (shape)
                    {
                        case "C":
                            Console.WriteLine("Ingrese el radio del círculo:");
                            double radius = double.Parse(Console.ReadLine());
                            chosenShape = new Circle(radius);
                            break;

                        case "R":
                            Console.WriteLine("Ingrese la base del rectángulo:");
                            double baseLength = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del rectángulo:");
                            double height = double.Parse(Console.ReadLine());
                            chosenShape = new Rectangle(baseLength, height);
                            break;

                        default:
                            Console.WriteLine("Opción inválida.");
                            continue;
                    }

                    double area = chosenShape.CalculateArea();
                    Console.WriteLine($"El área de la figura seleccionada es: {area}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada inválida. Por favor, ingrese un número.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("Presione Enter para continuar, o escriba 'Salir' para cerrar la aplicación.");
                string exitInput = Console.ReadLine().ToUpper();
                if (exitInput == "SALIR")
                {
                    break;
                }
            }
        }
    }
}
