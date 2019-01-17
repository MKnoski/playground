using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using pg.Services.Notes.Data.Database.Context;
using pg.Services.Notes.Data.Repositories;
using pg.Services.Notes.Data.Repositories.Interfaces;

namespace pg.Services.Notes.DependencyInjection
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
