using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // ���س���
        AssetBundle assetBundleScene = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/scene.unity3d");
        if (assetBundleScene != null)
        {
            Debug.Log("���س���");

            SceneManager.LoadScene("Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
