using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private GameObject marker;

    private Decor selected = null;

    public Vector3 center = Vector3.zero;

    void Start()
    {
        marker.SetActive(false);
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            HandleSelection();
        }

        MarkerHandling(); //ABSTRACION
        PanelHandling(); 
    }

    private void LateUpdate()
    {
        transform.RotateAround(center, -Vector3.up, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(-1, 0, 0) * Input.GetAxis("Vertical") * rotateSpeed * Time.deltaTime);

    }
    public void HandleSelection() //ABSTRACTION
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            var unit = hit.collider.GetComponent<Decor>();
            selected = unit;
            if (selected == null) return;
            UIManager.Instance.SetSelected(selected);
            UIManager.Instance.ShowColor(selected.GetColor());

            if (selected.tag == "Thing") UIManager.Instance.DeactivateInteractionButton();
            else UIManager.Instance.ActivateInteractionButton();
        }

    }

    void MarkerHandling()
    {
        if (selected == null && marker.activeInHierarchy)
        {
            marker.SetActive(false);
            marker.transform.SetParent(null);
        }
        else if (selected != null && marker.transform.parent != selected.transform)
        {
            marker.SetActive(true);
            marker.transform.SetParent(selected.transform, false);
            marker.transform.localPosition = Vector3.zero;
        }
    }

    void PanelHandling()
    {
        if (selected == null)
        {
            UIManager.Instance.HidePanel();
        }
        else if (selected != null)
        {
            UIManager.Instance.ShowPanel();
            selected.SetColor(UIManager.Instance.GetColor());
        }
    }

}
