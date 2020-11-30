using System;

namespace parcial
{
    class Program
    {
        public static string _pathcamiones = @"C:\Users\Familia Piza\Desktop\parcial\parcial\txt\Camiones.txt";
        public static string[] lines = System.IO.File.ReadAllLines(_pathcamiones);

        public static string _pathpaquetes = @"C:\Users\Familia Piza\Desktop\parcial\parcial\txt\Paquetes.txt";
        public static string[] linesp = System.IO.File.ReadAllLines(_pathpaquetes);

        static void Main(string[] args)
        {            
            camiones[] data = new camiones[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = porlineas(lines[i]);
            }
            paquetes[] datap = new paquetes[linesp.Length];
            for (int j = 0; j < linesp.Length; j++)
            {
                datap[j] = porlineasp(linesp[j]);

            }
            foreach(camiones camion in data)
            {
                Console.WriteLine("El camion Identificado con "+ camion.Id+" con una capacidad de volumen "+ camion.volumen+" y de peso "+ camion.peso);
                Console.WriteLine("Lleva los paquetes:");
                double volumentotal = 0;
                int pesototal = 0;
                foreach(paquetes paquete in datap)
                {
                    volumentotal = volumentotal + paquete.volumenp;
                    if (camion.volumen >= volumentotal )
                    {
                        pesototal = pesototal + paquete.pesop;
                        if (camion.peso >= pesototal) 
                        {
                        Console.WriteLine("El paquete Identificado con " + paquete.Idp + " con un volumen de " + paquete.volumenp+" y peso de "+ paquete.pesop);
                        }
                    }
                }
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
        public static camiones porlineas (string s)
        {
            string[] data = s.Split(";");

            return new camiones(
                Id: Convert.ToInt32(data[0]),
                volumen: Convert.ToInt32(data[1]),
                peso: Convert.ToInt32(data[2])
                );
        }
        public static paquetes porlineasp(string p)
        {
            string[] datap = p.Split(";");

            return new paquetes(
                Idp: Convert.ToInt32(datap[0]),
                volumenp: Convert.ToDouble(datap[1]),
                pesop: Convert.ToInt32(datap[2])
                );
        }
    }
}
