namespace GameStore.Api.Detos;

public record class GameDetos(
    int Id,
    string Name,
    string Genre,
    Decimal Price, 
    DateOnly ReleaseDate

    );



