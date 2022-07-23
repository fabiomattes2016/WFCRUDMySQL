using API.Data;
using API.ViewModels;
using Microsoft.EntityFrameworkCore;
using WFCRUDMySQL.Model;

const string VERSION = "v1";
const string BASE_ENDPOINT = $"/api/{VERSION}";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ContatoDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet($"{BASE_ENDPOINT}/contato", async (ContatoDbContext context) =>
{
    List<Contato> contatos = await context.Contatos.ToListAsync();
    return Results.Ok(contatos);
})
.WithName("GetContatos")
.WithTags("Contato")
.Produces<List<Contato>>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status500InternalServerError);

app.MapGet($"{BASE_ENDPOINT}/contato" + "/{id}", async (int id, ContatoDbContext context) =>
{
    var contato = await context.Contatos.FindAsync(id);
    
    if (contato == null)
        return Results.NotFound(new { Message = "Contato não encontrado" });

    return Results.Ok(contato);
})
.WithName("GetContatoById")
.WithTags("Contato")
.Produces<Contato>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status500InternalServerError);

app.MapGet($"{BASE_ENDPOINT}/contato/pesquisa" + "/{parametro}", async (string? parametro, ContatoDbContext context) => 
{
    IQueryable<Contato>? query = from contato in context.Contatos 
                                 where EF.Functions.Like(contato.Nome, $"%{parametro}%") ||
                                 EF.Functions.Like(contato.Email, $"%{parametro}%")
                                 select contato;

    var contatos = await query.ToListAsync();
    return Results.Ok(contatos);
})
.WithName("GetContatoByNomeEmail")
.WithTags("Contato")
.Produces<List<Contato>>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status500InternalServerError);

app.MapPost($"{BASE_ENDPOINT}/contato", async (CreateContatoViewModel model, ContatoDbContext context) => 
{
    Contato contato = model.MapTo();

    if (!model.IsValid)
        return Results.BadRequest(model.Notifications);

    Contato contatoDb = await context.Contatos.FirstOrDefaultAsync(
        c => c.Telefone == contato.Telefone || c.Email == contato.Email);

    if (contatoDb != null)
        return Results.BadRequest(new { Message = "Contato já cadastrado" });

    context.Contatos.Add(contato);
    await context.SaveChangesAsync();

    return Results.Created($"{BASE_ENDPOINT}/contato/{contato.Id}", contato);
})
.WithName("PostContato")
.WithTags("Contato")
.Produces<Contato>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.Produces(StatusCodes.Status500InternalServerError);

app.MapPut($"{BASE_ENDPOINT}/contato" + "/{id}", async (int id, CreateContatoViewModel model, ContatoDbContext context) =>
{
    Contato contato = model.MapTo();

    if (!model.IsValid)
        return Results.BadRequest(model.Notifications);

    Contato contatoDb = await context.Contatos.AsNoTracking<Contato>().FirstOrDefaultAsync(c => c.Id == id);

    if(contatoDb == null)
        return Results.NotFound(new { message = "Contato não encontrado" });

    context.Contatos.Update(contato);

    await context.SaveChangesAsync();
    return Results.NoContent();
})
.WithName("PutContato")
.WithTags("Contato")
.Produces<Contato>(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status400BadRequest)
.Produces(StatusCodes.Status500InternalServerError);

app.MapDelete($"{BASE_ENDPOINT}/contato" + "/{id}", async (int id, ContatoDbContext context) =>
{
    Contato contato= await context.Contatos.AsNoTracking<Contato>().FirstOrDefaultAsync(c => c.Id == id);

    if (contato== null)
        return Results.NotFound(new { message = "Contato não encontrado" });

    context.Contatos.Remove(contato);

    await context.SaveChangesAsync();
    return Results.NoContent();
})
.WithName("DeleteContato")
.WithTags("Contato")
.Produces<Contato>(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status400BadRequest)
.Produces(StatusCodes.Status500InternalServerError);


app.Run();