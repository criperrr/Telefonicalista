using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using telehonicalista.Models;
using telehonicalista;

namespace telehonicalista.Presenters
{
    public class ContatoPresenter
    {
        private Contexto db;
        public ContatoPresenter()
        {
            db = new Contexto();
            db.Database.EnsureCreated();
        }

        public bool AdicionarContato(Contato novo)
        {
            db.Contatos.Add(novo);
            return db.SaveChanges() > 0;
        }
    }
}