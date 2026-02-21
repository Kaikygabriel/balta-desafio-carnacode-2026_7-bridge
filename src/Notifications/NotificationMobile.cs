using src.Abstraction;

namespace src.Notifications;

public class NotificationMobile : NotificationBase
{
    public NotificationMobile(string title, string content) : base(title, content)
    {
    }

    public override void RenderText()
    {
        
        Console.WriteLine($"[Mobile - Native] Push Notification:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Body: {content}");
        Console.WriteLine($"Icon: notification_icon.png");

    }

    public override void RenderImage(string imageUrl)
    {

        Console.WriteLine($"[Mobile - Native] Rich Push Notification:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Body: {content}");
        Console.WriteLine($"Image: {imageUrl}");
        Console.WriteLine($"Style: BigPictureStyle");
    }

    public override void RenderVideo(string videoUrl)
    {

        Console.WriteLine($"[Mobile - Native] Video Push Notification:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Body: {content}");
        Console.WriteLine($"Video: {videoUrl}");
        Console.WriteLine($"Action: Tap to play");
    }
}