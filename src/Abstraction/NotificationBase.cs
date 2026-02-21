namespace src.Abstraction;

public abstract class NotificationBase
{
    protected string title;
    protected string content;

    public NotificationBase(string title, string content)
    {
        this.title = title;
        this.content = content;
    }

    public abstract void RenderText();
    public abstract void RenderImage(string imageUrl);
    public abstract void RenderVideo(string videoUrl);
}