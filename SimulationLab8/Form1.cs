using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationLab8
{
    public partial class Form1 : Form
    {
        BasicSensor rnd = new BasicSensor();
        float propabilityOfNo = 0.5f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            if (rnd.GetRandomNumber() <= propabilityOfNo)
            {
                label_answer.Text = "No";
            }
            else
            {
                label_answer.Text = "Yes";
            }
        }

        enum EOrbAnswers
        {
            You_should_drink_water,
            Yes,
            No,
            I_dont_know,
            Play_video_game,
            Do_nothing
        }

        private void button_orb_Click(object sender, EventArgs e)
        {
            label_orbAnswer.Text = Convert.ToString((EOrbAnswers)rnd.Next(0, 5));
        }
    }
}
