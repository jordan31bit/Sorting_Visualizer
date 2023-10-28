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
    class CreateRectangles : SFML.Graphics.Drawable {

        protected int y_pos = 200;
        protected int y_height;
        protected int x_thick;
        protected int cord_x;
        protected int prev_x_cord;
        protected int y;
        protected int x;
        protected RectangleShape[] returnedDrawableObjArray = new RectangleShape[20];
        protected int arrayLength;
        protected RectangleShape[] suppliedArray;
        protected int[] copyOfOrigArray;

        void Drawable.Draw(SFML.Graphics.RenderTarget target, SFML.Graphics.RenderStates states) 
        { 
        }

        // We need the length of the array from the caller.
        public CreateRectangles(int[] originalArray) {
            this.x_thick = 10; // hardcoded thickness of red border of each retangle
            this.arrayLength = originalArray.Length;
            this.copyOfOrigArray = originalArray;
        }

        /*
         * Create and set the properties of each individual rectangle such as: height/y value, color, border...
         */
        protected RectangleShape SetPropertiesOfRectangle(int i) {
            this.prev_x_cord = x;
            y_height = copyOfOrigArray[i]; // Convert the Element Obj to an Int and assign to y_height.
            RectangleShape singleRectangle = new RectangleShape(new Vector2f(this.x_thick, this.y_height));
            singleRectangle.FillColor = new Color(Color.Green);
            singleRectangle.OutlineColor = new Color(Color.Red);
            singleRectangle.OutlineThickness = 2;
            this.cord_x = prev_x_cord + 15;
            singleRectangle.Rotation = 180;
            //singleRectangle.Position = new Vector2f(this.cord_x, 200);
            return singleRectangle;
        }

        public RectangleShape[] CreateArrayObj() {
            this.y_height = y; // We set the y value (height) that we recieve from caller.
            for (int i = 0; i < this.arrayLength; i++) {
                returnedDrawableObjArray[i] = SetPropertiesOfRectangle(i);
                Console.WriteLine(returnedDrawableObjArray[i]);
            } 
            return returnedDrawableObjArray;
        }
    }
}
