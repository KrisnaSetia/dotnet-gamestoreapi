namespace GameStore.Api.Dtos;
// Dto adalah kontrak antar client dan server yang merepresentasikan resource bagaimana data dishare dan digunakan
public record class GameSummaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);