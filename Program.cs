using IDSP_Boiler_Plate;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => new AuthenticationController().Process(context));


app.Run();
