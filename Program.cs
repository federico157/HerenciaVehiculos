using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Herencia de Vehiculos ");

            /*Vehiculo Carro = new Vehiculo(); //crear objeto/instancia de tipo coche

            Console.WriteLine(" CARRO ");
            Console.WriteLine(Carro.getInfoVehiculo());
            Carro.setExtras(" Blanco ", " Corriente ", true);
            Console.WriteLine(Carro.getExtras());*/
            Console.WriteLine(" Coupe "); 
            Motor coupe = new Motor();
            Vehiculo Coupe = new Vehiculo();          
            Console.WriteLine(Coupe.getInfoVehiculo());
            Coupe.setExtras(" Blanco ", " Diesel ", true );
            Console.WriteLine(Coupe.getExtras());

            Console.WriteLine(" Sedan ");
            Vehiculo Sedan = new Vehiculo();
            Console.WriteLine(Sedan.getInfoVehiculo());
            Sedan.setExtras(" Azul Magenta ", " Diesel ", true);
            Console.WriteLine(Sedan.getExtras());

            Console.WriteLine(" Suv ");
            Vehiculo Suv = new Vehiculo();
            Console.WriteLine(Suv.getInfoVehiculo());
            Suv.setExtras(" Negro Mate ", " Corriente ", false);
            Console.WriteLine(Suv.getExtras());


                            

            

        }
      
    }

    class Vehiculo
    {
        public Vehiculo()
        {
            Ruedas = 4;

            Capacidad = 5;

            Modelo = 2015;

            Precio = 7000;

           // Color = (" Blaco Perla");

        }

        public String getInfoVehiculo()
        {
            return "Información del coche; \n" + " Ruedas: " + Ruedas  + " Capacidad: " + Capacidad + " Modelo: " + Modelo + " Precio: " + Precio;
        }

        public void setExtras(String paramColor, String tipoConbustible, bool paramLuces)
        {
            Color = paramColor;

            Combustible = tipoConbustible;

            Luces = paramLuces;

        }

        public String getExtras()
        {
            return "Caracteristicas del coche: \n " + "color: " + Color + " Combustible: " + Combustible + " Luces: " + Luces;
        }


        public string Combustible; 
        
        public int Ruedas;

        public string Color;
            
        public int Precio = 0;

        public int Modelo = 0;

        public int Capacidad = 0;

        public bool Luces;

        

        public bool Enciende;

        public int Velocidad;

        public bool frena ;
       
    }

    class Motor
    {

        public string modoAlimentacion;

       
        public void setAdmision() { }

        public void setCompresion() { }

        public void setEscape() { }


    }


    class Carro
    {
        public Carro() 
        {
             
        }

        private string Carroceria;

        private int Cilindraje = 180;

        private string Motor;

        private bool Accesorios;

        

        public bool enciendeLuces;

        public bool bloquearPuertas;

        public void setEncenderAire() { }

    }

    
    class Clase
    {
        private int Puertas = 0;

        private string Suspencion;

        private string Transmicion;

        private string Rines;

        private string SistemaFrenos;


    }

}
