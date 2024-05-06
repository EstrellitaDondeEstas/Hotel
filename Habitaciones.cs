using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Habitaciones
    {

        
        
        public int[] numero_Habitacion=new int[8];
        public string[] estilo= new string[8];
        public int[] tamaño = new int[8];
        public int[] numero_Camas = new int[8];
        public int[] precio = new int[8];
        public string[] tipo_habitacion = new string[8];
        public bool[] disponible = new bool[8];
        /*
         Hay tres habitaciones simples (en los vectores les corresponden de 0-2)
        Hay tres habitaciones dobles (en los vectores les corresponden de 3-5)
        hay dos habitaciones matrimoniales (en los vectores corresponden de 6-7)
        Mando una captura de una tabla que hice para organizar mejor mis ideas sobre este vector al grupo
         
         */
        
        public void valores_Originales()
        {
            // este metodo es para asignar los valores al proncipio del codigo, SOLO SE USA AL INICIAR EL PROGRAM
            numero_Habitacion[0] = 101; numero_Habitacion[1] = 102; numero_Habitacion[2] = 103;
            numero_Habitacion[3] = 201; numero_Habitacion[4] = 202; numero_Habitacion[5] = 203;
            numero_Habitacion[6] = 301; numero_Habitacion[7] = 302;

            estilo[0] = "Simple"; estilo[1] = "Simple"; estilo[2] = "Simple";
            estilo[3]= "Doble"; estilo[4]= "Doble"; estilo[5]= "Doble";
            estilo[6] = "Matrimonial"; estilo[7] = "Matrimonial";

            tamaño[0] = 8; tamaño[1] = 8; tamaño[2] = 8;
            tamaño[3] = 12; tamaño[4] = 12; tamaño[5] = 12;
            tamaño[6] = 15; tamaño[7] = 15;
            //Los tamaños están en metros cuadrados (m^2)

            numero_Camas[0] = 1; numero_Camas[1] = 1; numero_Camas[2] = 2; //todas son camas simples
            numero_Camas[3] = 2; numero_Camas[4] = 2; numero_Camas[5] = 3; //todas son camas simples
            numero_Camas[6] = 1; numero_Camas[7] = 1; //Todas son camas dobles

            precio[0] = 50000; precio[1] = 50000; precio[2] = 60000; //Precio en mil pesos, 60 mil, 50 mil y así
            precio[3] = 75000; precio[4] = 75000; precio[5] = 80000;
            precio[6] = 100000;precio[7] = 100000; 

            for (int i = 0; i < numero_Camas.Length; i++)
            {
                disponible[i] = false;
            }


        }
        
        public void Disponibilidad_simple()
        {
            Console.WriteLine("A continuación la disponibilidad de cada habitación simple");
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[0], disponible[0]);
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[1], disponible[1]);
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[2], disponible[2]);
        }
        
        public void Disponibilidad_doble()
        {
            Console.WriteLine("A continuación la disponibilidad de cada habitación Doble");
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[3], disponible[3]);
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[4], disponible[4]);
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[5], disponible[5]);
        }

        public void Disponibilidad_matrimonial()
        {
            Console.WriteLine("A continuación la disponibilidad de cada habitación Matrimonial");
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[6], disponible[6]);
            Console.WriteLine("Habitación {0}: {1}", numero_Habitacion[7], disponible[7]);
        }



    }
}
