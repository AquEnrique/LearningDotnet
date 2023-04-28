using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using NotasApi.BusinessService;
using NotasApi.DataService;
using NotasApi.models;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(opt => 
        opt.UseSqlServer(builder.Configuration.GetConnectionString("connection_sql"))
    );

builder.Services.AddTransient<StudentDataService>();
builder.Services.AddTransient<StudentBusinessService>();

builder.Services.AddTransient<TeacherDataService>();
builder.Services.AddTransient<TeacherBusinessService>();

builder.Services.AddTransient<SemesterDataService>();
builder.Services.AddTransient<SemesterBusinessService>();

builder.Services.AddTransient<ProfessionalSchoolDataService>();
builder.Services.AddTransient<ProfessionalSchoolBusinessService>();

builder.Services.AddTransient<QuestionDataService>();
builder.Services.AddTransient<QuestionBusinessService>();

builder.Services.AddTransient<CareerDataService>();
builder.Services.AddTransient<CareerBusinessService>();

builder.Services.AddTransient<CourseDataService>();
builder.Services.AddTransient<CourseBusinessService>();

builder.Services.AddTransient<TeacherCourseDataService>();
builder.Services.AddTransient<TeacherCourseBusinessService>();

builder.Services.AddTransient<StudentCourseDataService>();
builder.Services.AddTransient<StudentCourseBusinessService>();

builder.Services.AddTransient<ReviewDataService>();
builder.Services.AddTransient<ReviewBusinessService>();

builder.Services.AddTransient<EvaluationDataService>();
builder.Services.AddTransient<EvaluationBusinessService>();

builder.Services.AddTransient<QuestionAlternativeDataService>();
builder.Services.AddTransient<QuestionAlternativeBusinessService>();

builder.Services.AddTransient<EvaluationXQuestionDataService>();
builder.Services.AddTransient<EvaluationXQuestionBusinessService>();

builder.Services.AddTransient<EvaluationAssignmentDataService>();
builder.Services.AddTransient<EvaluationAssignmentBusinessService>();

builder.Services.AddTransient<AnswerDataService>();
builder.Services.AddTransient<AnswerBusinessService>();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

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
