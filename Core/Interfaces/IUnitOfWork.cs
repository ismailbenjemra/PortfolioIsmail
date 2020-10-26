namespace Core.Interfaces
{
    public interface IUnitOfWork<T> where T:class
    {
        /// <summary>
        /// permet de fonctionner avec n'importe quel repository
        /// </summary>
        IGenericRepository<T> Entity { get; }
        void Save();
    }
}
