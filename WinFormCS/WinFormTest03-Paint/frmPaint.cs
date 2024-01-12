using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest03_Paint
{
    public partial class frmPaint : Form
    {
        Graphics g = null;
        Pen pen = null;
        Brush brush = null;
        Bitmap bmCanvas = null;

        int dMode = 0; // 0:Not, 1:pen, 2:line, 3:rect, 4:cir, 5:text
        int dFlag = 0; // 0:open, 1:pressed  : 마우스 버튼
        Point p1, p2, p3;
        Point cp1, cp2, cp3;  // Screen 좌표계 
        public frmPaint()
        {
            InitializeComponent();
            frmPaint_ResizeEnd(null, null);
            pen = new Pen(Color.Red, 2.0f);
            sbLabel4.Text = "";
        }

        private void frmPaint_ResizeEnd(object sender, EventArgs e)
        {
            int draw_X = Canvas.Width, draw_Y = Canvas.Height;
            if(bmCanvas == null)
            {
                bmCanvas = new Bitmap(draw_X, draw_Y);  // No Image
                Canvas.Image = bmCanvas;
            }
            else
            {
                Bitmap tBmp = new Bitmap(draw_X, draw_Y);  // No Image
                Graphics tg = Graphics.FromImage(tBmp);
                tg.DrawImage(bmCanvas, 0, 0);
                bmCanvas.Dispose(); // 기존 이미지 해제
                bmCanvas = tBmp;
                Canvas.Image = bmCanvas;
            }
            g = Graphics.FromImage(bmCanvas);
        }

        private void frmPaint_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                frmPaint_ResizeEnd(sender, e);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dFlag = 1; 
            p1 = e.Location; p2 = e.Location; p3 = e.Location; 
            cp1 = cp2 = cp3 = ((Control)sender).PointToScreen(p1);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.X < 0 || e.Y < 0 || e.X > Canvas.Width || e.Y > Canvas.Height) return;
            if (dFlag != 0) switch(dMode)
            {
                case 1:  // pen draw
                    g.DrawLine(pen, p1, e.Location);
                    Canvas.Invalidate();
                    p1 = e.Location;
                    break;
                case 2:  // Line
                    cp3 = ((Control)sender).PointToScreen(e.Location);
                    ControlPaint.DrawReversibleLine(cp1, cp2, DefaultBackColor);
                    ControlPaint.DrawReversibleLine(cp1, cp3, DefaultBackColor);
                    cp2 = cp3; ;
                    //g.DrawLine(pen, p1, e.Location);
                    break;
                case 3:  // Rect
                case 4:  // Circle
                default: break;
            }
            string str = $"{e.X} x {e.Y}";
            sbLabel1.Text = str;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch(dMode)
            {
                case 2: // Line draw
                    g.DrawLine(pen, p1, e.Location);
                    Canvas.Invalidate();
                    break;
                default: break;
            }
            dFlag = 0;
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            dMode = 1; // 연필 그리기
            sbLabel4.Text = "연필 그리기";
        }

        private void mnuLine_Click(object sender, EventArgs e)
        {
            dMode = 2; // 선 그리기
            sbLabel4.Text = "선 그리기";
        }

        private void mnuRect_Click(object sender, EventArgs e)
        {
            dMode = 3; // 
            sbLabel4.Text = "사각형 그리기";
        }

        private void mnuTestSine_Click(object sender, EventArgs e)
        {
            mnuErase_Click(sender, e);
            List<double> data = new List<double>();
            for (int i = 0; i < 361; i++)            // X,Y axis 
            { // Pi = 3.141592 
                data.Add(Math.Sin(3.141592/180*i));
            }
            int l=0, t=0, r=Canvas.Width, b=Canvas.Height;
            int range = r - l - 40;
            double step = (double)range / 360;
            int amp = -(b - 20) / 2;
            int xOffset = 20;
            int yOffset = b / 2;
            g.DrawLine(pen, new Point(l + 20, b / 2), new Point(r - 20, b / 2)); // X
            g.DrawLine(pen, new Point(l + 20, 10), new Point(l + 20, b - 10)); // Y
            PointF p1, p2;
            p1 = new PointF(xOffset, yOffset);
            for (int i = 0; i < 361; i++)            // X,Y axis 
            {
                p2 = new PointF((float)(i * step + xOffset), (float)data[i] * amp + yOffset);
                g.DrawLine(pen, p1, p2);
                p1 = p2;
            }
            Canvas.Invalidate();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            List<int> data = new List<int>();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs,Encoding.Default);
                string[] str = sr.ReadToEnd().Split('\n');
                for (int i = 1;i < str.Length-1; i++)
                {
                    string[] s = str[i].Split(',');
                    data.Add(int.Parse(s[1]));
                }
                int dataLength = str.Length;
                int l = 0, t = 0, r = Canvas.Width, b = Canvas.Height;
                int range = r - l - 60;
                double step = (double)range / dataLength;
                int amp = -(b - 30) * data.Max();
                int xOffset = 20;
                int yOffset = b - 10;
                g.DrawLine(pen, new Point(l + 20, b + yOffset), new Point(r - 20, b + yOffset)); // X
                g.DrawLine(pen, new Point(l + 20, 10), new Point(l + 20, b - 10)); // Y
                PointF p1, p2;
                p1 = new PointF(xOffset, yOffset);
                for (int i = 0; i < 361; i++)            // X,Y axis 
                {
                    p2 = new PointF((float)(i * step + xOffset), (float)data[i] * amp + yOffset);
                    g.DrawLine(pen, p1, p2);
                    p1 = p2;
                }
                Canvas.Invalidate();
            }
        }

        private void mnuCircle_Click(object sender, EventArgs e)
        {
            dMode = 4; // 
            sbLabel4.Text = "원 그리기";
        }

        private void mnuText_Click(object sender, EventArgs e)
        {
            dMode = 5; // 문자 쓰기
            sbLabel4.Text = "문자";
        }

        private void mnuErase_Click(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            Canvas.Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red);
            Point p1 = new Point(Left, Top);
            Point p2 = new Point(Right, Bottom);
            Point p3 = new Point(Left, Bottom);
            Point p4 = new Point(Right, Top);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);
        }
    }
}
