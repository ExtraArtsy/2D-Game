using UnityEngine;

public class FPSManipulator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int targetFPS = 24;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFPS;
    }
}
