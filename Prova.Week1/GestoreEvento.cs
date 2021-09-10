using Prova.Week1.Factory;
using Prova.Week1.Handler;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prova.Week1
{
    internal class GestoreEvento
    {
        static List<Spesa> spese = new List<Spesa>();
        public static void GestisciNuovoFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Gestione dell'evento {e.ChangeType} sul file {e.Name}");
            spese=ReadFile(e);

            IHandler manager = new ManagerHandler();
            IHandler operationMan = new OperationManagerHandler();
            IHandler ceo = new CEOHandler();
            IHandler noAppr = new NoApprovedHandler();


            IHandler secondoAnello = manager.SetNext(operationMan);
            IHandler terzoAnello = secondoAnello.SetNext(ceo);
            IHandler quartoAnello = terzoAnello.SetNext(noAppr);

            List<Spesa> listaSpese = new List<Spesa>();
            foreach (Spesa sp in spese)
            {
                Spesa spesHand = new Spesa();
                spesHand = manager.Handle(sp);
                listaSpese.Add(spesHand);
            }

            IRimborso rimborso = null;
            foreach(Spesa sp in listaSpese)
            {
                ImportoFactory factory = new ImportoFactory();
                rimborso = factory.GetRimborso(sp);
                
            }

           

            //foreach (Spesa sp in listaSpese)
            //{
            //    Console.WriteLine("{0,10}{1,20}{2,20}{3,20}{4,10}{5,10}", sp.Data.ToShortDateString(), sp.Categoria, sp.Descrizione, sp.Importo,sp.Approvazione,sp.LvlApprov);
            //}

        }

        private static List <Spesa> ReadFile(FileSystemEventArgs e)
        {
            //Lettura da file
            try
            {
               
                using (StreamReader reader = File.OpenText(e.FullPath))
                {

                    Console.WriteLine($"Lettura del file {e.Name} in corso");
                    

                    string file = reader.ReadToEnd();
                    string[] righeFile = file.Split("\r\n");

                    for(int i=1; i<righeFile.Length;i++)
                    {
                        string []dati = righeFile[i].Split(";");
                        DateTime.TryParse(dati[0], out DateTime data);
                        string categoria = dati[1];
                        string descrizione = dati[2];
                        decimal.TryParse(dati[3], out decimal importo);

                        Spesa spesa = new Spesa();
                        spesa.Data = data.Date;
                        spesa.Categoria = spesa.CategoriaScelta(categoria);
                        spesa.Descrizione = descrizione;
                        spesa.Importo = importo;

                        spese.Add(spesa);

                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("\n Fine del file \n");

                    //Console.WriteLine("=============================");
                    //Console.WriteLine("LISTA DELLE SPESE");
                    //Console.WriteLine();
                    //Console.WriteLine("{0,20}{1,20}{2,20}{3,20}", "Data", "Categoria", "Descrizione", "Importo");

                    //foreach(Spesa sp in spese)
                    //{
                    //    Console.WriteLine("{0,20}{1,20}{2,20}{3,20}", sp.Data.ToShortDateString(), sp.Categoria, sp.Descrizione, sp.Importo);
                    //}
                    




                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return spese;
        }
    }
}