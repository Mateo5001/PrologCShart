using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAplicationProlog
{
  class Program
  {
    static void Main(string[] args)
    {
      Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl");
      Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
      string[] motorPL = { "-q", "-f", "frascos.pl" };
      PlEngine.Initialize(motorPL);
      PlQuery querryresolver = new PlQuery("resolver");
      var respuestas = querryresolver.SolutionVariables.FirstOrDefault();
    }
  }
}
