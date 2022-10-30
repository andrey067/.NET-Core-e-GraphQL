namespace ToDoApi.BusinessRules.Responses
{
    public class TaskReponseItem
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime? DtDone { get; set; }
    }
}
