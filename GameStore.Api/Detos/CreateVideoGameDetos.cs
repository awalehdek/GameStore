namespace GameStore.Api.Detos;

public record class CreateVideoGameDetos(

    string Name,
    string Genre,
    Decimal Price, 
    DateOnly ReleaseDate

);
