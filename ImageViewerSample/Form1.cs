using ImageViewerControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewerSample
{
    public partial class Form1 : Form
    {

        ImageViewport _imageViewportControl = null;

        public Form1()
        {
            InitializeComponent();

            _imageViewportControl = new ImageViewport();
        }

        private void OnDrawOverlayViewport(object sender, EventArgs e)
        {
            if (checkBox_drawoverlay_line.Checked)
            {
                _imageViewportControl.Drawoverlay_SetColorLine(Color.White);
                _imageViewportControl.DrawoverlayWorld_DrawLine(0, 0, 10, 10);
                _imageViewportControl.Drawoverlay_SetColorLine(Color.YellowGreen);
                _imageViewportControl.DrawoverlayWorld_DrawLine(0, 10, 10, 0);

                _imageViewportControl.Drawoverlay_SetColorLine(Color.YellowGreen);
                _imageViewportControl.DrawoverlayScreen_DrawLine(0, 0, 30, 30);
                _imageViewportControl.Drawoverlay_SetColorLine(Color.White);
                _imageViewportControl.DrawoverlayScreen_DrawLine(0, 30, 30, 0);
            }

            if (checkBox_text.Checked)
            {
                _imageViewportControl.DrawoverlayWorldPosition_DrawText(0, 30, textBox_text.Text, Font, Color.White, Color.Black, (float)1.0);
            }

            if (checkBox_drawoverlay_rectangle.Checked)
            {
                _imageViewportControl.Drawoverlay_SetColorLine(Color.Yellow);
                _imageViewportControl.DrawoverlayWorld_DrawRectangle(0, 0, 30, 30, 0);
            }

            if (checkBox_drawoverlay_ellipse.Checked)
            {
                _imageViewportControl.Drawoverlay_SetColorLine(Color.LightGreen);
                _imageViewportControl.DrawoverlayWorld_DrawEllipse(20, 15, 20, 15, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _imageViewportControl.DrawOverlayViewportEvent += OnDrawOverlayViewport;
            _imageViewportControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(_imageViewportControl);

            propertyGrid1.SelectedObject = _imageViewportControl;
        }

        private void UIChangeStateForImageViwerInvalidate(object sender, EventArgs e)
        {
            _imageViewportControl.Invalidate_ImageViewport();
        }
    }
}
