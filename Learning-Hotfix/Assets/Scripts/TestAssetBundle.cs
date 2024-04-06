using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class TestAssetBundle : MonoBehaviour
{
    [MenuItem("AssetBundle/Build Windows")]
    static void BuildAssetBundle()
    {
        string outPath = Application.streamingAssetsPath;

        if (!Directory.Exists(outPath))
        {
            Directory.CreateDirectory(outPath);
        }

        BuildPipeline.BuildAssetBundles(outPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
