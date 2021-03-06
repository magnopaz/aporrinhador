﻿using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;
using System;

namespace BotherApp.Worker
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Iniciando worker");
                string[] mensagem = new string[] { };
                BuildAvaloniaApp().StartWithClassicDesktopLifetime(mensagem);

            }


        }



        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug()
                .UseReactiveUI();
    }
}
