using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public class RoundedGroupBox : GroupBox
    {
        public int BorderRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 50;
            Rectangle rect = new Rectangle(0, 10, this.Width - 1, this.Height - 11);

            using (GraphicsPath path = GetRoundedRect(rect, radius))
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.Clear(this.BackColor);

                // Desenha borda
                e.Graphics.DrawPath(pen, path);

                // Desenha texto
                SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
                RectangleF textRect = new RectangleF(10, 0, textSize.Width, textSize.Height);

                using (Brush brush = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
                    e.Graphics.DrawString(this.Text, this.Font, brush, 10, 0);
                }
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
