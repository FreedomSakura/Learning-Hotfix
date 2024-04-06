using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadAssetBundle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 加载资源
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/ui.unity3d");

        if (assetBundle != null)
        {
            Debug.Log("加载成功！");

            // 加载单个资源
            GameObject obj = assetBundle.LoadAsset<GameObject>("TestPanel");
            Instantiate(obj);

            // 加载该资源的所有子资源（如multi sprite）
            Sprite[] sprites = assetBundle.LoadAssetWithSubAssets<Sprite>("TestMulti");
            foreach(var sprite in sprites)
            {
                Debug.Log(sprite);
            }
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
