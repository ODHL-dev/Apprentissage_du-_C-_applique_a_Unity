using UnityEngine;
using UnityEngine.InputSystem;
using Vuforia;

public class ArCamControl : MonoBehaviour
{
    private VuforiaBehaviour arCam;
    void Start()
    {
        arCam = GetComponent<VuforiaBehaviour>();
    }
  
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (arCam != null)
            {
                arCam.enabled = !arCam.enabled;
            }
        }
        
    }
}
