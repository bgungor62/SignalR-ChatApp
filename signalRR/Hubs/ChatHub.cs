
using Microsoft.AspNetCore.SignalR;

namespace signalrChat.Hubs;


public class ChatHub : Hub
{
  public async Task SendMessage( string User,string Message){   
    //Bu Huba bağlanan bütün clientların dinleyeceği kısım burasıdır.Bu mesajı bu ismi dinle.
    //Buraya bir kullanıcı adı ve mesaj geldiği zaman tüm clientlara dağıtır.
    //ReceiveMessage ile de dinleriz
    await Clients.All.SendAsync("ReceiveMessage",User,Message); 
  }
}
