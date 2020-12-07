using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SceneDataScriptableObject data;

    public float loadAfterTime = 1f;
    
    public void LoadScene()
    {
        Invoke(nameof(Load), loadAfterTime);
    }

    private void Load()
    {
        var scene = data.sceneList[Random.Range(0, data.sceneList.Length)];
        SceneManager.LoadScene(scene.name);
    }
}
