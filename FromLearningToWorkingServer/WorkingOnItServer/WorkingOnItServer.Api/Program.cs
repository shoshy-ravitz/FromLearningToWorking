using FromLearningToWorking.Core;
using FromLearningToWorking.Core.Entities;
using FromLearningToWorking.Core.InterfaceRepository;
using FromLearningToWorking.Core.InterfaceService;
using FromLearningToWorking.Data;
using FromLearningToWorking.Data.Repository;
using FromLearningToWorking.Service.Services;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IInterviewQuestionService, InterviewQuestionService>();
builder.Services.AddScoped<IInterviewService, InterviewService>();
builder.Services.AddScoped<IResumeService, ResumeService>();
builder.Services.AddScoped<IManagerService, ManagerService>();

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IResumeRepository, ResumeRepository>();
builder.Services.AddScoped<IInterviewQuestionRepository, InterviewQuestionRepository>();
builder.Services.AddScoped<IInterviewRepository, InterviewRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Add services to the container.

var conctionString = "server = biwasykyb0xjwqlspjlq-mysql.services.clever-cloud.com;port=3306; database = biwasykyb0xjwqlspjlq; user = uzyg9lm4st0ea9dt; password = mtkv1c6JMTmmc4oi9CBn;";
builder.Services.AddDbContext<DataContext>( options =>options.UseMySql(conctionString,
        new MySqlServerVersion(new Version(8, 0, 0)))); // שנה לגרסה המתאימה
builder.Services.AddControllers();
// רישום DataContext







// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

  





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
