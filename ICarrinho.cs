namespace Aula26Interface
{
    public interface ICarrinho
    {
         //CRUD
         //CREATE
         //READ
         //UPDATE
         //DELETE
         //CalcularTotal
       void Ler();

       void Adicionar(Produto _produto);
      
       void Remover(Produto _produto);
       
       void Alterar(int _codigo, Produto _produtoAlterado);


    }
}