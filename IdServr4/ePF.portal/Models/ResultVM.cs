namespace ePF.portal.Models
{
    public class ResultVM
    {
        public Status Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public string AccessToken{ get; set; }
    }

    public enum Status
    {
        Success = 1,
        Error = 2
    }
}
