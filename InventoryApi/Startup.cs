
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using InventoryDataAccessCore.Entity;
using InventoryBussnisesLogicCore.GenericRepository;
using InventoryBussnisesLogicCore.SpecificRepository;
using InventoryBussnisesLogic.SpecificRepository;
using InventoryDataAccessCore.Context;
using InventoryDataAccessCore.DTO;

namespace InventoryApi
{
    public class Startup
    {
        private string _loginOrigin = "_loginOrigin";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
         //services.AddDbContext<InventoryyContext>();
         services.AddDbContext<InventoryyContext>(option => option.UseSqlServer(Configuration.GetConnectionString("Inventory")));
            services.AddScoped(typeof(IGeneric<>), typeof(Generic<>));
            services.AddScoped<IBrandsService, BrandsService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAttrubuitValueService, AttrubuitValueService>();
            services.AddScoped<IAttrubService, AttrubService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<IStoresService, StoresService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IOrderService, OrderService>();
         //  services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<InventoryyContext>();
            services.AddCors(opt =>
            {
                opt.AddPolicy(_loginOrigin, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();


                });

            });
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<InventoryyContext>();
            services.AddScoped<IAccountService, AccountService>();
            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 3;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;
            });
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT:ValidAudience"],
                    ValidIssuer = Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"])),
                };
            });
          










        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors("_loginOrigin");


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), Configuration["FilePath"])),
                RequestPath = "/img"
            });
        

        app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
