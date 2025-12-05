using IntefracesAbstractions.Task1;
using IntefracesAbstractions.Task2;
using IntefracesAbstractions.Task3;
using System;

class Program
{
    public static void Main()
    {
        //Task1
        var services = new List<INotificationService>
        {
            new EmailNotification(),
            new SmsNotification(),
            new PushNotification()
        };

        SendToAll(services, "Тестовое сообщение");


        //Task2

        var shapes = new List<IntefracesAbstractions.Task2.Shape>
        {
            new IntefracesAbstractions.Task2.Circle(3),
            new IntefracesAbstractions.Task2.Rectangle(4, 5),
            new IntefracesAbstractions.Task2.Triangle(6, 3)
        };

        foreach (var shape in shapes)
        {
            shape.PrintInfo();
        }

        Console.ReadLine();


        //Task3

        var newShapes = new List<IntefracesAbstractions.Task3.Shape>
        {
            new IntefracesAbstractions.Task3.Circle(3),
            new IntefracesAbstractions.Task3.Rectangle(4, 5),
            new IntefracesAbstractions.Task3.Triangle(6, 3)
        };

        Console.WriteLine("До масштабирования:");
        foreach (var shape in newShapes)
        {
            shape.PrintInfo();
        }

        ShapeScaler.ScaleAll(newShapes, 2); // увеличиваем размеры в 2 раза

        Console.WriteLine();
        Console.WriteLine("После масштабирования (x2):");
        foreach (var shape in newShapes)
        {
            shape.PrintInfo();
        }

        Console.ReadLine();
    }

    public static void SendToAll(IEnumerable<INotificationService> services, string message)
    {
        foreach (var service in services)
        {
            service.Send($"[{service.ServiceName}] {message}");
        }
    }

}
