namespace ImageViewerSample
{
    partial class FormOpenCVControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid_video_cap = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_stop_cap = new System.Windows.Forms.Button();
            this.button_start_cap = new System.Windows.Forms.Button();
            this.label_cam_status = new System.Windows.Forms.Label();
            this.comboBox_vc_cam_index = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker_capture = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.propertyGrid_video_cap);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label_cam_status);
            this.groupBox1.Controls.Add(this.comboBox_vc_cam_index);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VideoCapture";
            // 
            // propertyGrid_video_cap
            // 
            this.propertyGrid_video_cap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid_video_cap.Location = new System.Drawing.Point(10, 81);
            this.propertyGrid_video_cap.Name = "propertyGrid_video_cap";
            this.propertyGrid_video_cap.Size = new System.Drawing.Size(395, 315);
            this.propertyGrid_video_cap.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_stop_cap, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_start_cap, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 28);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button_stop_cap
            // 
            this.button_stop_cap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_stop_cap.Location = new System.Drawing.Point(200, 3);
            this.button_stop_cap.Name = "button_stop_cap";
            this.button_stop_cap.Size = new System.Drawing.Size(192, 22);
            this.button_stop_cap.TabIndex = 1;
            this.button_stop_cap.Text = "Stop capture";
            this.button_stop_cap.UseVisualStyleBackColor = true;
            this.button_stop_cap.Click += new System.EventHandler(this.button_stop_cap_Click);
            // 
            // button_start_cap
            // 
            this.button_start_cap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start_cap.Location = new System.Drawing.Point(3, 3);
            this.button_start_cap.Name = "button_start_cap";
            this.button_start_cap.Size = new System.Drawing.Size(191, 22);
            this.button_start_cap.TabIndex = 0;
            this.button_start_cap.Text = "Start capture";
            this.button_start_cap.UseVisualStyleBackColor = true;
            this.button_start_cap.Click += new System.EventHandler(this.button_start_cap_Click);
            // 
            // label_cam_status
            // 
            this.label_cam_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cam_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cam_status.Location = new System.Drawing.Point(216, 17);
            this.label_cam_status.Name = "label_cam_status";
            this.label_cam_status.Size = new System.Drawing.Size(188, 23);
            this.label_cam_status.TabIndex = 2;
            this.label_cam_status.Text = " - ";
            this.label_cam_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_vc_cam_index
            // 
            this.comboBox_vc_cam_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vc_cam_index.FormattingEnabled = true;
            this.comboBox_vc_cam_index.Location = new System.Drawing.Point(110, 20);
            this.comboBox_vc_cam_index.Name = "comboBox_vc_cam_index";
            this.comboBox_vc_cam_index.Size = new System.Drawing.Size(89, 20);
            this.comboBox_vc_cam_index.TabIndex = 1;
            this.comboBox_vc_cam_index.SelectedIndexChanged += new System.EventHandler(this.comboBox_vc_cam_index_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera index : ";
            // 
            // backgroundWorker_capture
            // 
            this.backgroundWorker_capture.WorkerReportsProgress = true;
            this.backgroundWorker_capture.WorkerSupportsCancellation = true;
            this.backgroundWorker_capture.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_capture_DoWork);
            this.backgroundWorker_capture.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_capture_ProgressChanged);
            this.backgroundWorker_capture.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_capture_RunWorkerCompleted);
            // 
            // FormOpenCVControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 426);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "FormOpenCVControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOpenCVControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOpenCVControl_FormClosing);
            this.Load += new System.EventHandler(this.FormOpenCVControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_vc_cam_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_cam_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_start_cap;
        private System.Windows.Forms.Button button_stop_cap;
        private System.ComponentModel.BackgroundWorker backgroundWorker_capture;
        private System.Windows.Forms.PropertyGrid propertyGrid_video_cap;
    }
}