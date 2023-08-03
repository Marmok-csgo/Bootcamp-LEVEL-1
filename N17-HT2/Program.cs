
var chat = new ChatService();

var id1 = chat.Add("Hi everybody!");
var id2 = chat.Add("Let's get started");
var id3 = chat.Add("We'll start the meeting in 10 minutes");
chat.Update(id3, "Sorry guys, we are having technical issues, let's wait for another 10 minutes.");
chat.Update(id3, "I'm really sorry meeting is cancelled");

chat.Display();