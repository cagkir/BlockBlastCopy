using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FivePiecesManager : MonoBehaviour
{
    Vector3 mousePosition;

    RaycastHit raycastHitFirst;
    RaycastHit raycastHitSecond;
    RaycastHit raycastHitThird;
    RaycastHit raycastHitFourth;
    RaycastHit raycastHitFifth;

    float smoothTime = 0.1f;
    Vector3 velocity = Vector3.zero;
    public Vector3 home = new Vector3(0, -3.5f, -4);
    [SerializeField] float distance;
    [SerializeField] LayerMask lm;

    [SerializeField] Boolean isOkeyFirst;
    [SerializeField] Boolean isOkeySecond;
    [SerializeField] Boolean isOkeyThird;
    [SerializeField] Boolean isOkeyFourth;
    [SerializeField] Boolean isOkeyFifth;
    [SerializeField] Boolean isOkeyAll;
    [SerializeField] public Boolean Thrown;
    [SerializeField] Boolean rayControl, turnBack;
    [SerializeField] GameObject child1, child2, child3, child4, child5;

    GameObject a1, b1, a2, b2, a3, b3, a4, b4, a5, b5;
    int color;
    [SerializeField] Sprite blue, cyan, green, orange, purple, red, yellow;
    [SerializeField] Boolean atHome = true;


    GameObject Manager;
    GameObject LineManager;
    private void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
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
            if (Physics.Raycast(child1.transform.position, Vector3.forward, out raycastHitFirst, distance, lm))
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



            if (Physics.Raycast(child2.transform.position, Vector3.forward, out raycastHitSecond, distance, lm))
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



            if (Physics.Raycast(child3.transform.position, Vector3.forward, out raycastHitThird, distance, lm))
            {
                isOkeyThird = true;
                b3 = raycastHitThird.transform.gameObject;

                if (a3 == null)
                {
                    a3 = raycastHitThird.transform.gameObject;
                }
                if (a3 == b3)
                {
                    //still same object
                }
                if (a3 != b3)
                {
                    a3.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                    a3 = b3;
                }
            }
            else
            {
                isOkeyThird = false;
            }



            if (Physics.Raycast(child4.transform.position, Vector3.forward, out raycastHitFourth, distance, lm))
            {
                isOkeyFourth = true;
                b4 = raycastHitFourth.transform.gameObject;

                if (a4 == null)
                {
                    a4 = raycastHitFourth.transform.gameObject;
                }
                if (a4 == b4)
                {
                    //still same object
                }
                if (a4 != b4)
                {
                    a4.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                    a4 = b4;
                }
            }
            else
            {
                isOkeyFourth = false;
            }



            if (Physics.Raycast(child5.transform.position, Vector3.forward, out raycastHitFifth, distance, lm))
            {
                isOkeyFifth = true;
                b5 = raycastHitFifth.transform.gameObject;

                if (a5 == null)
                {
                    a5 = raycastHitFifth.transform.gameObject;
                }
                if (a5 == b5)
                {
                    //still same object
                }
                if (a5 != b5)
                {
                    a5.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                    a5 = b5;
                }
            }
            else
            {
                isOkeyFifth = false;
            }



            if (isOkeyFirst && isOkeySecond && isOkeyThird && isOkeyFourth && isOkeyFifth)
            {
                isOkeyAll = true;
                if (color == 1)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = blue;
                }
                if (color == 2)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = cyan;
                }
                if (color == 3)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = green;
                }
                if (color == 4)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = orange;
                }
                if (color == 5)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = purple;
                }
                if (color == 6)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = red;
                }
                if (color == 7)
                {
                    raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                    raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                    raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                    raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                    raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = yellow;
                }
                raycastHitFirst.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                raycastHitSecond.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                raycastHitThird.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                raycastHitFourth.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
                raycastHitFifth.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                isOkeyAll = false;
                if (a1 != null)
                {
                    a1.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                }
                if (a2 != null)
                {
                    a2.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                }
                if (a3 != null)
                {
                    a3.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                }
                if (a4 != null)
                {
                    a4.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                }
                if (a5 != null)
                {
                    a5.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
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
        if (!isOkeyAll)
        {
            turnBack = true;
            GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
        }
        if (isOkeyAll)
        {
            Thrown = true;
            
            Manager.GetComponent<Manager>().points += 50;
            child1.transform.SetParent(raycastHitFirst.collider.gameObject.transform);
            child2.transform.SetParent(raycastHitSecond.collider.gameObject.transform);
            child3.transform.SetParent(raycastHitThird.collider.gameObject.transform);
            child4.transform.SetParent(raycastHitFourth.collider.gameObject.transform);
            child5.transform.SetParent(raycastHitFifth.collider.gameObject.transform);
            raycastHitFirst.collider.gameObject.layer = 6;
            raycastHitSecond.collider.gameObject.layer = 6;
            raycastHitThird.collider.gameObject.layer = 6;
            raycastHitFourth.collider.gameObject.layer = 6;
            raycastHitFifth.collider.gameObject.layer = 6;
            child1.transform.localPosition = new Vector3(0, 0, -1);
            child2.transform.localPosition = new Vector3(0, 0, -1);
            child3.transform.localPosition = new Vector3(0, 0, -1);
            child4.transform.localPosition = new Vector3(0, 0, -1);
            child5.transform.localPosition = new Vector3(0, 0, -1);
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject.GetComponent<FivePiecesManager>());
            Manager.GetComponent<Manager>().Generated = true;
            LineManager.GetComponent<LineManager>().toScan = true;
        }
    }

    void turnBackHome()
    {
        if (transform.position != home)
        {
            transform.position = Vector3.SmoothDamp(transform.position, home, ref velocity, smoothTime);
            if (b1 != null)
            {
                b1.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            }
            if (b2 != null)
            {
                b2.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            }
            if (b3 != null)
            {
                b3.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            }
            if (b4 != null)
            {
                b4.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
            }
            if (b5 != null)
            {
                b5.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
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
