///
/// Bull Theme
/// Original vb.Net Creator, AeonHack
/// Converted to C# by Faded
/// www.EmuDevs.com
/// 

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class BullTheme : Control
{
    protected override void OnHandleCreated(EventArgs e)
    {
        Dock = DockStyle.Fill;
        if (Parent is Form)
        {
            Form tempWith1 = (Form)Parent;
            tempWith1.FormBorderStyle = 0;
            tempWith1.BackColor = C1;
            tempWith1.ForeColor = Color.FromArgb(170, 170, 170);
        }
        base.OnHandleCreated(e);
    }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
    {
        if (new Rectangle(Parent.Location.X, Parent.Location.Y, Width, 22).IntersectsWith(new Rectangle(MousePosition.X, MousePosition.Y, 1, 1)))
        {
            Capture = false;
            Message M = Message.Create(Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
            DefWndProc(ref M);
        }
        base.OnMouseDown(e);
    }

    private Graphics G;
    private Bitmap B;
    private Rectangle R1;
    private Rectangle R2;
    private Color C1;
    private Color C2;
    private Color C3;
    private Pen P1;
    private Pen P2;
    private Pen P3;
    private Pen P4;
    private SolidBrush B1;
    private LinearGradientBrush B2;
    private LinearGradientBrush B3;

    public BullTheme()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        C1 = Color.FromArgb(248, 248, 248); //Background
        C2 = Color.FromArgb(255, 255, 255); //Highlight
        C3 = Color.FromArgb(235, 235, 235); //Shadow
        P1 = new Pen(Color.FromArgb(215, 215, 215)); //Border
        P4 = new Pen(Color.FromArgb(230, 230, 230)); //Diagnol Lines
        P2 = new Pen(C1);
        P3 = new Pen(C2);
        B1 = new SolidBrush(Color.FromArgb(170, 170, 170));
        Font = new Font("Verdana", 7.0F);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        if (Height > 0)
        {
            R1 = new Rectangle(0, 2, Width, 18);
            R2 = new Rectangle(0, 21, Width, 10);
            B2 = new LinearGradientBrush(R1, C1, C3, 90.0F);
            B3 = new LinearGradientBrush(R2, Color.FromArgb(18, 0, 0, 0), Color.Transparent, 90.0F);
            Invalidate();
        }
        base.OnSizeChanged(e);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    { }

    protected override void OnPaint(PaintEventArgs e)
    {
        B = new Bitmap(Width, Height);
        G = Graphics.FromImage(B);

        G.Clear(C1);

        for (int I = 0; I <= Width + 17; I += 4)
        {
            G.DrawLine(P4, I, 21, I - 17, 37);
            G.DrawLine(P4, I - 1, 21, I - 16, 37);
        }
        G.FillRectangle(B3, R2);

        G.FillRectangle(B2, R1);
        G.DrawString(Text, Font, B1, 5, 5);

        G.DrawRectangle(P2, 1, 1, Width - 3, 19);
        G.DrawRectangle(P3, 1, 39, Width - 3, Height - 41);

        G.DrawRectangle(P1, 0, 0, Width - 1, Height - 1);
        G.DrawLine(P1, 0, 21, Width, 21);
        G.DrawLine(P1, 0, 38, Width, 38);

        e.Graphics.DrawImage(B, 0, 0);
        G.Dispose();
        B.Dispose();
    }
}

internal class BullButton : Control
{
    private Image _Image;
    private bool ImageSet;
    public Image Image
    {
        get
        {
            return _Image;
        }
        set
        {
            _Image = value;
            ImageSet = value != null;
        }
    }

    private Bitmap B;
    private Graphics G;
    private Rectangle R1;
    private Color C1;
    private Color C2;
    private Color C3;
    private Color C4;
    private Pen P1;
    private Pen P2;
    private Pen P3;
    private Pen P4;
    private Brush B1;
    private Brush B2;
    private Brush B5;
    private LinearGradientBrush B3;
    private LinearGradientBrush B4;

    public BullButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        C1 = Color.FromArgb(244, 244, 244); //Background
        C2 = Color.FromArgb(220, 220, 220); //Highlight
        C3 = Color.FromArgb(248, 248, 248); //Lesser Highlight
        C4 = Color.FromArgb(24, Color.Black);
        P1 = new Pen(Color.FromArgb(255, 255, 255)); //Shadow
        P2 = new Pen(Color.FromArgb(40, Color.White));
        P3 = new Pen(Color.FromArgb(20, Color.White));
        P4 = new Pen(Color.FromArgb(10, Color.Black)); //Down-Left
        B1 = new SolidBrush(C1);
        B2 = new SolidBrush(C3);
        B5 = new SolidBrush(Color.FromArgb(170, 170, 170)); //Text Color
        Font = new Font("Verdana", 8.0F);
    }

    private int State;
    protected override void OnMouseLeave(EventArgs e)
    {
        State = 0;
        Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        State = 1;
        Invalidate();
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        State = 1;
        Invalidate();
    }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        State = 2;
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        R1 = new Rectangle(2, 2, Width - 4, 4);
        B3 = new LinearGradientBrush(ClientRectangle, C3, C2, 90.0F);
        B4 = new LinearGradientBrush(R1, C4, Color.Transparent, 90.0F);
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        B = new Bitmap(Width, Height);
        G = Graphics.FromImage(B);
        G.FillRectangle(B3, ClientRectangle);

        switch (State)
        {
            case 0: //Up
                G.FillRectangle(B2, 1, 1, Width - 2, Height - 2);
                G.DrawRectangle(P4, 2, 2, Width - 5, Height - 5);
                break;
            case 1: //Over
                G.FillRectangle(B1, 1, 1, Width - 2, Height - 2);
                G.DrawRectangle(P4, 2, 2, Width - 5, Height - 5);
                break;
            case 2: //Down
                G.FillRectangle(B1, 1, 1, Width - 2, Height - 2);
                G.FillRectangle(B4, R1);
                G.DrawLine(P4, 2, 2, 2, Height - 3);
                break;
        }

        SizeF S = G.MeasureString(Text, Font);
        G.DrawString(Text, Font, B5, Convert.ToInt32(Width / 2 - S.Width / 2.0), Convert.ToInt32(Height / 2 - S.Height / 2.0));
        G.DrawRectangle(P1, 1, 1, Width - 3, Height - 3);

        if (ImageSet)
        {
            G.DrawImage(_Image, 5, System.Convert.ToInt32(Height / 2 - _Image.Height / 2.0), _Image.Width, _Image.Height);
        }

        e.Graphics.DrawImage(B, 0, 0);
        G.Dispose();
        B.Dispose();
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    { }
}

internal class BullProgressBar : Control
{
    #region  Properties
    private double _Maximum = 100;

    public double Maximum
    {
        get
        {
            return _Maximum;
        }
        set
        {
            _Maximum = value;
            Progress = _Current / value * 100;
            Invalidate();
        }
    }

    private double _Current;
    public double Current
    {
        get
        {
            return _Current;
        }
        set
        {
            _Current = value;
            Progress = value / _Maximum * 100;
            Invalidate();
        }
    }

    private int _Progress;
    public double Progress
    {
        get
        {
            return _Progress;
        }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            else if (value > 100)
            {
                value = 100;
            }
            _Progress = Convert.ToInt32(value);
            _Current = value * 0.01 * _Maximum;
            if (Width > 0)
            {
                UpdateProgress();
            }
            Invalidate();
        }
    }

    private Color C2 = Color.PaleTurquoise; //Dark Color
    public Color Color1
    {
        get
        {
            return C2;
        }
        set
        {
            C2 = value;
            UpdateColors();
            Invalidate();
        }
    }

    private Color C3 = Color.AliceBlue; //Light color
    public Color Color2
    {
        get
        {
            return C3;
        }
        set
        {
            C3 = value;
            UpdateColors();
            Invalidate();
        }
    }
    #endregion

    protected override void OnPaintBackground(PaintEventArgs pevent)
    { }

    private Graphics G;
    private Bitmap B;
    private Rectangle R1;
    private Rectangle R2;
    private ColorBlend X;
    private Color C1;
    private Pen P1;
    private Pen P2;
    private Pen P3;
    private LinearGradientBrush B1;
    private LinearGradientBrush B2;
    private SolidBrush B3;

    public BullProgressBar()
    {
        C1 = Color.FromArgb(246, 246, 246); //Background
        P1 = new Pen(Color.FromArgb(70, Color.White), 2F);
        P2 = new Pen(C2);
        P3 = new Pen(Color.FromArgb(255, 255, 255)); //Highlight
        B3 = new SolidBrush(Color.FromArgb(100, Color.White));
        X = new ColorBlend(4);
        X.Colors = new Color[] { C2, C3, C3, C2 };
        X.Positions = new float[] { 0.0F, 0.1F, 0.9F, 1.0F };
        R2 = new Rectangle(2, 2, 2, 2);
        B2 = new LinearGradientBrush(R2, Color.Transparent, Color.Transparent, 180.0F);
        B2.InterpolationColors = X;
    }

    public void UpdateColors()
    {
        P2.Color = C2;
        X.Colors = new Color[] { C2, C3, C3, C2 };
        B2.InterpolationColors = X;
    }

    protected override void OnSizeChanged(System.EventArgs e)
    {
        R1 = new Rectangle(0, 1, Width, 4);
        B1 = new LinearGradientBrush(R1, Color.FromArgb(24, Color.Black), Color.Transparent, 90.0F);
        UpdateProgress();
        Invalidate();
        base.OnSizeChanged(e);
    }

    public void UpdateProgress()
    {
        if (_Progress == 0)
        {
            return;
        }
        R2 = new Rectangle(2, 2, Convert.ToInt32((Width - 4) * (_Progress * 0.01)), Height - 4);
        B2 = new LinearGradientBrush(R2, Color.Transparent, Color.Transparent, 180.0F);
        B2.InterpolationColors = X;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        B = new Bitmap(Width, Height);
        G = Graphics.FromImage(B);
        G.Clear(C1);
        G.FillRectangle(B1, R1);

        if (_Progress > 0)
        {
            G.FillRectangle(B2, R2);

            G.FillRectangle(B3, 2, 3, R2.Width, 4);
            G.DrawRectangle(P1, 4, 4, R2.Width - 4, Height - 8);

            G.DrawRectangle(P2, 2, 2, R2.Width - 1, Height - 5);
        }

        G.DrawRectangle(P3, 0, 0, Width - 1, Height - 1);
        e.Graphics.DrawImage(B, 0, 0);
        G.Dispose();
        B.Dispose();
    }
}

internal class BullSeperator : Control
{
    private Orientation _Orientation;
    public Orientation Orientation
    {
        get
        { return _Orientation; }

        set
        {
            _Orientation = value;
            UpdateOffset();
            Invalidate();
        }
    }

    private Graphics G;
    private Bitmap B;
    private int I;
    private Color C1;
    private Pen P1;
    private Pen P2;

    public BullSeperator()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        C1 = Color.FromArgb(248, 248, 248); //Background
        P1 = new Pen(Color.FromArgb(230, 230, 230)); //Shadow
        P2 = new Pen(Color.FromArgb(255, 255, 255)); //Highlight
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        UpdateOffset();
        base.OnSizeChanged(e);
    }

    public void UpdateOffset()
    {
        I = Convert.ToInt32(((_Orientation == 0) ? Height / 2 - 1 : Width / 2 - 1));
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        B = new Bitmap(Width, Height);
        G = Graphics.FromImage(B);
        G.Clear(C1);

        if (_Orientation == 0)
        {
            G.DrawLine(P1, 0, I, Width, I);
            G.DrawLine(P2, 0, I + 1, Width, I + 1);
        }
        else
        {
            G.DrawLine(P2, I, 0, I, Height);
            G.DrawLine(P1, I + 1, 0, I + 1, Height);
        }

        e.Graphics.DrawImage(B, 0, 0);
        G.Dispose();
        B.Dispose();
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    { }
}