﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace DataStructure
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Wellcome to DataStructure Problem");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine(" ");
            Console.WriteLine("---------------------");

            //list.InsertAtParticularPosition(2, 30);
            //list.Display();
            //Console.WriteLine(" ");
            //Console.WriteLine("30 Added between 56 and 70");



            //list.RemoveFirstNode();
            //list.Display();
            //Console.WriteLine(" ");
            //Console.WriteLine(" First element deleted ");
            //Console.WriteLine("---------------------");


            //list.RemoveLastNode();
            //list.Display();
            //Console.WriteLine(" ");
            //Console.WriteLine(" Last element deleted ");
            //Console.WriteLine("---------------------");

           
            list.Search(30);
           list.Display();
           
            
        }
    }
}