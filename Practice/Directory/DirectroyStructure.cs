using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice;

public static class DirectroyStructure
{
    
    /// <summary>
    /// Gets all logical drives on pc
    /// </summary>
    /// <returns></returns>
    public static List<DirectoryItem> GetLogicalDrives()
    {
        return Directory.GetLogicalDrives().Select(drive => new DirectoryItem {FullPath = drive, Type = DirectoryItemType.drive}).ToList();
    }

    /// <summary>
    /// Gets direcories top-level content
    /// </summary>
    /// <param name="fullPath">full path to content</param>
    /// <returns></returns>
    public static List<DirectoryItem> GetDirectoryContent(string fullPath)
    {
        var items = new List<DirectoryItem>();
        #region Get folders
        
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                    items.AddRange(dirs.Select(dir => new DirectoryItem{ FullPath = dir, Type = DirectoryItemType.folder}));
            }
            catch {  }
        #endregion

        #region Get Files
            
            try
            {
                var fs  = Directory.GetFiles(fullPath);
                if (fs.Length > 0)
                    items.AddRange(fs.Select(file => new DirectoryItem { FullPath = file, Type = DirectoryItemType.file}));
            }
            catch { }

            return items;

        #endregion
    }
    
    #region Helpers

    #region Get File Or Folder
    /// <summary>
    /// find file or folder name
    /// </summary>
    /// <param name="directoryPath"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
        

    public static string GetFileFolderName(string path)
    {
        if (string.IsNullOrEmpty(path))
            return string.Empty;
            
        var normalizePath = path.Replace('/', '\\');

        var lastIndex = normalizePath.LastIndexOf('\\');
        if (lastIndex < 0)
            return path;
        return path.Substring(lastIndex + 1);
    }
    #endregion

    #endregion
}