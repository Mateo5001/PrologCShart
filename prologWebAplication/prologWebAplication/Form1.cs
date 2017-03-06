using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prologWebAplication
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl");
      Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
      string[] motorPL = { "-q", "-f", "frascos.pl" };
      PlEngine.Initialize(motorPL);

    }

    private void btnResolver_Click(object sender, EventArgs e)
    {
      //PlQuery querryClient = new PlQuery(@"cargar('frascos.bd')");
      //querryClient.NextSolution();
      PlQuery querryresolver = new PlQuery("resolver");
      var respuestas = querryresolver.SolutionVariables.FirstOrDefault();
    }
  }
}
