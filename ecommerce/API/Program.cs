using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//ENDPOINTS - FUNCIONALIDADES

//REQUEST/REQUISICÂO - URL
app.MapGet("/", () => "Hello World!");

//REQUEST/REQUISICÂO 
// - URL e Método HTTP
// - Paramêtro opcional
//Métodos HTTP
//GET - Pegar alguma informação
//POST - Enviar alguma informação
app.MapGet("/testarurl", () => "Primeira API");

app.MapGet("/parametro/{param1}", ([FromRoute]String param1) => {
    return param1 + " " + DateTime.Now;
} );

app.Run();
