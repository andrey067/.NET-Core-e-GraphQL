namespace src.BusinessRules.Request
{
    public class UpersetTaskRequest
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
