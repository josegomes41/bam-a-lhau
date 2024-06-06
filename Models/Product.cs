namespace bamalhau.Models;

public record Product(
    string id,
    Category category,
    string sku,
    string name,
    string description,
    decimal price
);