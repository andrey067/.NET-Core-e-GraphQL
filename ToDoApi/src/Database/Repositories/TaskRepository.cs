using src.Database.Domain;

namespace src.Database.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoContext _context;

        public TaskRepository(TodoContext context)
        => _context = context;
        public IQueryable<Todo> GetAll()
        {
            return _context.Tasks.AsQueryable();
        }

        public Todo GetById(Guid Id)
        {
            return _context.Tasks.SingleOrDefault(q => q.Id == Id);
        }

        public Todo Save(Todo entity)
        {
            if (!entity.Id.HasValue)
            {
                entity.Id = Guid.NewGuid();
                _context.Tasks.Add(entity);
            }
            _context.SaveChanges();
            return entity;
        }
    }
}
