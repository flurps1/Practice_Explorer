using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Practice;
/// <summary>
/// View model for each directory item
/// </summary>
public class DirectoryItemViewModel : BaseViewModel
{
    #region Properties

    

    public DirectoryItemType Type { get; set; }
    public string FullPath { get; set; }
    public string Name { get { return this.Type == DirectoryItemType.drive ? this.FullPath : DirectroyStructure.GetFileFolderName(this.FullPath); } }

    public ObservableCollection<DirectoryItemViewModel> Children { get; set; }

    public bool CanExpand { get { return this.Type != DirectoryItemType.file; } }
    public bool IsExpanded
    {
        get { return this.Children?.Count(f => f != null) > 0; } 
        set {
            if (value == true)
            {
                Expand();
            }
            else
            {
                this.ClearCholdren();
            }
        }}
    #endregion

    #region Public command

    public ICommand ExpandCommand { get; set; }

    #region Constructor

    public DirectoryItemViewModel( string fullPath, DirectoryItemType type)
    {
        this.ExpandCommand = new RellayCommand(Expand);
        this.FullPath = fullPath;
        this.Type = type;
        this.ClearCholdren();
    }

    #endregion

    #endregion

    #region Helper functions

    private void ClearCholdren()
    {
        this.Children = new ObservableCollection<DirectoryItemViewModel>();
        if (this.Type !=DirectoryItemType.file)
        {
            this.Children.Add(null);
        }
    }
    #endregion

    private void Expand()
    {
        //Find all children
        if (this.Type == DirectoryItemType.file)
            return;
        var children = DirectroyStructure.GetDirectoryContent(this.FullPath);
        this.Children = 
            new ObservableCollection<DirectoryItemViewModel>(
                children.Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
    }

}