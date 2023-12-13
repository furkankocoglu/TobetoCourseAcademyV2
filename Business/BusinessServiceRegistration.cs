using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
namespace Business
{
    public static class BusinessServiceRegistration
    {
        //this kelimesi sayesinde AddBusinessServices fonksiyonumuz IServiceCollection dan türemiş bütün sınıf nesnelerine ekleniyor.
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			return services;
        }
    }
}