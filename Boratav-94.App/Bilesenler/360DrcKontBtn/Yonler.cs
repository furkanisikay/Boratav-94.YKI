using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boratav_94.App.Bilesenler
{
    public enum Yonler
    {
        None = 0,
        Yukari = 1,
        Asagi = 2,
        Sag = 3,
        Sol = 4
    }
    public static class YonlerTools
    {
        public static Yonler Parse(this int value)
        {
            switch (value)
            {
                case 1:
                    return Yonler.Yukari;
                case 2:
                    return Yonler.Asagi;
                case 3:
                    return Yonler.Sag;
                case 4:
                    return Yonler.Sol;
                default:
                    return Yonler.None;
            }
        }
    }
}
