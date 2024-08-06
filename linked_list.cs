using System.Runtime.CompilerServices;
using System.Xml;

namespace dsexample;

//Singly? Node have links to the next node only.
//Doubly? Nodes link both to their direct parent and direct child.
//Circular? Doubly, and the TAIL is known.

//Adv:
// * Dynamic growth.
// * Much easier to remove and add.
// * Data changes require only reference updates.

//Dis:
// * References consume more memory.
// * Finding elements requires list transversal.
// * Absence of of memory locality support.

//Circular Linked List && added generic type for value that MUST be comparable for sort algo.
public class LinkedList<T> where T : IComparable<T> {
    public Node<T>? Head { get; set; } // Using nullable reference type to remove warnings.
    public Node<T>? Tail { get; set; }
    private int size;

    public void Add(T value) {
        Node<T> node = new Node<T>(value);

        if (Head == null) {
            Head = node;
            Tail = node;
        } else {
            Node<T> current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

            current.Next = node;
            node.Previous = current;
            Tail = node;
        }
        size++;
    }

    public void InsertMiddle(T value) {
        Node<T> node = new Node<T>(value);

        if (Head == null) {
            Head = node;
            Tail = node;
        } else {
            Node<T> current = Head;

            for (int i = 0; i < size / 2; i++) {
                current = current.Next!;
            }

            node.Next = current.Next;
            if (node.Next != null) {
                node.Next.Previous = node;
            }
            current.Next = node;
            node.Previous = current;

            if (node.Next == null) {
                Tail = node;
            }
        }
        size++;
    }

    public void Print() {
        Node<T>? current = Head;
        while (current != null) {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    public void ReversePrint() {
        Node<T>? current = Tail;
        while (current != null) {
            Console.WriteLine(current.Value);
            current = current.Previous;
        }
    }

    public void Sort() {
        // Bubble sort algo: https://www.geeksforgeeks.org/bubble-sort-algorithm/
        if (Head == null) return;

        bool swapped;
        int n = size; // Number of elements in the list
        do {
            swapped = false; //If swapped stays false, means list is sorted and loop ends early.
            Node<T>? current = Head;

            // Traverse the list up to the last unsorted element.
            for (int i = 0; i < n - 1; i++) {

                // Ensure current and current.Next are not null
                // & Check if the current value is larger than the next value.
                if (current?.Next != null && current.Value.CompareTo(current.Next.Value) > 0) {
                    
                    // If it's larger we swap the values
                    T temp = current.Value;
                    current.Value = current.Next.Value;
                    current.Next.Value = temp;

                    // Mark that a swap occurred so another loop will take place.
                    swapped = true;
                }

                // Move to the next node.
                current = current?.Next;
            }

            // After each pass, the last element is in its correct place so we can reduce the loop.
            n--;

        } while (swapped); // Continue only if a swap was made.
    }

}

public class Node<T> {
    public T Value { get; set; }
    public Node<T>? Next { get; set; } // Using nullable reference type to avoid warnings.
    public Node<T>? Previous { get; set; }

    public Node(T value) {
        Value = value;
        Next = null;
        Previous = null;
    }
}


/* OLD CODE, NOT BEING USED.
Singly Linked List.

public class SinglyLinkedList {

    public Node Head {get; set;}
    private int size;

    public void add(string value) {
        Node node = new Node(value);

        //If at start of list, assign new data to the head.
        if (Head == null) {
            Head = node;
        }

        //Else traverse the list.
        else {
            Node current = Head;

            //Keep pulling next Node until we find an empty spot.
            while (current.Next != null) {
                current = current.Next;
            }

            //Save the reference to the new data in the parent node.
            current.Next = node;
        }
        size++;
    }

    public void Print() {
        Node current = Head;
        while (current != null) {
            Console.WriteLine($"{current.Value}");
            current = current.Next;
        }
    }
}*/

//Doubly Linked List.
/*public class DoublyLinkedList {

    public Node Head {get; set;}
    private int size;

    public void add(string value) {
        Node node = new Node(value);

        //If at start of list, assign new data to the head.
        if (Head == null) {
            Head = node;
        }

        //Else traverse the list.
        else {
            Node current = Head;

            //Keep pulling next Node until we find an empty spot.
            while (current.Next != null) {
                current = current.Next;
            }

            //Save the reference to the new data in the parent node.
            current.Next = node;

            //To make this doubly we also save the reference to the parent node.
            node.Previous = current;
        }
        size++;
    }

    public void Print() {
        Node current = Head;
        while (current != null) {
            Console.WriteLine($"{current.Value}");
            current = current.Next;
        }
    }

    public void ReversePrint() {
        Node current = Head;
        while (current.Next != null) {
            current = current.Next;
        }
        while (current != null) {
            Console.WriteLine($"{current.Value}");
            current = current.Previous;
        }
    }
}*/
