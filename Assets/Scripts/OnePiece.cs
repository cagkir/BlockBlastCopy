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
    public float smoothTime = 0.1f;
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
    [SerializeField] Boolean atHome = true;


    GameObject Manager;
    GameObject LineManager;
    private void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(0.435f, 0.435f, 0);
        Manager = GameObject.FindGameObjectWithTag("Manager");
        LineManager = GameObject.FindGameObjectWithTag("LineManager");
    }
    private void Update()
    {
        if (!atHome)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }

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
                
            }
            else
            {
                isOkey = false;
                if(a != null)
                {
                    a.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        }
        if (turnBack)
        {
            turnBackHome();
            rayControl = false;
        }
    }
    private void OnMouseDrag()
    {
        GetComponent<Transform>().localScale = new Vector3(0.87f, 0.87f, 0);
        if (this.gameObject.tag == "Blue")
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
            GetComponent<Transform>().localScale = new Vector3(0.435f, 0.435f, 0);
        }
        if (isOkey)
        {
            Thrown = true;
            
            Manager.GetComponent<Manager>().points += 10;
            transform.SetParent(raycastHit3D.collider.gameObject.transform);
            raycastHit3D.collider.gameObject.layer = 6;
            transform.localPosition = new Vector3(0, 0, -1);
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject.GetComponent<OnePiece>());
            Manager.GetComponent<Manager>().Generated = true;
            LineManager.GetComponent<LineManager>().toScan = true;
        }
    }
    private void turnBackHome()
    {
        if (transform.position != home)
        {
            transform.position = Vector3.SmoothDamp(transform.position, home, ref velocity, smoothTime);
            if(b != null)
            {
                b.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            }   
            atHome = false;
        }
        else
        {
            turnBack = false;
            atHome = true;
        }
    }
}
