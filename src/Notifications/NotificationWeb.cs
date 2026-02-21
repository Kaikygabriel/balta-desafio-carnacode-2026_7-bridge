using src.Abstraction;

namespace src.Notifications;

public class NotificationWeb : NotificationBase
{

    public NotificationWeb(string title, string content) : base(title, content)
    {
    }

    public override void RenderText()
    {
        Console.WriteLine($"[Web - HTML] <div class='notification'>");
        Console.WriteLine($"  <h3>{title}</h3>");
        Console.WriteLine($"  <p>{content}</p>");
        Console.WriteLine("</div>");
    }

    public override void RenderImage(string imageUrl)
    {
        Console.WriteLine($"[Web - HTML] <div class='notification-image'>");
        Console.WriteLine($"  <img src='{imageUrl}' />");
        Console.WriteLine($"  <h3>{title}</h3>");
        Console.WriteLine($"  <p>{content}</p>");
        Console.WriteLine("</div>");    }

    public override void RenderVideo(string videoUrl)
    {
        Console.WriteLine($"[Web - HTML] <div class='notification-video'>");
        Console.WriteLine($"  <video src='{videoUrl}' controls></video>");
        Console.WriteLine($"  <h3>{title}</h3>");
        Console.WriteLine($"  <p>{content}</p>");
        Console.WriteLine("</div>");
    }
}