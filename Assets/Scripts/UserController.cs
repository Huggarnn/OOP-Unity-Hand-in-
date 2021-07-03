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
    public float offsetDistance = 8.0f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - center;
        marker.SetActive(false);     
    }

    public void HandleSelection()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 
        if(Physics.Raycast(ray, out hit))
        {
            var unit = hit.collider.GetComponent<Decor>();
            selected = unit;

            //var uiInfo = hit.collider.GetComponentInParent<UIManager.IUIInfoContent>();
           // UIManager.Instance.SetNewInfoContent(uiInfo); 
        }

    }

    public void HandleAction()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 
        if(Physics.Raycast(ray, out hit))
        {

            //make changes
        }
    }

    void Update()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        cam.transform.position = cam.transform.position + new Vector3(move.y, 0, -move.x) * rotateSpeed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection(); 
        }
        else if(selected != null && Input.GetMouseButtonDown(1))
        {
            HandleAction(); 
        }

        MarkerHandling(); 
    }

    void MarkerHandling()
    {
        if(selected == null && marker.activeInHierarchy)
        {
            marker.SetActive(false);
            marker.transform.SetParent(null); 
        }
        else if(selected != null && marker.transform.parent != selected.transform)
        {
            marker.SetActive(true);
            marker.transform.SetParent(selected.transform, false);
            marker.transform.localPosition = Vector3.zero; 
        }
    }
}
