using GameStore.Api.Detos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetGameendpoint = "GetGameById";

List<GameDetos> games = new List<GameDetos>
{
    new GameDetos(1, "The Legend of Zelda: Breath of the Wild", "Action-adventure", 59.99m, new DateOnly(2017, 3, 3)),
    new GameDetos(2, "God of War", "Action-adventure", 39.99m, new DateOnly(2018, 4, 20)),
    new GameDetos(3, "Red Dead Redemption 2", "Action-adventure", 59.99m, new DateOnly(2018, 10, 26)),
    new GameDetos(4, "The Witcher 3: Wild Hunt", "Action RPG", 49.99m, new DateOnly(2015, 5, 19)),
    new GameDetos(5, "Minecraft", "Sandbox", 26.95m, new DateOnly(2011, 11, 18))
};

// get the game
app.MapGet("/games", () => games);
// get a game by id
app.MapGet("/games/{id}", (int id) => games.Find(game=> game.Id == id) ).WithName("GetGameendpoint");

app.MapPost("games", (CreateVideoGameDetos newVideoVideo) =>
{
    var game = new GameDetos(
    games.Count + 1,
    newVideoVideo.Name,
    newVideoVideo.Genre,
    newVideoVideo.Price,
    newVideoVideo.ReleaseDate);
    games.Add(game);
    return Results.CreatedAtRoute("GetGameendpoint", new { id = game.Id }, game);

});

    // put games
app.MapPut("/games/{id}", (int id, UpdateVideoGameDetos updateVideoGame) =>
{
    var game = games.Find(g => g.Id == id);
    if (game is null) return Results.NotFound();

    var updatedGame = game with
    {
        Name = updateVideoGame.Name,
        Genre = updateVideoGame.Genre,
        Price = updateVideoGame.Price,
        ReleaseDate = updateVideoGame.ReleaseDate
    };
    games.Remove(game);
    games.Add(updatedGame);
    return Results.NoContent();
});
app.Run();
