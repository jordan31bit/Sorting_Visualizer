using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp2 {
    class Rectangles : SFML.Graphics.Drawable {

        protected int y_pos = 200;
        protected int y_length;
        protected int x_thick;
        protected int cord_x;
        protected int prev_x_cord;
        protected int y;
        protected int x;

        void Drawable.Draw(SFML.Graphics.RenderTarget target, SFML.Graphics.RenderStates states) 
        { 
        }

        public Rectangles() {
            this.x_thick = 10; //hardcoded thickness of red border
        }

        public Rectangles(int y, int x) {
            this.x_thick = 10; // hardcoded
            this.y_length = y;
            this.prev_x_cord = x;
        }

        public SFML.Graphics.RectangleShape Foo(int y, int x) {
            this.y_length = y;
            this.prev_x_cord = x;
            RectangleShape square = new RectangleShape(new Vector2f(this.x_thick, this.y_length));
            square.FillColor = new Color(Color.Green);
            square.OutlineColor = new Color(Color.Red);
            square.OutlineThickness = 2;
            this.cord_x = prev_x_cord + 15;
            square.Rotation = 180;
            square.Position = new Vector2f(this.cord_x, 200);
            return square;
        }
      /*  public Rectangles(RenderTarget target, RenderStates states) {
            RectangleShape foo = new RectangleShape();
            target.Draw(foo, states);
        }*/

    }
}
