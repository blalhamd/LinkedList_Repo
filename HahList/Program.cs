
using HahList;

internal class Program
{
    private static void Main(string[] args)
    {
        phones phone=new phones("sam",3000);
        phones phone2=new phones("redmi",5000);
        phones phone3=new phones("realmy",1200);
        phones phone4=new phones("iphone",9000);
        phones phone5=new phones("nokia",6000);
        phones phone6=new phones("Gh",4000);
        phones phone7=new phones("Vxjm",3000);

        List<phones> list=new List<phones>();
        list.Add(phone);
        list.Add(phone2);
        list.Add(phone3);
        list.Add(phone4);
        list.Add(phone5);
        list.Add(phone6);
        list.Add(phone7);

        // if you want to display elements in the list.
        foreach (phones x in list) { 
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(x);
        }


        // if you want to display elements in the list by stack.

        Stack<phones> stackkk= new Stack<phones>(list);
        stackkk.Push(new phones("ftgyhujiiu", 678)); // if i wanna add alot.
        foreach (var x in stackkk)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(x);
        }

        // if you want to display elements in the list by queue.

        Queue<phones> queues = new Queue<phones>(list);
        foreach (var x in queues)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(x);
        }

        // if you want to display elements in the list by HashSet.

        HashSet<phones> hashset=new HashSet<phones>(list);
     
        foreach (var x in hashset)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(x);
        }


        /*
              information is very very important >>> if i want to union two list together in stack or queue
              or hashset will do that <<<   nameHahSet1.UnionWith(nameHashSet2);  >>>
             
         */


        List<phones> list2= new List<phones>();
        list2.Add(new phones("ionj", 1234));
        list2.Add(new phones("rrtv", 3334));
        list2.Add(new phones("dfcf", 1134));
        list2.Add(new phones("qwqsqa", 8834));


        HashSet<phones> hashset2 = new HashSet<phones>(list2);

        hashset.UnionWith(hashset2);

        foreach (var x in hashset)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(x);
        }







        Console.ReadKey();
    }
}