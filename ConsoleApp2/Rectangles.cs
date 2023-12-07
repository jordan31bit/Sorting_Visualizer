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
            this.y = originalArray[0]; // populate y
            this.x = 15;
        }

        /*
         * Create and set the properties of each individual rectangle such as: height/y value, color, border...
         */
        protected RectangleShape SetPropertiesOfRectangle(int i) {
            //prev_x_cord = x;
            this.y_height = copyOfOrigArray[i]; // Convert the Element Obj to an Int and assign to y_height.
            RectangleShape singleRectangle = new RectangleShape(new Vector2f(this.x_thick, this.y_height));
            singleRectangle.FillColor = new Color(Color.Green);
            singleRectangle.OutlineColor = new Color(Color.Red);
            singleRectangle.OutlineThickness = 2;
            //this.cord_x = prev_x_cord + 15;           
            singleRectangle.Rotation = 180;
            singleRectangle.Position = new Vector2f(this.cord_x, 200);
            return singleRectangle;
        }

        public RectangleShape[] CreateArrayObj() {
            for (int i = 0; i < this.arrayLength; i++) {
                cord_x = cord_x + x;
                returnedDrawableObjArray[i] = SetPropertiesOfRectangle(i);
                ///Console.WriteLine(returnedDrawableObjArray[i]);
            } 
            return returnedDrawableObjArray;
        }
    }
}
