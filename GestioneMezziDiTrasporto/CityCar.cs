using GestioneMezziDiTrasporto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezziDiTrasporto
{
    public class CityCar : Automobile
    {
        public CityCar(Colore colore) : base(100, 30, colore, 50) { }
    }
}