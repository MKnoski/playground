using Microsoft.Extensions.DependencyInjection;
using pg.MongoDb.Data.Database.Context;
using pg.MongoDb.Data.Repositories;
using pg.MongoDb.Data.Repositories.Interfaces;

namespace pg.MongoDb.DependencyInjection
{
    public static class RegisterRepositoriesExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<INotesRepository, NotesRepository>();
            services.AddTransient<INoteContext, NoteContext>();

            return services;
        }
    }
}
