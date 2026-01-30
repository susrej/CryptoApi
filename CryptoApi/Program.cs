using CryptoApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var cipher = new CaesarCipher();

app.MapGet("/", () => "Hello World!");

app.MapGet("/encryption/encrypt", (string text, int shift) =>
{
    return Results.Ok(cipher.Encrypt(text,shift));
});

app.MapGet("/encryption/decrypt", (string text, int shift) =>
{
    return Results.Ok(cipher.Decrypt(text, shift));
});
app.Run();
