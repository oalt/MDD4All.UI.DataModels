using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.UI.DataModels.TabControl
{
    public interface ITabPage
    {
        Type ViewType { get; }

        string Header { get; }

        
    }
}
