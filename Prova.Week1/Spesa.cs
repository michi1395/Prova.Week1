using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1
{
    public class Spesa
    {
        public DateTime Data { get; set; }
        public Tipo Categoria  { get; set; }
        public string Descrizione { get; set; }
        public decimal Importo { get; set; }
        public bool Approvazione { get; set; }
        public string LvlApprov { get; set; }
        public decimal ImportoRimborsato { get; set; }
        
        public enum Tipo
        {
            Viaggio,
            Alloggio,
            Vitto,
            Altro
        };

        public Tipo CategoriaScelta(string cat)
        {
            if (cat.Equals("Viaggio"))
            {
                Categoria = Tipo.Viaggio;
            }
            else if (cat.Equals("Alloggio"))
            {
                Categoria = Tipo.Alloggio;
            }
            else if (cat.Equals("Vitto"))
            {
                Categoria = Tipo.Vitto;
            }
            else if (cat.Equals("Altro"))
            {
                Categoria = Tipo.Altro;

            }
            return Categoria;

        }
            
        }
    }

