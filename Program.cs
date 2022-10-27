using BarberTip.Contexts;
using BarberTip.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BarberTipContext>();
builder.Services.AddTransient<AgendamentoService>();
builder.Services.AddTransient<AtividadeService>();
builder.Services.AddTransient<ClienteService>();
builder.Services.AddTransient<EnderecoService>();
builder.Services.AddTransient<FuncionarioService>();
builder.Services.AddTransient<FuncionarioServicoService>();
builder.Services.AddTransient<RotinaService>();
builder.Services.AddTransient<ServicoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
