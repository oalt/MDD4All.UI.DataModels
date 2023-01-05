using System.Collections.ObjectModel;

namespace MDD4All.UI.DataModels.Tree
{
    public interface ITree
    {
        ObservableCollection<ITreeNode> TreeRootNodes { get; }

        ITreeNode SelectedNode { get; set; }
    }
}
