namespace Hotel
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            int opcion; //Opcion que se usa para el menu

            //Le asigno los valores originales de casa habitacion, los valores no son estaticos y se pueden mover
            Habitaciones habitacion = new Habitaciones();
            habitacion.valores_Originales();
            bool salir = false; //booleano para salir del switch principal
            while (salir == false)
            {
                Console.WriteLine("Porfavor Ingrese la opcion que desea ejecutar\n" +
                              "1. Ver Disponibilidad de las habitaciones" +
                              " 2. Salir");
                opcion = int.Parse(Console.ReadLine());
                bool salirIN = false; //Booleano para salir dentro de los case del switch
                
            
                switch (opcion)
                {

                    case 1:
                        while (salirIN == false)
                        {
                            //Ver disponibilidad de cada habitación
                            Console.WriteLine("-----------De que tipo de habitacion desea ver la disponiblidad?-----------");
                            Console.WriteLine("1. Simple -----2. Doble------3. Matrimonial-----4. Volver al menú principal");
                            int opcion2 = int.Parse(Console.ReadLine());//Esta opcion es para ver el tipo de habitacion y su propia disponibilidad

                            if (opcion2 == 1)
                            {
                                habitacion.Disponibilidad_simple();
                            }
                            else if (opcion2 == 2)
                            {
                                habitacion.Disponibilidad_doble();
                            }
                            else if (opcion2 == 3)
                            {
                                habitacion.Disponibilidad_matrimonial();
                            }
                            else if (opcion2 == 4)
                            {
                                salirIN = true;
                            }


                        }

                        break;
                    case 2:
                        salir = true;
                        break;
                    default:
                        break;
                }
            }
            


        }
    }
}