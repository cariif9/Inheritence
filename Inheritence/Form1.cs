using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PersnInfoBtn_Click(object sender, EventArgs e)
        {

        }


        class Car : AoutoMobile
        {

            private int doors;
            private double tax;


            public Car()
            {
                doors = 0;
                tax = 10.0;
            }

            public int Doors
            {
                get { return doors; }
                set { doors = value; }

            }
            public double Tax { 
                get { return tax*0.05; }
                set { tax = value; }
            }
        }

        class AoutoMobile
        {

            private String Model;
            private decimal price;
            private int lifeTime;
            private int YearModel;


            public AoutoMobile()
            {

            }

            public String _Model
            {
                get { return Model; }
                set { Model = value; }
            }
            public decimal _Price
            {
                get { return price; }
                set { price = value; }
            }
            public int _LifeTime
            {
                get { return lifeTime; }
                set { lifeTime = value; }
            }
            public int _YearModel { 
            
                get { return YearModel; }
                set { YearModel = value; }
            }
        }
    }
}
