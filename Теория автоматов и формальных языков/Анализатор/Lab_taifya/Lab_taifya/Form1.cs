using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_taifya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int currentPosition = input_box.SelectionStart;
            input_box.SelectAll();
            //input_box.SelectionFont = new Font(DefaultFont, FontStyle.Regular);
            input_box.SelectionColor = Color.Black;
            identificators_and_constants.Items.Clear();
            var text = input_box.Text.ToUpper();
            ClassResult a = ClassCheck.Check(text);
            label3.Text = a.ErrMessage;
            if (a.ErrPosition == -1)
            {
                identificators_and_constants.Items.Add("СПИСОК ИДЕНТИФИКАТОРОВ:");
                identificators_and_constants.Items.Add(" Имя - Вид");
                a.ListOfIds.ToList().ForEach((value) => identificators_and_constants.Items.Add(value));
                identificators_and_constants.Items.Add("СПИСОК КОНСТАНТ:");
                identificators_and_constants.Items.Add(" Значение - Вид - Тип");
                a.ListOfConst.ToList().ForEach((value) => identificators_and_constants.Items.Add(value));


            }
            else
            {
 
                label3.ForeColor = Color.Red;
                label3.Text = a.ErrMessage;
                input_box.Select(a.ErrPosition, input_box.Text.Length - a.ErrPosition);
                if (input_box.SelectionLength > 0)
                    input_box.SelectionLength = 1;
                    input_box.Focus();
            
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            input_box.Clear();
            identificators_and_constants.Items.Clear();
        }
    }
}
