using Microsoft.EntityFrameworkCore;
using src.Api;
using src.BusinessRules.Handlers;
using src.BusinessRules.Validators;
using src.Database;
using src.Database.Repositories;
using ToDoApi.BusinessRules.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodoContext>(options =>
                                            options.UseInMemoryDatabase("TodoDataBase"));

builder.Services
.AddScoped<ITaskValidator, TaskValidator>()
.AddScoped<IUpsertTaskHandler, UpsertTaskHandler>()
.AddScoped<IGetAllTaskHandler, GetAllTasksHandler>()
.AddScoped<IGetByIdTaskHandler, GetByIdTaskHandler>()
.AddScoped<ITaskRepository, TaskRepository>();

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();
app.Run();
