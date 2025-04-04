namespace ImageViewerSample
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_drawoverlay_line = new System.Windows.Forms.CheckBox();
            this.checkBox_text = new System.Windows.Forms.CheckBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.checkBox_drawoverlay_rectangle = new System.Windows.Forms.CheckBox();
            this.checkBox_drawoverlay_ellipse = new System.Windows.Forms.CheckBox();
            this.checkBox_mouse_draw_rect = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(986, 526);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(326, 524);
            this.propertyGrid1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Example Drawoverlay : ";
            // 
            // checkBox_drawoverlay_line
            // 
            this.checkBox_drawoverlay_line.AutoSize = true;
            this.checkBox_drawoverlay_line.Location = new System.Drawing.Point(159, 8);
            this.checkBox_drawoverlay_line.Name = "checkBox_drawoverlay_line";
            this.checkBox_drawoverlay_line.Size = new System.Drawing.Size(48, 16);
            this.checkBox_drawoverlay_line.TabIndex = 2;
            this.checkBox_drawoverlay_line.Text = "Line";
            this.checkBox_drawoverlay_line.UseVisualStyleBackColor = true;
            this.checkBox_drawoverlay_line.CheckedChanged += new System.EventHandler(this.UIChangeStateForImageViwerInvalidate);
            // 
            // checkBox_text
            // 
            this.checkBox_text.AutoSize = true;
            this.checkBox_text.Location = new System.Drawing.Point(213, 9);
            this.checkBox_text.Name = "checkBox_text";
            this.checkBox_text.Size = new System.Drawing.Size(49, 16);
            this.checkBox_text.TabIndex = 3;
            this.checkBox_text.Text = "Text";
            this.checkBox_text.UseVisualStyleBackColor = true;
            this.checkBox_text.CheckedChanged += new System.EventHandler(this.UIChangeStateForImageViwerInvalidate);
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(268, 9);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(100, 21);
            this.textBox_text.TabIndex = 4;
            this.textBox_text.Text = "Text";
            this.textBox_text.TextChanged += new System.EventHandler(this.UIChangeStateForImageViwerInvalidate);
            // 
            // checkBox_drawoverlay_rectangle
            // 
            this.checkBox_drawoverlay_rectangle.AutoSize = true;
            this.checkBox_drawoverlay_rectangle.Location = new System.Drawing.Point(374, 9);
            this.checkBox_drawoverlay_rectangle.Name = "checkBox_drawoverlay_rectangle";
            this.checkBox_drawoverlay_rectangle.Size = new System.Drawing.Size(80, 16);
            this.checkBox_drawoverlay_rectangle.TabIndex = 5;
            this.checkBox_drawoverlay_rectangle.Text = "Rectangle";
            this.checkBox_drawoverlay_rectangle.UseVisualStyleBackColor = true;
            this.checkBox_drawoverlay_rectangle.CheckedChanged += new System.EventHandler(this.UIChangeStateForImageViwerInvalidate);
            // 
            // checkBox_drawoverlay_ellipse
            // 
            this.checkBox_drawoverlay_ellipse.AutoSize = true;
            this.checkBox_drawoverlay_ellipse.Location = new System.Drawing.Point(460, 8);
            this.checkBox_drawoverlay_ellipse.Name = "checkBox_drawoverlay_ellipse";
            this.checkBox_drawoverlay_ellipse.Size = new System.Drawing.Size(62, 16);
            this.checkBox_drawoverlay_ellipse.TabIndex = 6;
            this.checkBox_drawoverlay_ellipse.Text = "Ellipse";
            this.checkBox_drawoverlay_ellipse.UseVisualStyleBackColor = true;
            this.checkBox_drawoverlay_ellipse.CheckedChanged += new System.EventHandler(this.UIChangeStateForImageViwerInvalidate);
            // 
            // checkBox_mouse_draw_rect
            // 
            this.checkBox_mouse_draw_rect.AutoSize = true;
            this.checkBox_mouse_draw_rect.Location = new System.Drawing.Point(528, 8);
            this.checkBox_mouse_draw_rect.Name = "checkBox_mouse_draw_rect";
            this.checkBox_mouse_draw_rect.Size = new System.Drawing.Size(148, 16);
            this.checkBox_mouse_draw_rect.TabIndex = 7;
            this.checkBox_mouse_draw_rect.Text = "Mouse drag rectangle";
            this.checkBox_mouse_draw_rect.UseVisualStyleBackColor = true;
            this.checkBox_mouse_draw_rect.CheckedChanged += new System.EventHandler(this.checkBox_mouse_draw_rect_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 567);
            this.Controls.Add(this.checkBox_mouse_draw_rect);
            this.Controls.Add(this.checkBox_drawoverlay_ellipse);
            this.Controls.Add(this.checkBox_drawoverlay_rectangle);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.checkBox_text);
            this.Controls.Add(this.checkBox_drawoverlay_line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_drawoverlay_line;
        private System.Windows.Forms.CheckBox checkBox_text;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.CheckBox checkBox_drawoverlay_rectangle;
        private System.Windows.Forms.CheckBox checkBox_drawoverlay_ellipse;
        private System.Windows.Forms.CheckBox checkBox_mouse_draw_rect;
    }
}

