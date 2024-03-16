using UnityEngine;
using UnityEditor;
using System.IO;

public class ResourcesPathsPrinter : Editor
{
    [MenuItem("Tools/Print Resources Paths")]
    public static void PrintResourcesPaths()
    {
        string resourcesPath = Application.dataPath + "/Resources";
        PrintPathsRecursive(resourcesPath, "");
    }

    private static void PrintPathsRecursive(string directoryPath, string relativePath)
    {
        foreach (string filePath in Directory.GetFiles(directoryPath))
        {
            if (filePath.EndsWith(".meta")) continue;

            string relativeFilePath = Path.Combine(relativePath, Path.GetFileName(filePath));
            Debug.Log("Resource path: " + relativeFilePath.Replace("\\", "/"));
        }

        foreach (string subDirectory in Directory.GetDirectories(directoryPath))
        {
            string newRelativePath = Path.Combine(relativePath, Path.GetFileName(subDirectory));
            PrintPathsRecursive(subDirectory, newRelativePath);
        }
    }
}
