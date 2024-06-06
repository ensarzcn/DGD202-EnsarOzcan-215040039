using UnityEngine;


//It allows the inventory to be opened and closed when the E key is pressed.

public class InventoryPanelController : MonoBehaviour
{
    public GameObject inventoryPanel;  

    private bool isPanelActive = false;

    void Update()
    {
        // E tu�una bas�ld���nda panelin g�r�n�rl���n� de�i�tir
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPanelActive = !isPanelActive;
            inventoryPanel.SetActive(isPanelActive);
        }
    }
}
