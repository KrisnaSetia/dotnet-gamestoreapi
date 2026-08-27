namespace GameStore.Api.Dtos;
// Dto adalah kontrak antar client dan server yang merepresentasikan resource bagaimana data dishare dan digunakan
public record class GameDetailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);