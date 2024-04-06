using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadAssetBundle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// ��������
        AssetBundle dependon = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/StreamingAssets");
        AssetBundleManifest assetBundleManifest = dependon.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        // ����Ŀ��ab������������
        string[] uiDependencies = assetBundleManifest.GetAllDependencies("ui.unity3d");
        foreach (string dependency in uiDependencies)
        {
            AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/" + dependency);
        }

        // ������Դ
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/ui.unity3d");

        if (assetBundle != null)
        {
            Debug.Log("���سɹ���");

            // ���ص�����Դ
            GameObject obj = assetBundle.LoadAsset<GameObject>("TestPanel");
            Instantiate(obj);

            //// ���ظ���Դ����������Դ����multi sprite��
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
