using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    public class paquetes
    {
        public int Idp { get; set; }
        public double volumenp { get; set; }
        public int pesop { get; set; }
        public paquetes(int Idp, double volumenp, int pesop)
        {
            this.Idp = Idp;
            this.volumenp = volumenp;
            this.pesop = pesop;
        }
        public override string ToString()
        {
            string p = string.Format(
                "ID Paquete: {0}, Volumen Paquete: {1}, Peso Paquete: {2}",
                this.Idp, this.volumenp, this.pesop
                );
            return p;
        }
    }
}
