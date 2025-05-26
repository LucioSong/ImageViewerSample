using OpenCvSharp;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ImageViewerSample
{
    public partial class FormOpenCVControl : Form
    {
        public delegate void CapturedFrameEventHandler(object sender, Bitmap frame);
        
        public event CapturedFrameEventHandler CapturedFrame;


        VideoCapture _vdCapture = null;

        public bool IsStartedCapture
        {
            get
            {
                if (_vdCapture != null && _vdCapture.IsOpened())
                {
                    return backgroundWorker_capture.IsBusy;
                }
                return false;
            }
        }

        public FormOpenCVControl()
        {
            InitializeComponent();
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();

            if (_vdCapture != null)
            {
                if (_vdCapture.IsOpened())
                {
                    _vdCapture.Release();
                }
                _vdCapture.Dispose();
                _vdCapture = null;
            }
        }


        private void FormOpenCVControl_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                using (var capture = new VideoCapture(i))
                {
                    if (capture.IsOpened())
                    {
                        comboBox_vc_cam_index.Items.Add(i);
                        capture.Release();
                    }
                }
            }

            if (comboBox_vc_cam_index.Items.Count > 0)
            {
                comboBox_vc_cam_index.SelectedIndex = 0;
            }
        }

        private void comboBox_vc_cam_index_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_vdCapture != null)
            {
                if (_vdCapture.IsOpened())
                {
                    _vdCapture.Release();
                }                
                _vdCapture.Dispose();
                _vdCapture = null;
            }

            _vdCapture = new VideoCapture(comboBox_vc_cam_index.SelectedIndex);
            _vdCapture.Open(comboBox_vc_cam_index.SelectedIndex);

            if (_vdCapture.IsOpened())
            {
                label_cam_status.Text = "(" + comboBox_vc_cam_index.SelectedIndex.ToString() + ")" + " Camera Opened.";

                propertyGrid_video_cap.SelectedObject = _vdCapture;
            }
            else
            {
                label_cam_status.Text = "(" + comboBox_vc_cam_index.SelectedIndex.ToString() + ")" + " Camera Open Failed.";
            }
        }

        private void FormOpenCVControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void backgroundWorker_capture_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (_vdCapture != null && _vdCapture.IsOpened())
            {
                using (var frame = new Mat())
                {
                    while (!backgroundWorker_capture.CancellationPending)
                    {
                        Thread.Sleep(10);
                        if (_vdCapture.Read(frame))
                        {
                            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                            CapturedFrame?.Invoke(this, bitmap);
                            backgroundWorker_capture.ReportProgress(-1, "Frame capturing...");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void button_start_cap_Click(object sender, EventArgs e)
        {
            if (_vdCapture != null && _vdCapture.IsOpened())
            {
                if (!backgroundWorker_capture.IsBusy)
                {
                    backgroundWorker_capture.RunWorkerAsync();
                }
            }
        }

        private void button_stop_cap_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_capture.IsBusy)
            {
                backgroundWorker_capture.CancelAsync(); 
            }
        }

        private void backgroundWorker_capture_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            label_cam_status.Text = e.UserState.ToString();
        }

        private void backgroundWorker_capture_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            label_cam_status.Text = "Capture stopped.";
        }
    }
}
