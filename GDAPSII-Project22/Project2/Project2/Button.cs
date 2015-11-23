using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project2
{
    class Button
    {
        //attributes
        Texture2D texture;
        Rectangle rect;
        Vector2 position;
        Vector2 size;
        Rectangle mouseR;
        bool click;

        //properties
        public Rectangle Rect { get { return rect; } set { rect = value; } }
        public Texture2D Texture { get { return texture; } set { texture = value; } }
        public Vector2 Position { get { return position; } set { position = value; } }
        public Vector2 Size { get { return size; } set { size = value; } }
        public bool Click { get { return click; } set { click = value; } }



        //constructer
        public Button(int x, int y, int w, int h, Texture2D tx)
        {
            click = false;
            texture = tx;
            size = new Vector2(w, h);
            position = new Vector2(x, y);
            rect = new Rectangle(x, y, w, h);
        }

        //button click
        public bool ClickUpdate(MouseState mouse)
        {
            rect = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            mouseR = new Rectangle(mouse.X, mouse.Y, 1, 1);

            //check if mouse rect is inersecting with button rectangle
            if (mouseR.Intersects(rect))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                { click = true; return true; }
                else { click = false; return false; }
            }
            else { return false; }
        }

        //Draw Method
        public virtual void Draw(SpriteBatch spriteB)
        {
            spriteB.Draw(texture, rect, Color.White);
        }
    }
}
