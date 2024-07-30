namespace HospitalManagement.Web.Models
{
    public record Toast
    {
        public Toast() { }

        public Toast(ActionType actionType, string message)
        {
            Icon = actionType switch
            {
                ActionType.Create => "fa-circle-plus",
                ActionType.Edit => "fa-pen",
                ActionType.Delete => "fa-trash-can",
                _ => "fa-bell"
            };

            Message = message;
        }

        public string Message { get; set; }

        public string Icon { get; set; }
    }

    public enum ActionType
    {
        Create,
        Edit,
        Delete
    }
}
