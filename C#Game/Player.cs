using System;
using System.Drawing;
using System.Windows.Forms;

public class Player
{
    private int x; // x-location of Player
    private int y; // y-location of Player
    private int w; // width of Player
    private int h; // height of Player
    private bool alive = true;

    public Player() // Initialize all Player objects to have a spawn point (0,0) and a size (25,25)
    {
        x = 0;
        y = 0;
        w = 25;
        h = 25;
    }

    public void Draw(Graphics g)
    {
        Color c = Color.FromArgb(100, 0, 250, 0);
        Brush sb = new SolidBrush(c);
        g.FillEllipse(sb, x, y, w, h);
    }

    public void Update(float dt)
    {
        while (alive)
        {
            x += (int)dt; // Player object moves in the positive x-direction
        }
    }

    // Movement methods

    public void GoRight(float dt) // Corresponds with D key
    {
        x += (int)dt;
    }

    public void GoDown(float dt) // Corresponds with S key
    {
        y += (int)dt;
    }

    public void GoLeft(float dt) // Corresponds with A key
    {
        x -= (int)dt;
    }

    public void GoUp(float dt) // Corresponds with W key
    {
        y -= (int)dt;
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

    public bool getStatus()
    {
        return alive;
    }

    public void setStatus(bool value)
    {
        this.alive = value; 
    }
}