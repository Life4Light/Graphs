
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{

    using Vertex = System.Int32;
    internal class Graph
    {
        public int[,] num;
        public Graph()
        {
            string[] lines = File.ReadAllLines("Graph_Matrix.txt");
            num = new int[lines.Length,lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp =lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    num[i,j] = Int32.Parse(temp[j]);    
            }
           
            
        }//Конструктор Graph
        public void GetGraph()
        {
             int p = 1;
            
            foreach (var item in num)
            {
                if (p++ % num.GetLength(1) == 0)
                    Console.WriteLine(item);
                else
                    Console.Write(item + " ");
            }
        }//GetGraph
        public int weight(Vertex vi, Vertex vj)
        { 
            if (num[vi,vj] == 0)
            {
                Console.WriteLine("There is no such edge");
            }
            return num[vi, vj]; 
        }

        
    }
}
