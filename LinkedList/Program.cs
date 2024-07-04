using LinkedList;
using Microsoft.VisualBasic;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
      
        // this is comment





        Console.ReadKey();
    }
}


/*
 LinkedList<YouTube> playlist = new LinkedList<YouTube>();
        playlist.AddFirst(new YouTube("variables", 1234));
        playlist.AddFirst(new YouTube("assemblies", 2234));
        playlist.AddFirst(new YouTube("inheritance", 9934));
        playlist.AddFirst(new YouTube("polymorphism", 1234));
        playlist.AddFirst(new YouTube("encapsulation", 1234));
        playlist.AddFirst(new YouTube("classes", 1234));

        Console.ForegroundColor = ConsoleColor.Green;
        foreach (YouTube video in playlist)
        {
            Console.WriteLine(video);
        }
 
 */

/*
 
  private string Title;
        private int id;

        public YouTube() { 
          this.Title= string.Empty;
            this.id = 0;
        }

        public YouTube(string title, int id)
        {
            Title = title;
            this.id = id;
        }

        public override string ToString()
        {
            return "\t\t\n Title: "+this.Title+ "\n\t\t url: https://www.youtube.com/watch?v=: "+this.id+"\n";
        }

 



/* YouTube lesson1= new YouTube("classes", 123);
        YouTube lesson2= new YouTube("constructors", 124);
        YouTube lesson3= new YouTube("methods", 125);
        YouTube lesson4= new YouTube("encapsulation", 126);
        YouTube lesson5= new YouTube("inheritance", 127);
        YouTube lesson6= new YouTube("polymorphism", 128);
        YouTube lesson7= new YouTube("assempliis", 129);

        /*
          -- classes
          -- constructors
          -- methods
          -- encapsulation
          -- inheritance
          -- polymorphism
          -- assempliis
         
         

LinkedList<YouTube> playlist = new LinkedList<YouTube>();

//playlist.AddFirst(lesson1);
//playlist.AddAfter(playlist.First,lesson2);
//playlist.AddAfter(playlist.First.Next, lesson3);

//playlist.AddAfter(playlist.First.Next.Next, lesson4);

//playlist.AddAfter(playlist.First.Next.Next.Next,lesson5);

//playlist.AddAfter(playlist.First.Next.Next.Next.Next, lesson6);

//playlist.AddLast(lesson7);





//LinkedListNode<YouTube> node1 = new LinkedListNode<YouTube>(lesson1);

LinkedListNode<YouTube> node2 = new LinkedListNode<YouTube>(lesson2);

LinkedListNode<YouTube> node3 = new LinkedListNode<YouTube>(lesson3);

LinkedListNode<YouTube> node4 = new LinkedListNode<YouTube>(lesson4);

LinkedListNode<YouTube> node5 = new LinkedListNode<YouTube>(lesson5);

LinkedListNode<YouTube> node6 = new LinkedListNode<YouTube>(lesson6);

//public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode);
playlist.AddFirst(lesson1);
playlist.AddAfter(playlist.First.Next, node2);
playlist.AddAfter(node2.Next, node3);
playlist.AddAfter(node3, node4);
playlist.AddAfter(node5, node6);



Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Green;


foreach (var video in playlist)
{
    Console.WriteLine(video);
}

*/

