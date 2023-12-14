using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiyerarkaşik_kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Canli
    {
        public string Beslenme { get; set; }
        public string Nefes { get; set; }
    }
    public class Hayvan : Canli
    {
        public string hareket { get; set; }
    }
    public class Köpek : Hayvan
    {
        public string HAWHAW { get; set; }
    }
    public class Kangal : Köpek
    {
        public string Guclu { get; set; }
    }

}