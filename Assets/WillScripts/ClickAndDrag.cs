using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickAndDrag : MonoBehaviour
{
    private Plane dragPlane;

    private Vector3 offset;

    private Camera myMainCamera;

    public string animalName;

    public string animalFact;

    public TextMeshProUGUI animalFactText;

    void Start()
    {
        myMainCamera = Camera.main; 
    }

    void OnMouseDown()
    {
        dragPlane = new Plane(myMainCamera.transform.forward, transform.position);
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        offset = transform.position - camRay.GetPoint(planeDist);

        animalFactText.text = animalFact.ToString();
    }

    void OnMouseDrag()
    {
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition);

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        transform.position = camRay.GetPoint(planeDist) + offset;
    }
}
