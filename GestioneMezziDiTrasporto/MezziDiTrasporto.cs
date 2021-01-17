using GestioneMezziDiTrasporto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezziDiTrasporto
{
    public abstract class MezzoDiTrasporto
    {
        public int Lunghezza { get; private set; }
        public double Peso { get; private set; }
        public Colore Colore { get; private set; }

        public MezzoDiTrasporto(int lunghezza, double peso, Colore colore)
        {
            Lunghezza = lunghezza;
            Peso = peso;
            Colore = Colore;
        }

        protected MezzoDiTrasporto(int v, double peso, Colore colore)
        {
            Peso = peso;
        }

        public abstract ushort GetNumeroRuote();

        public override string ToString()
        {
            return $"{GetType().Name} : Lunghezza = {Lunghezza}; Peso = {Peso}; Colore = {Colore}; Numero ruote = {GetNumeroRuote()};";
        }
    }
}