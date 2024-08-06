namespace dsexample;

public class Box<T> where T : notnull // Not null constraint!
{
    private List<T> data = new();

    public void AddToBox(T item) {
        data.Add(item);
        Console.WriteLine($"{item} has been added to the Box.");
    }

    public void WhatsInTheBox() {
        foreach (T item in data) {
            Console.WriteLine($"You find: {item}");
        }
    }
}