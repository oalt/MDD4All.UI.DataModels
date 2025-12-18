namespace MDD4All.UI.DataModels.ErrorList
{
    public interface IErrorListElement
    {
        ErrorType ErrorType { get; set; }

        string ErrorCode { get; set; }

        string Description { get; set; }

        string EffectedElement { get; set; }

        object[] LocalizationParameters { get; set; }
    }
}
