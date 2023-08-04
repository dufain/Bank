using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Utils
    {
        public static int GenerateRandomNumber(int length)
        {
            return new Random().Next(0, length);
        }
    }
}
