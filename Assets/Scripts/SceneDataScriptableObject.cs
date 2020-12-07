using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneDataScriptableObject : ScriptableObject
{
    public SceneAsset[] sceneList;
}
