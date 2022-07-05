
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		LinkedList l = new LinkedList();
		l.AddNodeAtStart(2);
		l.AddNodeAtStart(3);
		l.AddNodeAtStart(4);
        Node node = l.ReverseLinkedLIst();
		l.PrintLinkedList(node);
	}
}

public class Node {
    int data;
    Node next;
}

public class LinkedList{
public Node head;

public void PrintLinkedList(Node head = null) {
    Node current = head;
    while(current.next != null) {
        Console.WriteLine(current.data);
        current = current.next;
    }
}

public void AddNodeAtStart(int data) {
    Node newNode = new Node();
    newNode.data = data;
    newNode.next = head;
    head = newNode;
}

public void AddNodeAtLAst(int data) {
    if(head = null) {
        head = new Node();
        head.data = data;
        head.next = null;
    } else {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = null;
        Node current = head;
        while(current.next != null) {
              current = current.next;
        }
        current.next = newNode;

    }
}

public InsertAfter(Node prevNode , int data) {
if(prevNode == null) return;

Node newNode = new Node();
newNode.data = data;
newNode.next = prevNode.next;
prevNode.next = newNode;
}

public Node ReverseLinkedLIst() {
    Node curr = head;
    Node prev = null;
    Node temp = null;

    while (curr != null) {
        temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
    }

    return prev;
}

}


