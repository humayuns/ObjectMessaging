using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectMessaging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISenderReceiver obj = new HelloBuilder();

            ShowMessage(obj);

            obj = new HiBuilder();


            obj.Receive("Humayun");
            ShowMessage(obj);

        }

        private static void ShowMessage(ISenderReceiver obj)
        {
            obj.Receive("Humayun");
            MessageBox.Show(obj.Send(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ISenderReceiver obj = null;
            if (radioButton1.Checked)
                obj = ObjectFactory.GetBuilder(ObjectFactory.BuilderType.Hello);
            else if(radioButton2.Checked)
                obj = ObjectFactory.GetBuilder(ObjectFactory.BuilderType.Hi);

            ShowMessage(obj);
        }
    }
}
