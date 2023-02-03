using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class AnimalService : IAnimal
    {
        readonly DatabaseContext _dbContext = new();

        public AnimalService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Retorna detalhe com todos os animais 
        public List<Animal> ListaAnimais()
        {
            try
            {
                return _dbContext.Animal.ToList();
            }
            catch
            {
                throw;
            }
        }

        //Adicionar um novo registro de animal   
        public void AdicionaAnimal(Animal animal)
        {
            try
            {
                _dbContext.Animal.Add(animal);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Atualiza animal em particular   
        public void AtualizaAnimal(Animal animal)
        {
            try
            {
                _dbContext.Entry(animal).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Retorna animal por ID 
        public Animal RetornaAnimalPorId(int id)
        {
            try
            {
                Animal? animal = _dbContext.Animal.Find(id);

                if (animal != null)
                {
                    return animal;
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

        //Deleta animais por ID   
        public void DeletaAnimal(int id)
        {
            try
            {
                Animal? animal = _dbContext.Animal.Find(id);

                if (animal != null)
                {
                    _dbContext.Animal.Remove(animal);
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