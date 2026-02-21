using src.Abstraction;

namespace src.Notifications;

public class NotificationDesktop : NotificationBase
{
    public NotificationDesktop(string title, string content) : base(title, content)
    {
    }

    public override void RenderText()
    {

        Console.WriteLine($"[Desktop - Toast] Windows Notification:");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ {title.PadRight(24)} ║");
        Console.WriteLine($"║ {content.PadRight(24)} ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }

    public override void RenderImage(string imageUrl)
    {

        Console.WriteLine($"[Desktop - Toast] Windows Notification with Image:");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ [IMG: {imageUrl.Substring(0, Math.Min(15, imageUrl.Length))}...]  ║");
        Console.WriteLine($"║ {title.PadRight(24)} ║");
        Console.WriteLine($"║ {content.PadRight(24)} ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }

    public override void RenderVideo(string videoUrl)
    {

        Console.WriteLine($"[Desktop - Toast] Windows Notification with Video:");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ ▶ {videoUrl.Substring(0, Math.Min(20, videoUrl.Length))}... ║");
        Console.WriteLine($"║ {title.PadRight(24)} ║");
        Console.WriteLine($"║ {content.PadRight(24)} ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }
}