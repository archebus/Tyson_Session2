# Data Structures Example

This repository contains implementations of various data structures as part of a homework assignment. The tasks included building a binary tree, constructing a class with a generic type, creating a linked list, and constructing a stack.

## Homework Tasks

1. **Binary Tree**
   - Built a binary tree in C#.
   - Reference: [Visualgo Binary Search Tree](https://visualgo.net/en/bst)
   - Status: **Completed**

2. **Generic Class**
   - Constructed a class (`Box<T>`) that supports a generic type.
   - Status: **Completed**

3. **Linked List**
   - Created a linked list data structure.
   - Status: **Completed**

4. **Stack**
   - Constructed a stack data structure, similar to a linked list but with specific functionality.
   - Status: **Completed**

## Main Program Setup

The `Program` class contains methods to demonstrate the functionality of the implemented data structures. The main method calls one of these methods to showcase the specific data structure in action.

### Methods

- `NodeTreeThings()`
  - Demonstrates the binary tree.
  - Adds several nodes to the tree and prints the tree structure.
  - Removes a node and prints the updated tree.

- `BoxThings()`
  - Demonstrates the `Box<string>` class.
  - Adds several string items to the box and prints the contents.

- `ListThings()`
  - Demonstrates the linked list.
  - Adds 100 random integer values to the list, sorts the list, and prints the sorted values.

- `StackThings()`
  - Demonstrates the stack.
  - Pushes 20 random integer values onto the stack, prints the stack, pops a value from the stack, and prints the updated stack.

### Main Method

The main method currently calls `StackThings()` to demonstrate the stack functionality. You can uncomment other method calls to see different data structures in action.

```csharp
static void Main(string[] args)
{
    //NodeTreeThings();
    //BoxThings();
    //ListThings();
    StackThings();
}
