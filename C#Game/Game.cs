using System;
using System.Drawing;
using System.Media;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Windows.Forms;

public class Game
{
    Player player = new Player();
    Obstacle box = new Obstacle();
    Boolean visible = true;

    public void Setup()
    {
    }

    public void Update(float dt)
    {
        box.Update(4.0f); // Delta time is 4
        player.Update(0); // Player originally moves to the right at speed 3

        if (box.getX() <= 0 || (box.getX() + box.getW()) >= Window.width) // Object will change direction (left/right) if it reaches the end of the window
        {
            box.Bounce(4.0f); // stops moving once it reaches x = 0?
        }
    }

    public void Draw(Graphics g)
    {
        box.Draw(g);
        player.Draw(g);

        if(visible == true)
        {
            DrawCreditBox(g, "Jenny Le", 2026, "Dodge Box");
        }

        if(Collide(player, box) == true)
        {
            player.setStatus(false); // Player is not alive, will break while loop in Draw()
        }
    }

    public void KeyDown(KeyEventArgs key)
    {
        if (key.KeyCode == Keys.D || key.KeyCode == Keys.Right)
        {
            player.GoRight(3);
        }
        else if (key.KeyCode == Keys.S || key.KeyCode == Keys.Down)
        {
            player.GoDown(3);
        }
        else if (key.KeyCode == Keys.A || key.KeyCode == Keys.Left)
        {
            player.GoLeft(3);
        }
        else if (key.KeyCode == Keys.W || key.KeyCode == Keys.Up)
        {
            player.GoUp(3);
        }
        else if (key.KeyCode == Keys.Add)
        {
            visible = !visible;
        }
    }

    public void MouseClick(MouseEventArgs mouse)
    {
        if (mouse.Button == MouseButtons.Left)
        {
            System.Console.WriteLine(mouse.Location.X + ", " + mouse.Location.Y);
        }
    }

    public void DrawCreditBox(Graphics g, string name, int year, string title)
    {
        Color black = Color.FromArgb(100, 0, 0, 0);
        Pen p = new Pen(black);
        g.DrawRectangle(p, 0, (float)(Window.height * 0.75), (float)(Window.width * 0.25), (float)(Window.height * 0.75));
       
        Font font = new Font("Arial", 12);
        SolidBrush fontBrush = new SolidBrush(Color.Black);

        g.DrawString(name, font, fontBrush, (float)0, (float)(Window.height * 0.75) + 10);
        g.DrawString(year.ToString(), font, fontBrush, (float)0, (float)(Window.height * 0.75) + 30);
        g.DrawString(title, font, fontBrush, (float)0, (float)(Window.height * 0.75) + 50);
    }

    public void drawGameOver(Graphics g)
    {
        Font font = new Font("Arial", 46);
        SolidBrush fontBrush = new SolidBrush(Color.Black);

        StringFormat format = new StringFormat();
        format.LineAlignment = StringAlignment.Center;
        format.Alignment = StringAlignment.Center;

        g.DrawString("GAME OVER!", font, fontBrush, (float)(Window.width * 0.5), (float)(Window.height * 0.5), format);
    }

    // Recognizes if Player hits an obstacle
    public bool Collide(Player p, Obstacle b)
    {
        if(p.getX() >= b.getX() || p.getX() <= (b.getX() + b.getW()) 
            && p.getY() >= b.getY() || p.getY() <= (b.getY() - b.getH()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
