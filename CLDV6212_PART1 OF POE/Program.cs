using CLDV6212_PART1_OF_POE.Services;

namespace CLDV6212_PART1_OF_POE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Creates the New Web Application instance.
            //Controllers with Views to the 4 servcies containers.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<BlobService>();
            builder.Services.AddSingleton<TableService>();
            builder.Services.AddSingleton<QueueService>();
            builder.Services.AddSingleton<FileService>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                //Handles error handling in the environment.
                //Enables HTTP Strict Transport Security known as (HSTS).
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
//<Summary of Code File:>
//Line 29 to 36:
//Line 29: Code redirects HTTP requests to HTTPS.
//Line 30: Static files is like the CSS files and javascript.
//Line 31: Eanbles the routing, the connection between code files.
//Line 32: Authorization process.
//Line 33: Configures the Default route for MVC Controllers in file.
//Line 36: "app.Run();" Runs the Web Application and gathers all the incoming HTTP requests.
//</Summary>
//---------------------------------- END OF FILE ---------------------------------------------------------------------------