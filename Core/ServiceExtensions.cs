using AutoMapper;
using Core.Helpers;
using Core.Interfaces.Services;
using Core.Profiles;
using Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<ITestService, TestService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IOptionService, OptionService>();
            services.AddScoped<IUserTestService, UserTestService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserAnswerService, UserAnswerService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserProfile());
                mc.AddProfile(new TestProfile());
                mc.AddProfile(new QuestionProfile());
                mc.AddProfile(new OptionProfile());
                mc.AddProfile(new UserTestProfile());
                mc.AddProfile(new UserAnswerProfile());
            });

            var mapper = configures.CreateMapper();
            services.AddSingleton(mapper);
        }
        public static void ConfigJwtOptions(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<JwtOptions>(config.GetSection("JwtOptions"));
        }
    }
