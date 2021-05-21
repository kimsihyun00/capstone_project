using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("LineScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    private void SavePrefab()
    {
        string fileName = "Line";
        string path = "Asset/Resources/" + fileName + ".prefab";
        Object obj = UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);
        GameObject temp = Instantiate(obj) as GameObject;

        bool isSuccess = false;
        UnityEditor.PrefabUtility.SaveAsPrefabAsset(temp, path, out isSuccess);
        UnityEditor.AssetDatabase.Refresh();
        Debug.Log(isSuccess);
    }
}
