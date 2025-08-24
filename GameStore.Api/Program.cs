using GameStore.Api.Detos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDetos> games = new List<GameDetos>
{
    new GameDetos(1, "The Legend of Zelda: Breath of the Wild", "Action-adventure", 59.99m, new DateOnly(2017, 3, 3)),
    new GameDetos(2, "God of War", "Action-adventure", 39.99m, new DateOnly(2018, 4, 20)),
    new GameDetos(3, "Red Dead Redemption 2", "Action-adventure", 59.99m, new DateOnly(2018, 10, 26)),
    new GameDetos(4, "The Witcher 3: Wild Hunt", "Action RPG", 49.99m, new DateOnly(2015, 5, 19)),
    new GameDetos(5, "Minecraft", "Sandbox", 26.95m, new DateOnly(2011, 11, 18))
};

app.MapGet("/games", () => games);
app.MapGet("/", () => "Hello World!");

app.Run();
