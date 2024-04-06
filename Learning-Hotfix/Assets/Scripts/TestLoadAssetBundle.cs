using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoadAssetBundle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle assetBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/ui.unity3d");

        if (assetBundle != null)
        {
            Debug.Log("º”‘ÿ≥…π¶£°");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
