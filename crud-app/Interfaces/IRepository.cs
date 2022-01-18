namespace crud_app.Interfaces
{
	public interface IRepository<T>
    {
         List<T> Lista();
        T RetornarPorId(int id);        
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}