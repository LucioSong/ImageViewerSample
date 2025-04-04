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
        struct PointD
        {
            public double X;
            public double Y;
            public PointD(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        enum MouseState
        {
            None,
            Down,
            Up,
            Move
        }

        ImageViewport _imageViewportControl = null;

        MouseState _mouseState = MouseState.None;
        PointD _ptdMouseDown = new PointD(0, 0);
        PointD _ptdMouseUp = new PointD(0, 0);
        PointD _ptdMouseMove = new PointD(0, 0);
        bool _bIsDrag = false;

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

            if (checkBox_mouse_draw_rect.Checked)
            {
                if (_bIsDrag)
                {
                    _imageViewportControl.Drawoverlay_SetColorLine(Color.White);
                    double lowX = Math.Min(_ptdMouseDown.X, _ptdMouseMove.X);
                    double lowY = Math.Min(_ptdMouseDown.Y, _ptdMouseMove.Y);
                    double width = Math.Abs(_ptdMouseDown.X - _ptdMouseMove.X);
                    double height = Math.Abs(_ptdMouseDown.Y - _ptdMouseMove.Y);
                    _imageViewportControl.DrawoverlayWorld_DrawRectangle(lowX, lowY, width, height, 0);
                }
                else
                {
                    _imageViewportControl.Drawoverlay_SetColorLine(Color.White);
                    double lowX = Math.Min(_ptdMouseDown.X, _ptdMouseUp.X);
                    double lowY = Math.Min(_ptdMouseDown.Y, _ptdMouseUp.Y);
                    double width = Math.Abs(_ptdMouseDown.X - _ptdMouseUp.X);
                    double height = Math.Abs(_ptdMouseDown.Y - _ptdMouseUp.Y);
                    _imageViewportControl.DrawoverlayWorld_DrawRectangle(lowX, lowY, width, height, 0);
                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _imageViewportControl.DrawOverlayViewportEvent += OnDrawOverlayViewport;
            _imageViewportControl.ViewportMouseDown += _imageViewportControl_ViewportMouseDown;
            _imageViewportControl.ViewportMouseUp += _imageViewportControl_ViewportMouseUp;
            _imageViewportControl.ViewportMouseMove += _imageViewportControl_ViewportMouseMove;
            _imageViewportControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(_imageViewportControl);

            propertyGrid1.SelectedObject = _imageViewportControl;
        }

        private void _imageViewportControl_ViewportMouseMove(object sender, MouseEventArgs e)
        {
            _ptdMouseMove = new PointD(_imageViewportControl.WorldPointMouse_X, _imageViewportControl.WorldPointMouse_Y);
            if (checkBox_mouse_draw_rect.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (_bIsDrag)
                    {
                        _mouseState = MouseState.Move;
                    }
                    else
                    {
                        _mouseState = MouseState.None;
                    } 
                } 
            }
            else
            {
                _mouseState = MouseState.None;
            }
        }

        private void _imageViewportControl_ViewportMouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox_mouse_draw_rect.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    _mouseState = MouseState.Up;
                    _bIsDrag = false;
                    _ptdMouseUp = new PointD(_imageViewportControl.WorldPointMouse_X, _imageViewportControl.WorldPointMouse_Y);
                }
            }
            else
            {
                _mouseState = MouseState.None;
            }
        }

        private void _imageViewportControl_ViewportMouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox_mouse_draw_rect.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    _mouseState = MouseState.Down;
                    _bIsDrag = true;
                    _ptdMouseDown = new PointD(_imageViewportControl.WorldPointMouse_X, _imageViewportControl.WorldPointMouse_Y); 
                }
            }
            else
            {
                _mouseState = MouseState.None;
            }
        }

        private void UIChangeStateForImageViwerInvalidate(object sender, EventArgs e)
        {
            _imageViewportControl.Invalidate_ImageViewport();
        }

        private void checkBox_mouse_draw_rect_CheckedChanged(object sender, EventArgs e)
        {
            _imageViewportControl.Invalidate_ImageViewport();
        }
    }
}
