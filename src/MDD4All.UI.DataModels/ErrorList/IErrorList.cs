using System.Collections.Generic;

namespace MDD4All.UI.DataModels.ErrorList
{
    public interface IErrorList
    {
        List<IErrorListElement> Errors { get; set; }

        bool ShowErrorCode { get; set; }

    }
}
