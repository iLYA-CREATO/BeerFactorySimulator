using UnityEngine;

public class PanelController : MonoBehaviour
{
    public void OffTurnPanelCursor(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OffTurnPanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void TurnPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void OffPanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
