using System;

using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int chi;
        float chiv;
       
       
        public Form1()
        {
            InitializeComponent();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Display(textBox1.Text);

        }

        public string  Display(string c)
        {
            
            
            try
            {

                if (checkBox1.Checked == false)
                {
                    chi = int.Parse(c);
                    if ((chi > 1) && (chi % chi == 0 && chi % 1 == 0) && (chi >= 20 && chi <= 50))
                    {

                    c=  label1.Text = "Натуральное число";
                      
                    }
                    else
                    {
                        throw new Exception("Ошибка");
                    }
                   
                }

                if (checkBox1.Checked == true)
                {
                    chiv = float.Parse(c);
                    if (chiv >= 20 && chiv <= 50)
                    {
                        c = label1.Text = "Вещественное число";
                        
                    }
                    else
                    {
                        throw new Exception("Ошибка");
                    }

                    
                }

               

            }
            catch (Exception)
            {

                c = label1.Text = "Ошибка";
                
            }

            return c;
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
