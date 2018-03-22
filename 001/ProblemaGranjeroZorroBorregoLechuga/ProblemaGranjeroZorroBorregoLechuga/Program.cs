using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGranjeroZorroBorregoLechuga
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string e = new Program().Validate("GGzzzbb");
        }
        public string Validate(string parameters)
        {
            string result = string.Empty;
            var granjeros = parameters.Count(s => s == 'G');
            var zorras = parameters.Count(s => s == 'z');
            var borregos = parameters.Count(s => s == 'b');
            var lechugas = parameters.Count(s => s == 'l');

            if ((granjeros >= zorras && granjeros >= borregos))
            {
                result = "";
            }
            else if (zorras >= (borregos + granjeros) && borregos > 0)
            {
                result = "Zorra come Borrego";
            }
            else if(borregos >= (lechugas + granjeros) && lechugas > 0)
            {
                result = "Borrego come Lechuga";
            }
            return result;
        }
    }
}
