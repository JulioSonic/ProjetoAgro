using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface IAnimal
    {
        public List<Animal> ListaAnimais();

        public void AdicionaAnimal(Animal animal);

        public void AtualizaAnimal(Animal animal);

        public Animal RetornaAnimalPorId(int id);

        public void DeletaAnimal(int id);
    }
}
