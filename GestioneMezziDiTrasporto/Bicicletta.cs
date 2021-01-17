using GestioneMezziDiTrasporto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezziDiTrasporto
{
    public class Bicicletta : MezzoDiTrasporto
    {
        public int NumeroRuota { get; set; }

        private const ushort NUMERO_RUOTE = 4;

        public Bicicletta(double peso, Colore colore) : base(70, peso, colore) { }

        public override ushort GetNumeroRuote()
        {
            return NUMERO_RUOTE;
        }

        public override string ToString()
        {
            return base.ToString() + $" Numero ruota = {NumeroRuota};";
        }
    }
}