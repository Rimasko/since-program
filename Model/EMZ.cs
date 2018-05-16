using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace NewSince.Model
{
     public  class EMZ
     {
         public List<double> Ref;
         public List<double> Raznos;
         public Dictionary<double, double> DempInf;
         public Color LineColor;
         public SeriesChartType TyeChartType;
         public string name;
         public int numberProfile;
         public int RaznosYst;
     }
}
