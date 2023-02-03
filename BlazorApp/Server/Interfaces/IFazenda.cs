using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface IFazenda
    {
        public List<Fazenda> ListaFazendas();

        public void AdicionaFazenda(Fazenda Fazenda);

        public void AtualizaFazenda(Fazenda Fazenda);

        public Fazenda RetornaFazendaPorId(int id);

        public void DeletaFazenda(int id);
    }
}
