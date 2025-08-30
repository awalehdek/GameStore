namespace GameStore.Api.Detos;

public record class UpdateVideoGameDetos
(
    string Name,
    string Genre,
    Decimal Price, 
    DateOnly ReleaseDate

);