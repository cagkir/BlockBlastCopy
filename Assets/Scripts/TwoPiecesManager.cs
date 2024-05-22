using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class TwoPiecesManager : MonoBehaviour
{
    Vector3 mousePosition;

    RaycastHit raycastHitFirst;
    RaycastHit raycastHitSecond;

    float smoothTime = 0.1f;
    Vector3 velocity = Vector3.zero;
    public Vector3 home = new Vector3(0, -3.5f, -4);
    [SerializeField] float distance;
    [SerializeField] LayerMask lm;

    [SerializeField] Boolean isOkeyFirst;
    [SerializeField] Boolean isOkeySecond;
    [SerializeField] public Boolean isOkeyBoth;
    [SerializeField] public Boolean Thrown;
    [SerializeField] public Boolean rayControl, turnBack;
    [SerializeField] public GameObject child1, child2;

    GameObject a1, b1, a2, b2;
    int color;
    [SerializeField] Sprite blue, cyan, green, orange, purple, red, yellow;
    [SerializeField] Boolean atHome = true;


    GameObject Manager;
    GameObject LineManager;

    private void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(0.5f,0.5f,0);
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
            if(Physics.Raycast(child1.transform.position, Vector3.forward, out raycastHitFirst, distance, lm))
            {
                isOkeyFirst = true;
                b1 = raycastHitFirst.transform.gameObject;

                if (a1 == null)
                {
                    a1 = raycastHitFirst.transform.gameObject;
                }
                if (a1 == b1)
                {
                    //still same object
                }
                if (a1 != b1)
                {
                    a1.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                    a1 = b1;
                }
            }
            else
            {
                isOkeyFirst = false;
            }



            if(Physics.Raycast(child2.transform.position, Vector3.forward, out raycastHitSecond, distance, lm))
            {
                isOkeySecond = true;
                b2 = raycastHitSecond.transform.gameObject;

                if (a2 == null)
                {
                    a2 = raycastHitSecond.transform.gameObject;
                }
                if (a2 == b2)
                {
                    //still same object
                }
                if (a2 != b2)
                {
                    a2.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                    a2 = b2;
                }
            }
            else
            {
                isOkeySecond = false;
            }



            if(isOkeyFirst && isOkeySecond)
            {
                isOkeyBoth = true;
                if (color == 1)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                }
                if (color == 2)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                }
                if (color == 3)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                }
                if (color == 4)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                }
                if (color == 5)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                }
                if (color == 6)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                }
                if (color == 7)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                }
                raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                isOkeyBoth = false;
                if (a1 != null)
                {
                    a1.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                }
                if (a2 != null)
                {
                    a2.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
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
        GetComponent<Transform>().localScale = new Vector3(1f, 1f, 0);
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
        if (!isOkeyBoth)
        {
            turnBack = true;
            GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
        }
        if (isOkeyBoth)
        {
            Thrown = true;
            
            Manager.GetComponent<Manager>().points += 20;
            child1.transform.SetParent(raycastHitFirst.collider.gameObject.transform);
            child2.transform.SetParent(raycastHitSecond.collider.gameObject.transform);
            raycastHitFirst.collider.gameObject.layer = 6;
            raycastHitSecond.collider.gameObject.layer = 6;
            child1.transform.localPosition = new Vector3(0, 0, -1);
            child2.transform.localPosition = new Vector3(0, 0, -1);
            GetComponent<BoxCollider2D>().enabled = false;

            Destroy(gameObject.GetComponent<TwoPiecesManager>());
            Manager.GetComponent<Manager>().Generated = true;
            LineManager.GetComponent<LineManager>().toScan = true;

        }
    }

    void turnBackHome()
    {
        if (transform.position != home)
        {
            transform.position = Vector3.SmoothDamp(transform.position, home, ref velocity, smoothTime);
            if(b1 != null)
            {
                b1.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            }
            if (b2 != null)
            {
                b2.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
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
