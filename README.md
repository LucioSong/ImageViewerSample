# ImageViewerSample
.net Framework 4.6 기반에 Image viewer User control입니다. ImageViewport를 생성하여 Panel과 같은 Controls에 Add 한 후 사용하는 방식으로 되어 있습니다. 이 Contorl의 사용 범위는 이미지 file의 Viewer / Camera 이미지 Viewer에 쓰일 수 있습니다. 좀 더 응용할 수 있는 방법이 있다면 https://luciodev.tistory.com/12 블로그에 댓글이나 방명록에 남겨주시면 적극 반영하도록 하겠습니다. 

![image](https://github.com/user-attachments/assets/bfa80cc0-51d7-42fa-998e-1019cf724b9f)

- Update 내용
  OpenCV Video capture 추가 적용
  
  ![image](https://github.com/user-attachments/assets/36abca68-b5d9-413b-a7e2-13f36175e0f8)


- Summary 코드
```CSharp
ImageViewport _imageViewportControl = null;

public Form1()
{
    InitializeComponent();

    _imageViewportControl = new ImageViewport();
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


    _formOpenCVControl = new FormOpenCVControl();
    _formOpenCVControl.CapturedFrame += _formOpenCVControl_CapturedFrame;
}

private void _formOpenCVControl_CapturedFrame(object sender, Bitmap frame)
{
    _imageViewportControl.UpdateImage(frame);
    _imageViewportControl.Invalidate_ImageViewport();
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
