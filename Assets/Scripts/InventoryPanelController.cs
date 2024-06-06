using UnityEngine;


//It allows the inventory to be opened and closed when the E key is pressed.

public class InventoryPanelController : MonoBehaviour
{
    public GameObject inventoryPanel;  

    private bool isPanelActive = false;

    void Update()
    {
        // E tuþuna basýldýðýnda panelin görünürlüðünü deðiþtir
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPanelActive = !isPanelActive;
            inventoryPanel.SetActive(isPanelActive);
        }
    }
}
