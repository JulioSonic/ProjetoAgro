using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class FazendaService : IFazenda
    {
        readonly DatabaseContext _dbContext = new();

        public FazendaService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Retorna lista com todas as Fazendas  
        public List<Fazenda> ListaFazendas()
        {
            try
            {
                return _dbContext.Fazenda.ToList();
            }
            catch
            {
                throw;
            }
        }

        //Adiciona uma nova Fazenda    
        public void AdicionaFazenda(Fazenda Fazenda)
        {
            try
            {
                _dbContext.Fazenda.Add(Fazenda);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Atualiza Fazenda especifica   
        public void AtualizaFazenda(Fazenda Fazenda)
        {
            try
            {
                _dbContext.Entry(Fazenda).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //retorna os detalhes de uma Fazenda por id  
        public Fazenda RetornaFazendaPorId(int id)
        {
            try
            {
                Fazenda? Fazenda = _dbContext.Fazenda.Find(id);

                if (Fazenda != null)
                {
                    return Fazenda;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //Deleta Fazenda 
        public void DeletaFazenda(int id)
        {
            try
            {
                Fazenda? Fazenda = _dbContext.Fazenda.Find(id);

                if (Fazenda != null)
                {
                    _dbContext.Fazenda.Remove(Fazenda);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}