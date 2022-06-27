// See https://aka.ms/new-console-template for more information
using MediatorPattern.ChatApp;
using MediatorPattern.Structural;

//InitialDemo();

var teamChat = new TeamChatroom();

var steve = new Developer() { Name= "Steve" };
var justin = new Developer() { Name = "Justin" }; 
var jenna = new Developer() { Name = "Jenna" };
var kim = new Tester() { Name = "Kim" };
var julia = new Tester() { Name = "Julia" };
teamChat.RegisterMembers(steve, justin, jenna, kim, julia);

steve.Send("Hey everyone, we're going to be deploying at 2pm today.");
kim.Send("Ok, thanks for letting us know.");

Console.WriteLine();
steve.SendTo<Developer>("Make sure to execute your unit tests before checking in!");

static void InitialDemo()
{

    Console.WriteLine("Hello, World!");
    var m = new ConcreteMediator();
    var c1 = m.CreateColleague<Colleague1>();
    var c2 = m.CreateColleague<Colleague2>();

    c1.Send("Hello, World! from c1");
    c2.Send("Hello, World! from c2");
}