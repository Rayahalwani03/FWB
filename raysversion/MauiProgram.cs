﻿using Microsoft.Extensions.Logging;
using raysversion.DataTransactions;

namespace raysversion
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "Student.db");

            builder.Services.AddSingleton(s =>
            ActivatorUtilities.CreateInstance<DBTrans>(s, _dbPath));

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
