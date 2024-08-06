using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Security.AccessControl;

namespace dsexample;

class Program
{
    static void Main(string[] args)
    {
        
        //NodeTreeThings();

        //BoxThings();

        //ListThings();

        StackThings();


    }

    static void NodeTreeThings() {
        
        BinaryTree tree = new BinaryTree();

        // N O D E S
        tree.Add(50, "George");
        tree.Add(30, "Luke");
        tree.Add(70, "Ben");
        tree.Add(20, "Nicole");
        tree.Add(40, "Tyson");
        tree.Add(60, "D00d");
        tree.Add(80, "Freddy");

        // Print the tree!
        tree.PrintTree(tree.Root, "");

        Console.WriteLine("------------------");

        tree.Remove(50);
        tree.PrintTree(tree.Root, "");

    }

    static void BoxThings() {
        
        //Type String
        Box<string> box = new Box<string>();

        box.AddToBox("Unicorn Feather");
        box.AddToBox("Hopes and dreams");
        box.AddToBox("Statue of Donald Trump");
        box.AddToBox("Perpetual motion machine");
        box.AddToBox("A button labeled: Do NOT Press");

        box.WhatsInTheBox();

    }

    static void ListThings() {

        LinkedList<int> list = new();

        //Add random values:
        Random rand = new Random();
        for (int i = 0; i < 100; i++) {
            list.Add(rand.Next(0,1000)+1);
        }

        list.Sort();
        list.Print();

    }

    static void StackThings() {
        var stack = new Stack<int>();
        Random rand = new Random();
        
        for (int i = 0; i < 20; i++) {
            stack.Push(rand.Next(0,100) + 1);
        }

        Console.WriteLine($"Stack size: {stack.Count()}");
        stack.Print();

        Console.WriteLine($"-------------------------");
        Console.WriteLine($"Removing Node: {stack.Pop().Value}");
        Console.WriteLine($"Stack size: {stack.Count()}");
        stack.Print();
    }
}