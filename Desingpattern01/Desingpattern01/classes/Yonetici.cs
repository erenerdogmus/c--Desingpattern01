using System;
using System.Collections.Generic;
using System.Text;

namespace Desingpattern01.classes
{
    class Yonetici
    {
        public Cıktı FactoryMethod(CıktıTuru cıktıTuru)
        {
            Cıktı Cıktı01 = null;

            switch (cıktıTuru)
            {
                case CıktıTuru.cıktı1:
                    Cıktı01 = new Cıktı1();
                    break;

                case CıktıTuru.cıktı2:
                    Cıktı01 = new Cıktı2();
                    break;

                case CıktıTuru.cıktı3:
                    Cıktı01 = new Cıktı3();
                    break;
            }
            return Cıktı01;
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}

