using System.Collections.ObjectModel;
using System.Linq;

namespace Practice;

public class DirectoryStructureViewModel : BaseViewModel
{
    //all catalogs in pc
    public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

    #region Contructor
    /// <summary>
    /// Default constuctor
    /// </summary>
    

    public DirectoryStructureViewModel()
    {
        this.Items = new ObservableCollection<DirectoryItemViewModel>(DirectroyStructure.GetLogicalDrives()
            .Select(drive => new DirectoryItemViewModel(drive.FullPath, DirectoryItemType.drive)));
    }
    #endregion

}