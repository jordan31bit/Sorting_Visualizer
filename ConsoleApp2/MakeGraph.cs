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
       
        public RectangleShape[] buildGraph(int[] arr, int windowWidth, int windowHeight) {
            RectangleShape[] arrOfObjects = new RectangleShape[arr.Length];
            int n = 1;
            Console.WriteLine(windowWidth);
            for(int i = 0; i < arr.Length; i++) {
                RectangleShape rectangle = new RectangleShape(new Vector2f(10, arr[i]));
                rectangle.FillColor = Color.White;
                rectangle.Position = new Vector2f(windowWidth / arr.Length * n++, 700);
                rectangle.Rotation = 180;
                arrOfObjects[i] = rectangle;
                Console.WriteLine(rectangle.Position);
            }
             return arrOfObjects;
        }
    }
}
