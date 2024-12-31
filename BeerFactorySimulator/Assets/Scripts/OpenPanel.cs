using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    private void OnEnable()
    {
        AllRaycast.OnRayPC += _OpenPanel;
    }

    private void OnDisable()
    {
        AllRaycast.OnRayPC -= _OpenPanel;
    }

    private void _OpenPanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
        Cursor.lockState = CursorLockMode.None;   
    }
}
