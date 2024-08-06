using System;
using System.Threading;

namespace dsexample;

class Stack<T> where T : IComparable<T>
{
    public stackNode<T>? Head { get; set; } = default!;
    private int size; 

    public stackNode<T> Push(T value) {
        //Inserts an element onto the top of the stack.
        stackNode<T> newNode = new stackNode<T>(value);

        //Increase size of stack.
        size++;

        //If head is empty (new stack) just insert the new Node as the top.
        if (Head == null) {
            Head = newNode;
            return newNode;
        }

        //Not needed, but for easier semantics.
        var oldNode = Head;

        oldNode.Above = newNode;
        newNode.Below = oldNode;
        Head = newNode;
        return newNode;

    }

    public stackNode<T> Pop() {
        //Removes and element from the top of the stack.

        //If head is empty (new stack) just insert the new Node as the top.
        if (Head == null) {
            Console.WriteLine("Error, stack empty.");
            return null!;
        } else {
            //Lower size of stack.
            size--;

            //Update references.
            var removedNode = Head;
            var newNode = Head.Below;
            Head = newNode;
            return removedNode;
        }
    }

    public stackNode<T> Top() => Head!;

    public bool isEmpty() => Head == null;

    public int Count() => size;

    public void Print() {
        //Start at the Head Node.
        var current = Head;

        //Until we reach the bottom of the stack.
        while (current.Below != null) {
            Console.WriteLine(current.Value);
            current = current.Below!;
        }
    }

    public override string ToString() {
        return $"Next in queue: {Head.Value!}";
    }
}

class stackNode<T> {
    public T Value { get; set; }
    public stackNode<T>? Above { get; set; }
    public stackNode<T>? Below { get; set; }

    public stackNode(T value) {
        Value = value;
        Above = null;
        Below = null;
    }
}