# ImageViewerSample
.net Framework 4.6 기반에 Image viewer User contorl입니다. ImageViewport를 생성하여 Panel과 같은 Controls에 Add 한 후 사용하는 방식으로 되어 있습니다. 이 Contorl의 사용 범위는 이미지 file의 Viewer / Camera 이미지 Viewer에 쓰일 수 있습니다. 좀 더 응용할 수 있는 방법이 있다면 https://luciodev.tistory.com/12 블로그에 댓글이나 방명록에 남겨주시면 적극 반영하도록 하겠습니다.

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
