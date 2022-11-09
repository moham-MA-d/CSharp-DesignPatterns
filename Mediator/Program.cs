using Mediator.ConcreteColleague;
using Mediator.ConcreteMediator;

var teamChat = new RestaurantChatHub();

var clientTeamUser = new ClientTeam("client 1");
var sellTeamUser = new SellTeam("sell 1 "); 
var supportTeamUser = new SupportTeam("support 1");

Console.WriteLine("====================Mediator Pattern====================");

teamChat.RegisterColleaguesBatch(clientTeamUser, sellTeamUser, supportTeamUser);

sellTeamUser.SendToTeam<ClientTeam>("Our Users cannot register a new order");
Thread.Sleep(1000);

clientTeamUser.SendToAll("Hello, A bug has found in ordering system, It must be solve soon.");
Thread.Sleep(1000);

supportTeamUser.SendToTeam<ClientTeam>("We will address this issue tight now!");
Thread.Sleep(2000);

supportTeamUser.SendToTeam<SellTeam>("The bug in ordering process just solved");

Console.ReadKey();