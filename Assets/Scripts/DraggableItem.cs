using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent;
    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
<<<<<<< HEAD
        transform.SetParent(transform.root);
=======
<<<<<<< HEAD
        transform.SetParent(transform.root);
=======
        transform.SetParent(transform.root); // Чтобы не ограничивался слотом
>>>>>>> 0761fa78143ec1e122dc195c262e5474873699b1
>>>>>>> c055c086984d5a49df20ee23e9beb4a2b8383115
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

<<<<<<< HEAD
        
=======
<<<<<<< HEAD
=======
        // Если не сброшен в слот — вернём обратно
>>>>>>> 0761fa78143ec1e122dc195c262e5474873699b1
>>>>>>> c055c086984d5a49df20ee23e9beb4a2b8383115
        if (transform.parent == transform.root)
        {
            transform.SetParent(originalParent);
            transform.localPosition = Vector3.zero;
        }
    }
}
