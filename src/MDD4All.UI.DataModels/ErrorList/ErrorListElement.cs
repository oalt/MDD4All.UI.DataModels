namespace MDD4All.UI.DataModels.ErrorList
{
    public class ErrorListElement : IErrorListElement
    {
        public ErrorType ErrorType { get; set; } = ErrorType.Error;

        public string ErrorCode { get; set; } = "";

        public string Description { get; set; } = "";

        public string EffectedElement { get; set; } = "";

        public object[] LocalizationParameters { get; set; } = { };
    }
}
