using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mission7.Models;


namespace Mission7
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            services.AddDbContext<BookstoreContext>(options =>
           {
               options.UseSqlite(Configuration["ConnectionStrings:BookDBConnection"]);

           });

            services.AddScoped<BookListRepository, EFBookListRepository>();
            services.AddScoped<PurchaseRepository, EFPurchaseRepository>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();

            services.AddSession();

            //this will go get a shopping cart and call the get shopping cart method 
            services.AddScoped<ShoppingCart>(x => SessionCart.GetShoppingCart(x));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //use files in the shared folder
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            //endpoints are executed in order
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute("typepage",
                    "{bookcategory}/Page{pageNum}",
                    new { Controller = "Home", action = "Index" });

                //go in, and find where it is passing the page num into the url and just have it say the number
                endpoints.MapControllerRoute(
                    "Paging",
                    //only display the word page and number instead of "pageNum=2"
                     "Page{pageNum}",
                     new { Controller = "Home", action = "Index", pageNum = 1 });
                //look at if it only has a project and not page number 
                endpoints.MapControllerRoute("category",
                    "{bookcategory}",
                    new {Controller = "Home", action = "Index", pageNum = 1});



                
                //useing the default controller route, "index"
                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();

               
            });
        }
    }
}
