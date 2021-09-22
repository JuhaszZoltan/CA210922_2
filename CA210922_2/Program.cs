using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210922_2
{
    public enum UrmertekTipus
    {
        Liter,
        Kanna,
        Gallon,
    };

    class Gepjarmu
    {
        protected int _benzinMennyisege;
        public int tankMerete;
        private int _hengerekSzama;
        public void Tankol()
        {
            _benzinMennyisege = tankMerete;
        }

        public void Tankol(int mennyiseg, UrmertekTipus u)
        {
            switch (u)
            {
                case UrmertekTipus.Liter: _benzinMennyisege += mennyiseg;
                    break;
                case UrmertekTipus.Kanna:
                    _benzinMennyisege += mennyiseg * 20;
                    break;
                case UrmertekTipus.Gallon:
                    _benzinMennyisege += (int)(mennyiseg * 4.5);
                    break;
            }
        }

        



        public Gepjarmu()
        {
            _hengerekSzama = 4;
        }

        public Gepjarmu(int benzinMennyisege) : this()
        {
            _benzinMennyisege = benzinMennyisege;
        }

        public Gepjarmu(int benzinMennyisege, int tankMerete): this(benzinMennyisege)
        {
            this.tankMerete = tankMerete;
        }
    }

    class Auto : Gepjarmu
    {
        public int szallithatoSzemelyekSzama = 4;
    }

    class Program
    {
        static void Main()
        {
            //Auto a = new Auto()
            //{
            //    szallithatoSzemelyekSzama = 5,
            //    tankMerete = 75,
            //};

            //Gepjarmu babetta = new Gepjarmu()
            //{
            //    tankMerete = 10,
            //};

            //babetta.Tankol(20, UrmertekTipus.Kanna);


            Gepjarmu g = new Gepjarmu(100, 1000);

            g.Tankol();
          
            Console.ReadKey();
        }
    }
}
