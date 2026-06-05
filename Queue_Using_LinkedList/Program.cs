using System;

class Node
{
    public string orderDetails; 
    public Node next;
}

class RestaurantQueueManager
{
    Node front;
    Node rear;

    public RestaurantQueueManager()
    {
        front = rear = null;
    }

    public bool isEmpty()
    {
        return front == null;
    }

    public void PlaceOrder(string details)
    {
        Node newNode = new Node();
        newNode.orderDetails = details;

        if (isEmpty())
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
        Console.WriteLine($"New Order Added to kitchen queue: {details}");
    }

    public string PrepareNextOrder()
    {
        if (isEmpty())
        {
            Console.WriteLine("Kitchen Alert: No pending orders to prepare.");
            return null;
        }
        string readyOrder = front.orderDetails;
        front = front.next;

        if (front == null)
        {
            rear = null;
        }

        Console.WriteLine($"Order Ready & Served: '{readyOrder}'");
        return readyOrder;
    }

    public void PeekNextOrder()
    {
        if (isEmpty()) { Console.WriteLine("No orders in the queue."); return; }
        Console.WriteLine($"Next order to be cooked: {front.orderDetails}");
    }

    public void DisplayKitchenQueue()
    {
        if (isEmpty())
        {
            Console.WriteLine("The kitchen has cleared all orders!");
            return;
        }
        Console.WriteLine("Current Kitchen Order Line");
        Node temp = front;
        while (temp != null)
        {
            Console.Write($"[{temp.orderDetails}]:");
            temp = temp.next;
        }
        Console.WriteLine("CHEF\n");
    }

    public int GetPendingOrdersCount()
    {
        int count = 0;
        Node temp = front;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RestaurantQueueManager kitchen = new RestaurantQueueManager();

        kitchen.PlaceOrder("Order #101: Double Beef Burger with Fries");
        kitchen.PlaceOrder("Order #102: Large Crispy Chicken Pizza");
        kitchen.PlaceOrder("Order #103: Crunchy Chicken Strips Meal");

        kitchen.DisplayKitchenQueue();
        Console.WriteLine($"Total pending orders in kitchen: {kitchen.GetPendingOrdersCount()}");

        kitchen.PeekNextOrder();

        Console.WriteLine("Chef finished cooking first order:");
        kitchen.PrepareNextOrder();

        kitchen.DisplayKitchenQueue();
    }
}