using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button[] arrButton = new Button[16];

            arrButton[0] = button0;
            arrButton[1] = button1;
            arrButton[2] = button2;
            arrButton[3] = button3;
            arrButton[4] = button4;
            arrButton[5] = button5;
            arrButton[6] = button6;
            arrButton[7] = button7;
            arrButton[8] = button8;
            arrButton[9] = button9;
            arrButton[10] = button10;
            arrButton[11] = button11;
            arrButton[12] = button12;
            arrButton[13] = button13;
            arrButton[14] = button14;
            arrButton[15] = button15;

            int[] a = { 5, 6, 8 };
            CreateNetwork test = new CreateNetwork(a);

            int da = 5;
        }

        public void Foo()
        {

        }
    }
}
