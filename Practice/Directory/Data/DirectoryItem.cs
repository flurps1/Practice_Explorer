namespace Practice;

public class DirectoryItem
{
    public DirectoryItemType Type{ get; set; }
    public string FullPath { get; set; }
    public string Name
    {
        get { return this.Type ==DirectoryItemType.drive ? this.FullPath : DirectroyStructure.GetFileFolderName(this.FullPath); }
    }
}