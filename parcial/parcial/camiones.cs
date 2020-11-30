using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    public class camiones
    {
        public int Id { get; set; }
        public int volumen { get; set; }
        public int peso { get; set; }
        public camiones(int Id, int volumen, int peso)
        {
            this.Id = Id;
            this.volumen = volumen;
            this.peso = peso;
        }
        public override string ToString()
        {
            string s = string.Format(
                "ID camion: {0}, volumen camion: {1}, peso camion: {2}",
                this.Id, this.volumen, this.peso
                );
            return s;
        }
    }
}
