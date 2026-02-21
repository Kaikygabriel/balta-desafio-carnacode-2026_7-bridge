using System.Transactions;
using src.Notifications;

Console.WriteLine("=== Sistema de Notificações Multi-Plataforma ===\n");

var NotificationWeb = new NotificationWeb("Novo Pedido", "Você tem um novo pedido");
NotificationWeb.RenderText();
Console.WriteLine();

var NotificationMobile = new NotificationMobile("Novo Pedido", "Você tem um novo pedido");
NotificationMobile.RenderText();
Console.WriteLine();

NotificationWeb.RenderImage("promo.jpg");
Console.WriteLine();

NotificationMobile.RenderImage("tutorial.mp4");
Console.WriteLine();
