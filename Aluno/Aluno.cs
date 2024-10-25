﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    internal class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Soma()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if(Soma() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - Soma();
            }
        }


    }
}
