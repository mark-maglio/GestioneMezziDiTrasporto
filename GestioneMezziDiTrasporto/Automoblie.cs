using GestioneMezziDiTrasporto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezziDiTrasporto
{
    public class Automobile : MezzoDiTrasporto
    {
        public int Cilindrata { get; private set; }
        public bool Elettrica { get; set; }

        private const ushort NUMERO_RUOTE = 4;
        private int v1;
        private int v2;
        private Colore colore;
        private int v3;

        public Automobile(int lunghezza, double peso, Colore colore, int cilindrata) : base(lunghezza, peso, colore)
        {
            Cilindrata = cilindrata;
            Elettrica = false;
        }

        public Automobile(int v1, int v2, Colore colore, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.colore = colore;
            this.v3 = v3;
        }

        public override ushort GetNumeroRuote()
        {
            return NUMERO_RUOTE;
        }

        public override string ToString()
        {
            return base.ToString() + $" Cilindrata = {Cilindrata}; Elettrica = {Elettrica};";
        }
    }
}