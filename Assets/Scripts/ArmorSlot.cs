using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ArmorSlot : MonoBehaviour, IDropHandler
{
<<<<<<< HEAD
    public string slotType;
=======
<<<<<<< HEAD
    public string slotType;
=======
    public string slotType; // "Helmet", "Chestplate", "Leggins", "Boots"
>>>>>>> 0761fa78143ec1e122dc195c262e5474873699b1
>>>>>>> c055c086984d5a49df20ee23e9beb4a2b8383115
    public Image armorDisplayImage;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();
        if (item != null && item.name.ToLower().Contains(slotType.ToLower()))
        {
            item.transform.SetParent(transform);
            item.transform.localPosition = Vector3.zero;

            ShowArmor(item.name);
        }
    }

    private void ShowArmor(string itemName)
    {
<<<<<<< HEAD
        string armorSpriteName = itemName.Replace("Icon", "");
=======
<<<<<<< HEAD
        string armorSpriteName = itemName.Replace("Icon", "");
=======
        string armorSpriteName = itemName.Replace("Icon", ""); // Например: DiamondHelmetIcon -> DiamondHelmet
>>>>>>> 0761fa78143ec1e122dc195c262e5474873699b1
>>>>>>> c055c086984d5a49df20ee23e9beb4a2b8383115
        Sprite armorSprite = Resources.Load<Sprite>(armorSpriteName);
        if (armorSprite != null)
        {
            armorDisplayImage.sprite = armorSprite;
            armorDisplayImage.enabled = true;
        }
    }

    public void RemoveArmor()
    {
        armorDisplayImage.sprite = null;
        armorDisplayImage.enabled = false;
    }
}
