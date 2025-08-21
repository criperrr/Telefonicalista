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

        public List<Contato> ObterContatos(string busca)
        {
            if (busca == "")
                return db.Contatos.OrderBy(c => c.Id).ToList();
            if (busca.Contains("="))
            {
                string buscaAvancada = busca.Substring(busca.IndexOf("=") + 1);
                if (buscaAvancada == "")
                    return db.Contatos.OrderBy(c => c.Id).ToList();
                if (busca.Contains("Telefone"))
                    return db.Contatos.Where(c => c.Telefone.Contains(buscaAvancada)).OrderBy(c => c.Id).ToList();
                else if (busca.Contains("Nome"))
                    return db.Contatos.Where(c => c.Nome.Contains(buscaAvancada)).OrderBy(c => c.Id).ToList();
                else if (busca.Contains("Id"))
                    return db.Contatos.Where(c => c.Id.ToString().Contains(buscaAvancada)).OrderBy(c => c.Id).ToList();

            }
            return db.Contatos.Where(c => c.Nome.Contains(busca) || c.Telefone.Contains(busca)).OrderBy(c => c.Id).ToList();
        }


        public Contato SelecionarContato(int id)
        {
            return db.Contatos.Find(id);
        }

        public bool EditarContato(Contato contato)
        {
            db.Contatos.Update(contato);
            return db.SaveChanges() > 0;
        }

        public bool ExcluirContato(int id)
        {
            Contato contato = SelecionarContato(id);
            if (contato == null)
                return false;
            db.Contatos.Remove(contato);
            return db.SaveChanges() > 0;

        }
    }
}