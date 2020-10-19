using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construja.App.Domain
{
    public static class Placas
    {
      

        public static List<string>Get()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var dados = File.ReadAllLines(path + "Data/Placas.txt");
            return dados.ToList();
        }
    }

    
 
}
