using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using finstar.db;
using finstar.core;

namespace finstar.api {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();

            services.AddDbContext<RecordsContext>();

            services.AddTransient<IRecordsServices, RecordsServices>();

            services.AddSwaggerDocument(settings => {
                settings.Title = "Records";
            });

            services.AddCors(options => {
                options.AddPolicy("RecordsPolicy", 
                    builder => {
                        builder.WithOrigins("*")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    }
                );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("RecordsPolicy");

            app.UseAuthorization();

            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
