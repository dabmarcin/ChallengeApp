using ChallangeApp;

User user1= new User("Marcin", "4242423423ee");
User user2= new User("Karolina", "4242423423ee");
User user3= new User("Tymon", "4242423423ee");
User user4= new User("Hanna", "4242423423ee");


var name = user1.Login;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);


