using Prova.Week1.Handler;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prova.Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher
            {
                Path = @"C:\Users\michela.putzu\source\repos\Prova.Week1\Prova.Week1",
                Filter = "*.txt"
            };

            fsw.EnableRaisingEvents = true; //abilita la pubblicazione dell'evento
            //stabilisco alcuni filtri da verificare in fase di pubblicazione
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess
                | NotifyFilters.DirectoryName | NotifyFilters.FileName;

             fsw.Created+= GestoreEvento.GestisciNuovoFile;

           

            Console.WriteLine("Premi q per uscire");
            while (Console.Read() != 'q') ;
        }
    }
}
