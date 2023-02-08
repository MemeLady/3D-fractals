using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Lab3
{
    public partial class Form1 : Form
    {
        bool isStarted = false;
        bool isTree = false;
        float posX, posY, currentPosX, currentPosY;
        float angle = 0;
        float lineSize = 10;
        string mainRule = "";
        int mouseDownX;
        int mouseDownY;
        bool isMouseDown;
        Random rnd = new Random();
        int r, g, b;
        Pen p;
        List<float[]> state = new List<float[]>();
        Dictionary<string, string> rules = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            p = new Pen(Color.FromArgb(255, r, g, b));
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            posX = pictureBox1.Size.Width / 2;
            posY = pictureBox1.Size.Height / 2;

            if (isStarted)
            {
                nextIteration();
                pictureBox1.Refresh();
                iterationLabel.Text = (Convert.ToInt32(iterationLabel.Text) + 1).ToString();
                return;
            }
            if (comboBox1.Text == "Снежинка")
            {
                snowflake();
                isStarted = !isStarted;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Дракон")
            {
                dragon();
                isStarted = !isStarted;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Треугольник")
            {
                triangle();
                isStarted = !isStarted;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Кривая")
            {
                curve();
                isStarted = !isStarted;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Дерево 1")
            {
                treeOne();
                isStarted = !isStarted;
                isTree = true;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Дерево 2")
            {
                treeTwo();
                isStarted = !isStarted;
                isTree = true;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Дерево 3")
            {
                treeThree();
                isStarted = !isStarted;
                isTree = true;
                pictureBox1.Refresh();
                return;
            }
            else if (comboBox1.Text == "Дерево 4")
            {
                treeFour();
                isStarted = !isStarted;
                isTree = true;
                pictureBox1.Refresh();
                return;
            }
        }

        private void snowflake()
        {
            rules.Clear();
            mainRule = "F++F++F";
            rules.Add("angle", "60");
            rules.Add("F", "F-F++F-F");
        }

        private void dragon()
        {
            rules.Clear();
            mainRule = "FX";
            rules.Add("angle", "90");
            rules.Add("F", "F");
            rules.Add("X", "X+YF+");
            rules.Add("Y", "-FX-Y");
        }

        private void triangle()
        {
            rules.Clear();
            mainRule = "FXF--FF--FF";
            rules.Add("angle", "60");
            rules.Add("F", "FF");
            rules.Add("X", "--FXF++FXF++FXF--");
        }

        private void curve()
        {
            rules.Clear();
            mainRule = "X";
            rules.Add("angle", "90");
            rules.Add("F", "F");
            rules.Add("X", "-YF+XFX+FY-");
            rules.Add("Y", "+XF-YFY-FX+");
        }

        private void treeOne()
        {
            rules.Clear();
            mainRule = "F";
            rules.Add("angle", "25,7");
            rules.Add("F", "F[+F]F[-F]F");
        }

        private void treeTwo()
        {
            rules.Clear();
            mainRule = "F";
            rules.Add("angle", "20");
            rules.Add("F", "F[+F]F[-F][F]");
        }

        private void treeThree()
        {
            rules.Clear();
            mainRule = "X";
            rules.Add("angle", "25,7");
            rules.Add("F", "FF");
            rules.Add("X", "F[+X][-X]FX");
        }

        private void treeFour()
        {
            rules.Clear();
            mainRule = "F";
            rules.Add("angle", "20");
            rules.Add("F", "-F[-F+F-F]+[+F-F-F]");
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            lineSize = (float)(lineSize * 1.5);
            pictureBox1.Refresh();
        }

        private void bistanceButton_Click(object sender, EventArgs e)
        {
            lineSize = (float)(lineSize / 1.5);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown) 
            {
                posX += (e.X - mouseDownX) / 50;
                posY += (e.Y - mouseDownY) / 50;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void nextIteration()
        {
            string tempRule = "";
            while (mainRule.Length != 0)
            {
                if (rules.ContainsKey(mainRule[0].ToString()))
                {
                    tempRule += rules[mainRule[0].ToString()];
                    mainRule = mainRule.Substring(1);
                }
                else
                {
                    tempRule += mainRule[0];
                    mainRule = mainRule.Substring(1);
                }
            }
            mainRule = tempRule;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!isStarted)
            {
                return;
            }

            currentPosX = posX;
            currentPosY = posY;

            if (isTree)
            {
                angle = 180;
            }
            else
            {
                angle = 0;
            }

            for (int i = 0; i < mainRule.Length; i++)
            {
                if (mainRule[i] == 'F')
                {
                    float newPosX = currentPosX + (float)Math.Cos(angle * Math.PI / 180) * lineSize;
                    float newPosY = currentPosY + (float)Math.Sin(angle * Math.PI / 180) * lineSize;
                    e.Graphics.DrawLine(p, currentPosX, currentPosY, newPosX, newPosY);

                    currentPosX = newPosX;
                    currentPosY = newPosY;
                }
                else if (mainRule[i] == '+') 
                {
                    angle += float.Parse(rules["angle"]);
                }
                else if (mainRule[i] == '-')
                {
                    angle -= float.Parse(rules["angle"]);
                }
                else if (mainRule[i] == '[')
                {
                    float[] temp = new float[3];
                    temp[0] = angle;
                    temp[1] = currentPosX;
                    temp[2] = currentPosY;

                    state.Add(temp);
                }
                else if (mainRule[i] == ']')
                {
                    float[] temp = state[state.Count - 1];

                    angle = temp[0];
                    currentPosX = temp[1];
                    currentPosY = temp[2];

                    state.RemoveAt(state.Count - 1);
                }
            }
        }       
    }
}
