﻿using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    public class Sorts {
        public int[] bubbleSort(int[] arr) {
            int t; // Temporary variable for swapping
            for (int p = 0; p < arr.Length - 1; p++) // Outer loop for passes
            {
                for (int i = 0; i < arr.Length - 1; i++) // Inner loop for comparison and swapping
                {
                    if (arr[i] > arr[i + 1]) // Checking if the current element is greater than the next element
                    {
                        t = arr[i + 1]; // Swapping elements if they are in the wrong order
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                      
                        // return just the whole array
                        return arr;
                    }
                  
                }
            }
            return arr;
        }
    }
}
