using System.Windows.Forms;

namespace alipro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter_b = 0;
        int counter_p_a = 3;
        int counter_p_b = 0;
        int counter_c_a = 3;
        int counter_c_b = 0;
        bool go_down = true;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void c11_Click(object sender, EventArgs e)
        {
                if (counter_b < 2 && go_down)
                {
                    counter_b++;
                    c11.Visible = false;
                    if (cb1.Visible == false && pb1.Visible == false)
                    {
                        cb1.Visible = true;
                    }
                    else if (cb2.Visible == false && pb2.Visible == false)
                    {
                        cb2.Visible = true;
                    }
                }
            }
        private void c12_Click(object sender, EventArgs e)
        {
                if (counter_b < 2 && go_down)
            {
                counter_b++;
                c12.Visible = false;
                if (cb1.Visible == false && pb1.Visible == false)
                {
                    cb1.Visible = true;
                }
                else if (cb2.Visible == false && pb2.Visible == false)
                {
                    cb2.Visible = true;
                }
            }
        }

        private void c13_Click(object sender, EventArgs e)
        {
            if (counter_b < 2 && go_down)
            {
                counter_b++;
                c13.Visible = false;
                if (cb1.Visible == false && pb1.Visible == false)
                {
                    cb1.Visible = true;
                }
                else if (cb2.Visible == false && pb2.Visible == false)
                {
                    cb2.Visible = true;
                }
            }
        }

        private void p13_Click(object sender, EventArgs e)
        {
            if (counter_b < 2 && go_down)
            {
                counter_b++;
                p13.Visible = false;
                if (pb1.Visible == false && cb1.Visible == false)
                {
                    pb1.Visible = true;
                }
                else if (pb2.Visible == false && cb2.Visible == false)
                {
                    pb2.Visible = true;
                }
            }
        }

        private void p12_Click(object sender, EventArgs e)
        {
            if (counter_b < 2 && go_down)
            {
                counter_b++;
                p12.Visible = false;
                if (pb1.Visible == false && cb1.Visible == false)
                {
                    pb1.Visible = true;
                }
                else if (pb2.Visible == false && cb2.Visible == false)
                {
                    pb2.Visible = true;
                }
            }
        }

        private void p11_Click(object sender, EventArgs e)
        {
            if (counter_b < 2 && go_down)
            {
                counter_b++;
                p11.Visible = false;
                if (pb1.Visible == false && cb1.Visible == false)
                {
                    pb1.Visible = true;
                }
                else if (pb2.Visible == false && cb2.Visible == false)
                {
                    pb2.Visible = true;
                }
            }
        }
        private void cb2_Click(object sender, EventArgs e)
        {
            if (counter_b>0)
            {
                counter_b--;
                if (cb2.Visible)
                {
                    if (!c11.Visible)
                    {
                        c11.Visible = true;
                        cb2.Visible = false;
                    }
                    else if (!c12.Visible)
                    {
                        c12.Visible = true;
                        cb2.Visible = false;
                    }
                    else if (!c13.Visible)
                    {
                        c13.Visible = true;
                        cb2.Visible = false;
                    }
                }
            }
           
           
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (counter_b > 0)
            {
                counter_b--;
                if (pb2.Visible)
                {
                    if (!p11.Visible)
                    {
                        p11.Visible = true;
                        pb2.Visible = false;
                    }
                    else if (!p12.Visible)
                    {
                        p12.Visible = true;
                        pb2.Visible = false;
                    }
                    else if (!p13.Visible)
                    {
                        p13.Visible = true;
                        pb2.Visible = false;
                    }
                }
            }


        }

        private void cb1_Click(object sender, EventArgs e)
        {
            if (counter_b > 0)
            {
                counter_b--;
                if (cb1.Visible)
                {
                    if (!c11.Visible)
                    {
                        c11.Visible = true;
                        cb1.Visible = false;
                    }
                    else if (!c12.Visible)
                    {
                        c12.Visible = true;
                        cb1.Visible = false;
                    }
                    else if (!c13.Visible)
                    {
                        c13.Visible = true;
                        cb1.Visible = false;
                    }
                }
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (counter_b > 0)
            {
                counter_b--;
                if (pb1.Visible)
                {
                    if (!p11.Visible)
                    {
                        p11.Visible = true;
                        pb1.Visible = false;
                    }
                    else if (!p12.Visible)
                    {
                        p12.Visible = true;
                        pb1.Visible = false;
                    }
                    else if (!p13.Visible)
                    {
                        p13.Visible = true;
                        pb1.Visible = false;
                    }
                }
            }
        }

        private void boat_Click(object sender, EventArgs e)
        {
            // go down
            if (go_down)
            {
                if (counter_b == 2)
                {
                    for (int i = panel1.Bottom; i <= lblbottom.Top; i++)
                    {
                        panel1.Left += 2;
                        panel1.Top++;
                    }
                    if (pb1.Visible)
                    {
                        if (!p21.Visible)
                        {
                            p21.Visible = true;
                            pb1.Visible = false;
                        }
                        else if (!p22.Visible)
                        {
                            p22.Visible = true;
                            pb1.Visible = false;
                        }
                        else if (!p23.Visible)
                        {
                            p23.Visible = true;
                            pb1.Visible = false;
                        }
                        counter_p_a--;
                        counter_p_b++;
                    }
                    if (pb2.Visible)
                    {
                        if (!p21.Visible)
                        {
                            p21.Visible = true;
                            pb2.Visible = false;
                        }
                        else if (!p22.Visible)
                        {
                            p22.Visible = true;
                            pb2.Visible = false;
                        }
                        else if (!p23.Visible)
                        {
                            p23.Visible = true;
                            pb2.Visible = false;
                        }
                        counter_p_a--;
                        counter_p_b++;
                    }
                    if (cb1.Visible)
                    {
                        if (!c21.Visible)
                        {
                            c21.Visible = true;
                            cb1.Visible = false;
                        }
                        else if (!c22.Visible)
                        {
                            c22.Visible = true;
                            cb1.Visible = false;
                        }
                        else if (!c23.Visible)
                        {
                            c23.Visible = true;
                            cb1.Visible = false;
                        }
                        counter_c_a--;
                        counter_c_b++;
                    }
                    if (cb2.Visible)
                    {
                        if (!c21.Visible)
                        {
                            c21.Visible = true;
                            cb2.Visible = false;
                        }
                        else if (!c22.Visible)
                        {
                            c22.Visible = true;
                            cb2.Visible = false;
                        }
                        else if (!c23.Visible)
                        {
                            c23.Visible = true;
                            cb2.Visible = false;
                        }
                        counter_c_a--;
                        counter_c_b++;
                    }
                    counter_b = 0;
                }
                go_down = false;
            }
            // go up
            else
            {
                if (counter_b > 0)
                {
                    for (int i = panel1.Top; i >= lbltop.Bottom; i--)
                    {
                        panel1.Left -= 2;
                        panel1.Top--;
                    }
                    if (pb1.Visible)
                    {
                        if (!p11.Visible)
                        {
                            p11.Visible = true;
                            pb1.Visible = false;
                        }
                        else if (!p12.Visible)
                        {
                            p12.Visible = true;
                            pb1.Visible = false;
                        }
                        else if (!p13.Visible)
                        {
                            p13.Visible = true;
                            pb1.Visible = false;
                        }
                        counter_p_a++;
                        counter_p_b--;
                    }
                    if (pb2.Visible)
                    {
                        if (!p11.Visible)
                        {
                            p11.Visible = true;
                            pb2.Visible = false;
                        }
                        else if (!p12.Visible)
                        {
                            p12.Visible = true;
                            pb2.Visible = false;
                        }
                        else if (!p13.Visible)
                        {
                            p13.Visible = true;
                            pb2.Visible = false;
                        }
                        counter_p_a++;
                        counter_p_b--;
                    }
                    if (cb1.Visible)
                    {
                        if (!c11.Visible)
                        {
                            c11.Visible = true;
                            cb1.Visible = false;
                        }
                        else if (!c12.Visible)
                        {
                            c12.Visible = true;
                            cb1.Visible = false;
                        }
                        else if (!c13.Visible)
                        {
                            c13.Visible = true;
                            cb1.Visible = false;
                        }
                        counter_c_a++;
                        counter_c_b--;
                    }
                    if (cb2.Visible)
                    {
                        if (!c11.Visible)
                        {
                            c11.Visible = true;
                            cb2.Visible = false;
                        }
                        else if (!c12.Visible)
                        {
                            c12.Visible = true;
                            cb2.Visible = false;
                        }
                        else if (!c13.Visible)
                        {
                            c13.Visible = true;
                            cb2.Visible = false;
                        }
                        counter_c_a++;
                        counter_c_b--;
                    }
                    counter_b = 0;
                    go_down = true;
                }
            }
            if ((counter_p_a < counter_c_a && counter_p_a != 0) || (counter_c_b > counter_p_b && counter_p_b != 0))
            {
                MessageBox.Show("loser");
                Application.Restart();
            }
            if (counter_p_b == 3 && counter_c_b == 3)
            {
                MessageBox.Show("Winner");
                Application.Restart();
            }

        }

        private void p21_Click(object sender, EventArgs e)
        {
            if (counter_b < 2)
            {
                counter_b++;
                p21.Visible = false;
                if (pb1.Visible == false && cb1.Visible == false)
                {
                    pb1.Visible = true;
                }
                else if (pb2.Visible == false && cb2.Visible == false)
                {
                    pb2.Visible = true;
                }
            }
        }

        private void p22_Click(object sender, EventArgs e)
        {
            if (counter_b < 2)
            {
                counter_b++;
                p22.Visible = false;
                if (pb1.Visible == false && cb1.Visible == false)
                {
                    pb1.Visible = true;
                }
                else if (pb2.Visible == false && cb2.Visible == false)
                {
                    pb2.Visible = true;
                }
            }
        }

        private void p23_Click(object sender, EventArgs e)
        {
            if (counter_b < 2)
            {
                counter_b++;
                p23.Visible = false;
                if (pb1.Visible == false && cb1.Visible == false)
                {
                    pb1.Visible = true;
                }
                else if (pb2.Visible == false && cb2.Visible == false)
                {
                    pb2.Visible = true;
                }
            }
        }

        private void c21_Click(object sender, EventArgs e)
        {
            if (counter_b < 2)
            {
                counter_b++;
                c21.Visible = false;
                if (cb1.Visible == false && pb1.Visible == false)
                {
                    cb1.Visible = true;
                }
                else if (cb2.Visible == false && pb2.Visible == false)
                {
                    cb2.Visible = true;
                }
            }
        }

        private void c22_Click(object sender, EventArgs e)
        {
            if (counter_b < 2)
            {
                counter_b++;
                c22.Visible = false;
                if (cb1.Visible == false && pb1.Visible == false)
                {
                    cb1.Visible = true;
                }
                else if (cb2.Visible == false && pb2.Visible == false)
                {
                    cb2.Visible = true;
                }
            }
        }

        private void c23_Click(object sender, EventArgs e)
        {
            if (counter_b < 2)
            {
                counter_b++;
                c23.Visible = false;
                if (cb1.Visible == false && pb1.Visible == false)
                {
                    cb1.Visible = true;
                }
                else if (cb2.Visible == false && pb2.Visible == false)
                {
                    cb2.Visible = true;
                }
            }
        }

       
    }
}
