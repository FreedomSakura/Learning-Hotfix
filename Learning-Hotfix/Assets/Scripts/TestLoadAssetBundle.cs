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
        // ������Դ
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/ui.unity3d");

        if (assetBundle != null)
        {
            Debug.Log("���سɹ���");

            // ���ص�����Դ
            GameObject obj = assetBundle.LoadAsset<GameObject>("TestPanel");
            Instantiate(obj);

            // ���ظ���Դ����������Դ����multi sprite��
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
