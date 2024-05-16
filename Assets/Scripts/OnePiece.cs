using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class OnePiece : MonoBehaviour
{
    public Vector3 mousePosition; 
    [SerializeField] Boolean rayControl, turnBack;
    public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    public Vector3 home = new Vector3(0, -3.5f, -4);
    [SerializeField] float distance;
    [SerializeField] LayerMask lm;

    RaycastHit raycastHit3D;
    [SerializeField] Boolean isOkey;
    [SerializeField] public Boolean Thrown;

    GameObject a, b;
    int color;
    [SerializeField] Sprite blue,cyan,green,orange,purple,red,yellow;
    private void Update()
    {
        if (rayControl)
        {  
            if (Physics.Raycast(transform.position, Vector3.forward, out raycastHit3D, distance, lm))
            {
                isOkey = true;
                if(color == 1)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                }
                if (color == 2)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                }
                if (color == 3)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                }
                if (color == 4)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                }
                if (color == 5)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                }
                if (color == 6)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                }
                if (color == 7)
                {
                    raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                }

                raycastHit3D.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                

                b = raycastHit3D.transform.gameObject;
                if (a == null)
                {
                    a = raycastHit3D.transform.gameObject;
                }
                
                if (a == b)
                {
                    //obje hala ayný
                }
                if(a != b)
                {                  
                    //a.GetComponentInChildren<SpriteRenderer>().enabled = false;
                    a.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled=false;
                    a = b;                    
                }
                {
                    
                }
                
            }
            else
            {
                isOkey = false;
            }
        }
        if (turnBack)
        {
            turnBackHome();
        }
    }
    private void OnMouseDrag()
    {
        if(this.gameObject.tag == "Blue")
        {
            color = 1;
        }
        if (this.gameObject.tag == "Cyan")
        {
            color = 2;
        }
        if (this.gameObject.tag == "Green")
        {
            color = 3;
        }
        if (this.gameObject.tag == "Orange")
        {
            color = 4;
        }
        if (this.gameObject.tag == "Purple")
        {
            color = 5;
        }
        if (this.gameObject.tag == "Red")
        {
            color = 6;
        }
        if (this.gameObject.tag == "Yellow")
        {
            color = 7;
        }
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = -4;
        transform.position = mousePosition;
        rayControl = true;
    }
    private void OnMouseUp()
    {
        rayControl = false;
        if (!isOkey)
        {
            turnBack = true;
        }
        if (isOkey)
        {
            Thrown = true;
            transform.SetParent(raycastHit3D.collider.gameObject.transform);
            raycastHit3D.collider.gameObject.layer = 6;
            transform.localPosition = new Vector3(0, 0, -1);
            Destroy(gameObject.GetComponent<OnePiece>());
        }
    }
    private void turnBackHome()
    {
        if (transform.position != home)
        {
            transform.position = Vector3.SmoothDamp(transform.position, home, ref velocity, smoothTime);
            b.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            turnBack = false;
        }
    }
}
