using System;
using System.Configuration;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

public class Obstacle
{
    private int x; // x-location of object
    private int y; // y-location of object
    private int w; // width of object
    private int h; // height of object

    public Obstacle()
    {
        x = (Window.width / 2);
        y = (Window.height / 2);
        w = 30;
        h = 30;
    }

    public void Update(float dt) // Moves box left/right
    {
        x = x - (int)dt; // Moves left

    }

    public void Draw(Graphics g) // Spawns an obstacle
    {
        Color c = Color.FromArgb(100, 250, 0, 0);
        Brush sb = new SolidBrush(c);
        g.FillRectangle(sb, x, y, w, h);
    }

    // Getters and Setters
    public int getX()
    {
        return x;
    }

    public void setX(int value)
    {
        this.x = value;
    }

    public int getY()
    {
        return y;
    }

    public void setY(int value)
    {
        this.y = value;
    }

    public int getW()
    {
        return w;
    }

    public void setW(int value)
    {
        this.w = value;
    }

    public int getH()
    {
        return h;
    }

    public void setH(int value)
    {
        this.h = value;
    }

    public void Bounce(float dt)
    {
        dt = -dt;
        setW(w + 5);
        setH(h + 5);
    }
}
