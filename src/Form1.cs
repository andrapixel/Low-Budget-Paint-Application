using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Input;

namespace DrawingForm
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;

        private int initialX = -1;
        private int initialY = -1;
       
        private bool isDown = false;

        private bool lineBtnPressed = false;
        private bool ellipseBtnPressed = false;
        private bool rectBtnPressed = false;
        private bool freehandPressed = false;
        private int pressCount = 0;
        
        public Form1()
        {
            InitializeComponent();

            this.Text = "Paint";
            this.BackColor = Color.LightSkyBlue;

            pen = new Pen(Color.Black, 2f);
            panel1.BackColor = Color.White;

            g = panel1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            groupBox2.Visible = false;
            txtRad.Visible = false;
            lblRad.Visible = false;

            btnFreehand.TabIndex = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*HatchBrush crossLinesBrush = new HatchBrush(HatchStyle.Cross, Color.LightGray, Color.White);
            e.Graphics.FillRectangle(crossLinesBrush, e.ClipRectangle);*/
           //DoubleBuffered = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;

            initialX = e.X;
            initialY = e.Y;
            
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            CursorPos.Text = e.Location.ToString();

            if (isDown == true)
            {
                if (freehandPressed == true)
                {
                    g.DrawLine(pen, new Point(initialX, initialY), e.Location);
                    initialX = e.X;
                    initialY = e.Y;
                }
                else if (lineBtnPressed == true)
                {
                    panel1.Refresh();
                    g.DrawLine(pen, new Point(initialX, initialY), e.Location);
                }
                else if (ellipseBtnPressed == true)
                {
                    panel1.Refresh();

                    Rectangle rectangle = new Rectangle();

                    PaintEventArgs arg = new PaintEventArgs(g, rectangle);
                    DrawEllipse(arg, initialX, initialY, Math.Abs(e.X - initialX), Math.Abs(e.Y - initialY));
                    g.DrawRectangle(pen, initialX, initialY, 1f, 1f);

                    txtWidth.Text = Math.Abs(e.X - initialX).ToString();
                    txtHeight.Text = Math.Abs(e.Y - initialY).ToString();
                    txtRad.Text = "(" + initialX + ", " + initialY + ")";
                }    
                else if (rectBtnPressed == true)
                {
                    panel1.Refresh();

                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Math.Min(e.X, initialX),
                    Math.Min(e.Y, initialY), Math.Abs(e.X - initialX), Math.Abs(e.Y - initialY));

                    PaintEventArgs arg = new PaintEventArgs(g, rect);
                    DrawRect(arg, rect);
                    
                    txtWidth.Text = Math.Abs(e.X - initialX).ToString();
                    txtHeight.Text = Math.Abs(e.Y - initialY).ToString();
                }    
            }
        }

        private void DrawRect(PaintEventArgs e, Rectangle rect)
        {
            e.Graphics.DrawRectangle(pen, rect);
        }

        private void DrawEllipse(PaintEventArgs e, int x, int y, int width, int height)
        {
            e.Graphics.DrawEllipse(pen, x - width / 2, y - height / 2, width, height);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;

            initialX = -1;
            initialY = -1;

            panel1.Cursor = Cursors.Arrow;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colDg = new ColorDialog();

            if (colDg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colDg.Color;
            }

            colDg.Dispose();
        }

        private void btnEraseAll_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
  
        private void btnDrawLine_MouseClick(object sender, MouseEventArgs e)
        {
            pressCount++;
            if (pressCount % 2 == 1)
            {
                lineBtnPressed = true;
                btnDrawLine.BackColor = Color.LightSkyBlue;
            }
            else
            {
                lineBtnPressed = false;
                btnDrawLine.BackColor = Color.LightGray;
            }
        }

        private void btnDrawEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            pressCount++;
            if (pressCount % 2 == 1)
            {
                ellipseBtnPressed = true;
                btnDrawEllipse.BackColor = Color.LightSkyBlue;

                groupBox2.Visible = true;
                txtRad.Visible = true;
                lblRad.Visible = true;
            }
            else
            {
                ellipseBtnPressed = false;
                btnDrawEllipse.BackColor = Color.LightGray;

                groupBox2.Visible = false;
                txtRad.Visible = false;
                lblRad.Visible = false;

                txtWidth.Clear();
                txtHeight.Clear();
            }
        }

        private void btnDrawRect_MouseClick(object sender, MouseEventArgs e)
        {
            pressCount++;
            if (pressCount % 2 == 1)
            {
                rectBtnPressed = true;
                btnDrawRect.BackColor = Color.LightSkyBlue;
                
                groupBox2.Visible = true;
            }
            else
            {
                rectBtnPressed = false;
                btnDrawRect.BackColor = Color.LightGray;
                
                groupBox2.Visible = false;

                txtWidth.Clear();
                txtHeight.Clear();
            }
        }

        private void btnFreehand_MouseClick(object sender, MouseEventArgs e)
        {
            pressCount++;
            if (pressCount % 2 == 1)
            {
                freehandPressed = true;
                btnFreehand.BackColor = Color.LightSkyBlue;
            }
            else
            {
                freehandPressed = false;
                btnFreehand.BackColor = Color.LightGray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkSize_Click(object sender, EventArgs e)
        {
            pen.Width = int.Parse(txtSize.Text);
            txtSize.Clear();
        }
    }
}
