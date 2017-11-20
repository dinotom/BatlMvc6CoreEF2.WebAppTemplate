namespace Application.DomainClasses.Classes
{
    public class ViewCheck
    {
        public int ViewCheckId { get; set; }
        public string ViewName { get; set; }
        public string ActionName { get; set; }
        public string ViewController { get; set; }

        public bool IsWorking { get; set; }
        public bool IsTested { get; set; }
    }
}