namespace dsexample;

class BinaryTreeNode
{
    
    public int Key {get; set; }
    public string Value {get; set;}
    public BinaryTreeNode? Left {get; set;}
    public BinaryTreeNode? Right {get; set;}

    public BinaryTreeNode(int key, string value) {
        Key = key;
        Value = value;
        Left = null;
        Right = null;
    }
    
    public void setLeft(BinaryTreeNode n) {
        Left = n;
    }

    public void setRight(BinaryTreeNode n) {
        Right = n;
    }
    
}

class BinaryTree {
    public BinaryTreeNode? Root {get; set;}

    public void Add(int key, string value)
    {
        if (Root == null)
        {
            Root = new BinaryTreeNode(key, value);
        }
        else
        {
            AddTo(Root, key, value);
        }
    }

    private void AddTo(BinaryTreeNode node, int key, string value)
    {
        // Traverse the tree
        while (true)
        {
            if (key == node.Key)
            {
                node.Value = value; // Update value if the key already exists
                break;
            }
            else if (key < node.Key)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode(key, value);
                    break;
                }
                else
                {
                    node = node.Left;
                }
            }
            else // key > node.Key
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode(key, value);
                    break;
                }
                else
                {
                    node = node.Right;
                }
            }
        }
    }

    public bool Remove(int key) {
        Root = Remove(Root, key);
        return Root != null;
    }

    private BinaryTreeNode? Remove(BinaryTreeNode? node, int key) {
        //Nothing found.
        if (node == null) {
            return null;
        }

        //Traverse the tree with recursive method calls:
        if (key < node.Key) {
            node.Left = Remove(node.Left, key);
        } else if (key > node.Key) {
            node.Right = Remove(node.Right, key);
        } else {

            //When we find the node with the key.
            //Check if empty left or right paths.
            if (node.Left == null) {
                return node.Right;
            }
            if (node.Right == null) {
                return node.Left;
            }

            BinaryTreeNode minNode = FindMin(node.Right);
            node.Key = minNode.Key;
            node.Value = minNode.Value;
            node.Right = Remove(node.Right, minNode.Key);
        }
        return node;
    }

    private BinaryTreeNode FindMin(BinaryTreeNode node) {
        while (node.Left != null) {
            node = node.Left;
        }
        return node;
    }

    public void PrintTree(BinaryTreeNode? node, string indent)
    {
        if (node != null)
        {
            PrintTree(node.Left, indent + "   ");
            Console.WriteLine(indent + $"{node.Key}: {node.Value}");
            PrintTree(node.Right, indent + "   ");
        }
    }
}