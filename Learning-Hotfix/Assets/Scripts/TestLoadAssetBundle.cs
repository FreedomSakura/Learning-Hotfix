using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadAssetBundle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// 加载依赖
        AssetBundle dependon = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/StreamingAssets");
        AssetBundleManifest assetBundleManifest = dependon.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        // 加载目标ab包的所有依赖
        string[] uiDependencies = assetBundleManifest.GetAllDependencies("ui.unity3d");
        foreach (string dependency in uiDependencies)
        {
            AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/" + dependency);
        }

        // 加载资源
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/ui.unity3d");

        if (assetBundle != null)
        {
            Debug.Log("加载成功！");

            // 加载单个资源
            GameObject obj = assetBundle.LoadAsset<GameObject>("TestPanel");
            Instantiate(obj);

            //// 加载该资源的所有子资源（如multi sprite）
            //Sprite[] sprites = assetBundle.LoadAssetWithSubAssets<Sprite>("TestMulti");
            //foreach(var sprite in sprites)
            //{
            //    Debug.Log(sprite);
            //}
          
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
