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

        List<AssetBundleBuild> builds = new List<AssetBundleBuild>();

        AssetBundleBuild build = new AssetBundleBuild();
        build.assetBundleName = "ui";
        build.assetBundleVariant = "unity3d";
        build.assetNames = new string[] { "Assets/Art/Prefabs/TestPanel.prefab", "Assets/Art/Textures/Tools/TestMulti.png"};

        AssetBundleBuild buildScene = new AssetBundleBuild();
        buildScene.assetBundleName = "Scene";
        buildScene.assetBundleVariant = "unity3d";
        buildScene.assetNames = new string[] { "Assets/Scenes/Start.unity",  };

        builds.Add(build);
        builds.Add(buildScene);

        BuildPipeline.BuildAssetBundles(outPath, builds.ToArray(), BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
