namespace HanaaMahmoud_Mon_Thurs_4PM_MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Write Whatever you write after ConfigureServices()

            //Allow us to use controller router patterns
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            // Write Whatever you write after Configure()
            //Allow using the Routing in the app 
            app.UseRouting();
            app.UseStaticFiles();
            #region Not using Controllers 
            // Before your routing (UseEndpoints) take the url and cut it to take only the endpoint and search with it 
            // this process is done automatically
            /*app.Use(async (context, next) =>
            {
                Endpoint? endpoint = context.GetEndpoint();

                if(endpoint == null)
                    await context.Response.WriteAsync("Page Not Found");
                else  await next();
            });
            */

            //Allow Multiple routes Path
            // Browsers does not understand the post URL 
            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World");
                });
                // the next line allow passing parameter in the url (optional)
                // Constrains added to the optional parameter
                endpoints.MapGet("/products/{id:minlength(2)?}", async context =>
                {
                    var IdData = context.Request.RouteValues["id"];
                    if(IdData is not null)
                    {
                        int? id = Convert.ToInt32(IdData);
                        await context.Response.WriteAsync($"Your product id => {id}");
                    }
                    else
                    {
                        await context.Response.WriteAsync("Your are in Products Page");

                    }
                });

            });
            */

            //Handling Not found Page
            /*
            app.Run(async (HttpClient) =>
            {
                await HttpClient.Response.WriteAsync("Page Not Found");
            });
            */
            #endregion

            #region Routing Using Controllers Mapping
            app.MapControllerRoute(
                name :"default",
                pattern: "/{Controller = Home}/{action=Index}",
                defaults: new {Controller ="Home" ,Action = "Index" }
                );
            #endregion

            app.Run();
        }
    }
}
