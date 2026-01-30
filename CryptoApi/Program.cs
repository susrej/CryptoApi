using CryptoApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var cipher = new CaesarCipher();

app.MapGet("/", () => "Hello World!");

app.MapGet("/encryption/encrypt", (string text, int shift) =>
{
    return Results.Ok(cipher.Encrypt(text,shift));
});
app.Run();
