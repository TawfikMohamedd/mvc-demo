namespace mvc_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();
            #region hello
            //app.UseEndpoints(endpoints =>
            //{

            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Products Page");
            //    });
            //    endpoints.MapGet("/Products", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Products Page2");
            //    });


            //    //app.MapGet("/Home", () => "Hello World!");

            //}); 
            #endregion



            //app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync(""); });
            // app.MapGet("/Home", () => "Hello World!");

            app.Run();
            app.MapControllerRoute(
        name: "default",
        pattern: "{Controller=Home}/{Action=Index}",
        defaults: new { Controller = "Home", Action = "Index" });
            app.MapControllerRoute(
         name: "default",
         pattern: "{Controller=Home}/{Action=AboutUs}",
         defaults: new { Controller = "Home", Action = "AboutUs" }
     );
        }
    }
    }