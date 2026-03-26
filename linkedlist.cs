using System;
class Node
{
    public int data;
    public Node next;

    public Node(int value)
    {
        data = value;
        next = null;
    }
}
class LinkedList
{
    Node head;
    public void Add(int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
    public bool Find(int value)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data == value)
            {
                return true;
            }
            temp = temp.next;
        }
        return false;
    }
    public void Remove(int value)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        if (head.data == value)
        {
            head = head.next;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            if (temp.next.data == value)
            {
                temp.next = temp.next.next;
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Value not found");
    }
}
class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        Console.WriteLine("List:");
        list.Display();
        Console.WriteLine("Find 20: " + list.Find(20));
        list.Remove(20);
        Console.WriteLine("After removing 20:");
        list.Display();
    }
}