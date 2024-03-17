using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.extra._01.opl
{
    public class KopOfMunt
    {
        private Random rnd = new Random();

        public KopOfMunt() { }
        public string Werp()
        {
            if (rnd.Next(2) == 0)
            {
                return "kop";
            }
            else
            {
                return "munt";
            }
        }
    }
}
