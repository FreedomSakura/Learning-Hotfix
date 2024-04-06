using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 加载场景
        AssetBundle assetBundleScene = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/scene.unity3d");
        if (assetBundleScene != null)
        {
            Debug.Log("加载场景");

            SceneManager.LoadScene("Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
