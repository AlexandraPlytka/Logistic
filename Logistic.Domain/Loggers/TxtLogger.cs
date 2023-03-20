using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Logistic.Domain.Loggers
{
    internal class TxtLogger
    {
        private string _sourceFileName = "C:\\Users\\Lesia\\Desktop\\study\\practice\\Logistic\\Logistic.Domain\\Data\\txt\\errors.txt";
        public void LogError(string error)
        {
            var sw = new StreamWriter(_sourceFileName);
            sw.WriteLine(error);
            sw.Close();
        }

        private TxtLogger() { }
        private static TxtLogger _instance;
        public static TxtLogger GetLogger()
        {
            if (_instance == null)
                _instance = new TxtLogger();
            return _instance;
        }
    }
}
