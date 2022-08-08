namespace PizzaСhainServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapGet("/", async x =>
            {
                await x.Response.WriteAsync("<h1>I am alive</h1>");
            }));
        }
    }
}
