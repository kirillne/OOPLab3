using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engines;
using Transports;
using Transports.AirTransports;
using Transports.GroundTransports;

namespace MainFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> elements = new List<object>
            {
               new Car(new InternalCombustionEngine(10,5),"ASD",4,true,4,4,10 ),
               new Plane(new Turbine(2),"QWE",2000,700,50,new Wing(500,10),false ),
               new Helicopter(new PistonlessRotaryEngine(5,10),"DFG",2000,0,1,new Screw(4,10),new Screw(2,1)  )
            };
            treeView1.Nodes.Add( TreeCreater.GetTree(elements));
        }
    }
}
