public class Node
{
    public object element;
    public Node link;
    public Node()
    {
        element = null;
        link = null;
    }
    public Node(object element)
    {
        this.element = element;
        link = null;
    }
}
public class LinkedList
{
    public Node header;
    public LinkedList()
    {
        header = new Node("Header");
    }
    private Node Find(object element)
    {
        Node current = new Node();
        current = header;
        while (current.element != element)
            current = current.link;
        return current;
    }
    public void Insert(object newelement, object afterelement)
    {
        Node current = new Node();
        Node newnode = new Node(newelement);
        current = Find(afterelement);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrev(object element)
    {
        Node current = header;
        while (current.link != null && current.link.element != element)
            current = current.link;
        return current;
    }
    public void Remove(object element)
    {
        Node current = FindPrev(element);
        if (current.link != null)
            current.link = current.link.link;
    }
    public void Print()
    {
        Node current = new Node();
        current = header;
        while (current.link != null)
        {
            Console.WriteLine(current.link.element);
            current = current.link;
        }
    }
    public int FindMax(){
        Node current = header.link;
        int max = int.Parse(current.element.ToString());
        while(current.link != null){
            current = current.link;
            int temp = int.Parse(current.element.ToString());
            if(temp > max)
                max = temp;
        }
        return max;
    }
    public int Sum(){
        int S = 0;
        Node current = header.link;
        while(current != null){
            S += int.Parse(current.element.ToString());
            current = current.link;
        }
        return S;
    }
    public int Sum2(){
        Node current = header.link;
        int S = int.Parse(current.element.ToString());
        while(current.link != null){
            current = current.link;
            S += int.Parse(current.element.ToString());
        }
        return S;
    }
    public int Count(){
        Node current = header.link;
        int count = 1;
        while(current.link != null){
            current = current.link;
            count++;
        }
        return count;
    }
}
public class Program{
    public static void Main(string[] args)
    {
        Console.Clear();
        LinkedList list = new LinkedList();
        list.Insert("1", "Header");
        list.Insert("20", "1");
        list.Insert("3", "20");
        list.Insert("9", "3");
        list.Insert("5", "9");
        list.Insert("27", "5");
        list.Insert("7", "27");
        list.Print();
        Console.WriteLine("Max: " + list.FindMax());
        Console.WriteLine("Sum: " + list.Sum());
        Console.WriteLine("Sum2: " + list.Sum2());
        Console.WriteLine("Count: " + list.Count());
    }
}