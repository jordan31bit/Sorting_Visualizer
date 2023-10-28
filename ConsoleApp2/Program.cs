using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ConsoleApp2 {
    internal class Program {

        static void Main(String[] args) {

            /*
             *  Unsorted data that is temporary. We will read from a file later.
             */
            int[] arr = { 120, 40, 30, 60, 0, 70, 10, 20, 50 };

            /*
             * Setting up Render Window to draw to.
             * This also may contain properties for said window.
             */
            uint frameRate = 30;
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "bob");
            Color bgColor = new Color(Color.White);
            window.SetFramerateLimit(frameRate); // Set framerate of Rendered Window (requires unsigned int).

            // A copy of the original array because we don't want to change the orig.
            int[] unsortedIntArray = arr;

            int x_pos = 10;
            bool isSorted = false;
            int nextElement = 0;

            /*
             * Create a drawable Rectangles obj and supply it with the Unsorted Interger Array.
             */
            CreateRectangles unsortedObjArray = new CreateRectangles(unsortedIntArray);
            RectangleShape[] foo;
            // draw the unsorted array to screen
            while (window.IsOpen) {
                for(int i = 0; i < unsortedIntArray.Length; i++) {
                    foo = unsortedObjArray.CreateArrayObj();
                    window.Draw(foo[i]);
                    window.Display();
                }
            }
        }
    }
}

            /*while (window.IsOpen) {
                x_pos = 10;
                int xpos = 110;
                int ypos = 300;
                //display the orig array
                for (int i = 0; i < origObjArray.Length; i++) {
                    origObjArray[i].Position = new Vector2f(xpos, ypos);
                    //xpos = xpos + 15;
                    window.Draw(origObjArray[i]);                 
                }

                *//*
                * Bubble Sort
                * Sort the array using bubble sort method and display the output real-time.
                *//*
                if (!isSorted) {
                    for (int i = 0; i <= rev_array.Length - 1; i++) {
                        for (int j = 0; j < rev_array.Length - i - 1; j++) {
                            if (rev_array[j] > rev_array[j + 1]) {
                                nextElement = rev_array[j + 1];
                                rev_array[j + 1] = rev_array[j];
                                rev_array[j] = nextElement;
                            }
                            window.Clear();
                            window.Draw(rectShape.Foo(rev_array[j], x_pos));
                            window.Display();
                            x_pos = x_pos + 15;
                        }
                    }
                    isSorted = true;
                    // for debug only
                    for (int k = 0; k < rev_array.Length; k++) {
                        Console.WriteLine(rev_array[k]);
                    }
                }

                // Display the window contents until the window is closed
                //window.Display();
                //window.Clear();
            }


*/
            /*// Sort the array
            for(int k = 0; k < shapeArray.Length; k++) {
                Array.Sort(rev_array);
                Console.WriteLine(rev_array[k]);
            }*/

            // part of the original unsorted stuff
            // creat array for type rectangles
            // original unsorted array of rectangle objects
            /* RectangleShape[] shapeArray = new RectangleShape[9];

             // fill array with rectangle objects
             int x_pos = 10;
             for (int i = 0; i < arr.Length; i++) {
                 Rectangles bob = new Rectangles(arr[i], x_pos);
                 x_pos = x_pos + 15;
                 shapeArray[i] = bob.Foo();
             }


             RectangleShape[] rev_shapeArray = new RectangleShape[9];

             for (int i = 0; i < rev_array.Length; i++) {
                 Rectangles bob = new Rectangles(rev_array[i], x_pos);
                 x_pos = x_pos + 15;
                 rev_shapeArray[i] = bob.Foo();

             }

             // game loop or app loop to keep window and main thread running
             while (window.IsOpen) {
                 for(int j = 0; j < shapeArray.Length; j++) {
                     window.Draw(shapeArray[j]);
                 }

                 for(int l = 0; l < rev_shapeArray.Length; l++) {
                     window.Draw(rev_shapeArray[l]);
                 }
                 window.Display();
                 window.Clear();
             }*/
