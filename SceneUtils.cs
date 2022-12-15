using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SceneUtils
{
    // This method loads a scene by its name
    public static void LoadScene(string sceneName)
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneName);
    }

    // This method unloads a scene by its name
    public static void UnloadScene(string sceneName)
    {
        // Unload the specified scene
        SceneManager.UnloadSceneAsync(sceneName);
    }
}
