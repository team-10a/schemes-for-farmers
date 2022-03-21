using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Schemasforfarmer.DataAccessLayer;
using Schemasforfarmer.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schemasforfarmer
{
    public class Startup
    {
        

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICropDao, CropDao>();
            services.AddSingleton<ISellDao, SellDao>();
            services.AddSingleton<IBidDao, BidDao>();
            services.AddSingleton<IMarketPlace, MarketPlaceDao>();
            services.AddSingleton<IWelcomePage, WelcomePageDao>();
            services.AddSingleton<ISellRequest, SellRequestDao>();
            services.AddSingleton<ISoldHistory, SoldHistoryDao>();
            services.AddSingleton<ILoginInfo, LoginDao>();
            services.AddSingleton<IUserInfo, UserInfoDao>();
            services.AddSingleton<IUserDetail, UserDetailDao>();
            services.AddSingleton<IApplyforPolicyDao, ApplyforPolicyDao>();
            services.AddSingleton<IBankDetailsDao, BankDetailsDao>();
            services.AddSingleton<IClaimInsuranceDao, ClaimInsuranceDao>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
