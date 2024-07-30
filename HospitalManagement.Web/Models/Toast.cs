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
                ActionType.Error => "fa-circle-exclamation",
                _ => "fa-bell"
            };

            Color = actionType switch
            {
                ActionType.Error => "danger",
                _ => "success"
            };

            Message = message;
        }

        public string Message { get; set; }

        public string Icon { get; set; }

        public string Color { get; set; }
    }

    public enum ActionType
    {
        Create,
        Edit,
        Delete,
        Error
    }
}
