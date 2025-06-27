using MDD4All.UI.DataModels.DragDrop;
using System;
using System.Collections.ObjectModel;

namespace MDD4All.UI.DataModels.Tree
{
    public interface ITreeNode
    {
        ITree Tree { get; }

        ObservableCollection<ITreeNode> Children { get; }

        ITreeNode Parent { get; set; }

        int Index { get; }

        bool HasChildNodes { get; }

        bool IsExpanded { get; set; }

        bool IsSelected { get; set; }

        bool IsLoading { get; }

        bool IsDisabled { get; set; }

        event EventHandler TreeStateChanged;

        string DragDropOperationInformation { get; }
    }
}
