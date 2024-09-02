using System;
using SFML.Graphics;
using SFML.Window;

namespace ConsoleApp2 {
    internal class Program {

        static void Main(String[] args) {

            /*
             *  Unsorted data that is generated via RNG. Console will beep when RNG is done.
             */
            Random rng = new Random();
            int[] arr = new int[100];
            for(int i = 0; i < arr.Length; i++) {
                arr[i] = rng.Next(1, 100);
            }
            Console.Beep();

            /*
             * Setting up Render Window to draw to.
             * This also may contain properties for said window.
             */
            uint frameRate = 30;
            RenderWindow window = new RenderWindow(new VideoMode(2560,1600), "SORTING-VISUALIZER", Styles.Fullscreen);
            Color bgColor = new Color(Color.White);
            window.SetFramerateLimit(frameRate); // Set framerate of Rendered Window (requires unsigned int).

            MakeGraph boon = new MakeGraph();
            Sorts sorting = new Sorts();
            int windowWidth = (int)window.Size.X;
            int windowHeight = (int)window.Size.Y;
            RectangleShape[] boob = new RectangleShape[arr.Length];

            while(window.IsOpen) { 
                window.Clear();
                arr = sorting.SelectionSort(arr);
                //arr = sorting.bubbleSort(arr);
                boob = boon.buildGraph(arr, windowWidth, windowHeight);
         
                for(int i = 0; i < arr.Length; i++) {
                    window.Draw(boob[i]);                    
                }
                window.Display();
            }
        }
    }
}