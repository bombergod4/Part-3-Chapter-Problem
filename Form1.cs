using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3_Chapter_Problem
{
    public partial class FrmMain : Form
    {
        int age = 60;
        string name;
        double height;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void trkbarAge_Scroll(object sender, EventArgs e)
        {
            age = trkbarAge.Value;
            lblAge.Text = "Age = " + age;       
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            height = Convert.ToDouble(txtHeight.Text);
            trkbarAge.Visible = false;
            lblHeight.Visible = false;
            lblName.Visible = false;
            txtHeight.Visible = false;
            txtName.Visible = false;
            lblAge.Visible = false;
            btnSubmit.Visible = false;
            lblGreetings.Visible = true;
            lblOutput.Visible = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            System.IO.Stream str = Properties.Resources.Grubhub_Delivery_Dance_Song___Bomba_Estéreo___Soy_Yo;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            if (age < 83)
                lblGreetings.Text = "Greetings " + name + ", you are " + (83 - age) + " years away from death.";
            else if (age == 83)
                lblGreetings.Text = "Greetings " + name + ", you are at the life expectancy of 83.";
            else
                lblGreetings.Text = "Greetings " + name + ", you are " + (age - 83) + " over the average life expectancy.";
            if (height < 2.72)
                lblOutput.Text = "Also, you are " + (2.72 - height) + " shorter than the tallest man.";
            else if (height == 2.72)
                lblOutput.Text = "Also, you are the tallest man in the world at a whopping 2.72 M!";
            else
                lblOutput.Text = "You are a liar. Nobody is " + height + " meters high.";
        }
    }
}
