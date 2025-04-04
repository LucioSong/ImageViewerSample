# ImageViewerSample
.net Framework 4.6 기반에 Image viewer User control입니다. ImageViewport를 생성하여 Panel과 같은 Controls에 Add 한 후 사용하는 방식으로 되어 있습니다. 이 Contorl의 사용 범위는 이미지 file의 Viewer / Camera 이미지 Viewer에 쓰일 수 있습니다. 좀 더 응용할 수 있는 방법이 있다면 https://luciodev.tistory.com/12 블로그에 댓글이나 방명록에 남겨주시면 적극 반영하도록 하겠습니다. 

![image](https://github.com/LucioSong/ImageViewerSample/assets/122073722/6be5d88b-b062-4144-8866-a5eeebd881b3)
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
    _imageViewportControl.Dock = DockStyle.Fill;
    splitContainer1.Panel2.Controls.Add(_imageViewportControl);

    propertyGrid1.SelectedObject = _imageViewportControl;
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
