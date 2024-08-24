using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    public class MakeGraph {
        protected int y;
       
        public RectangleShape buildGraph(int y) {
            RectangleShape rectangle = new RectangleShape(new Vector2f(10, y));
            rectangle.FillColor = Color.White;
            rectangle.Position = new Vector2f(200, 200);
            return rectangle;
        }
    }
}
