using src.Database.Domain;

namespace src.Database.Repositories
{
    public interface ITaskRepository
    {
         IQueryable<Todo> GetAll();
         Todo GetById(Guid Id);
         Todo Save(Todo entity);
    }
}
