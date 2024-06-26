using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsGameEnded : MonoBehaviour
{
    public GameObject firstObj, secondObj, thirdObj;


    [SerializeField] GameObject[] all;
    public LayerMask layerMask;

    int toControl21 = 0, toControl22 = 0, toControl23 = 0;
    int toControl31 = 0, toControl32 = 0, toControl33 = 0;
    int toControl41 = 0, toControl42 = 0, toControl43 = 0;
    int toControl51 = 0, toControl52 = 0, toControl53 = 0;
    int toControl61 = 0, toControl62 = 0, toControl63 = 0;
    int toControl91 = 0, toControl92 = 0, toControl93 = 0;

    Boolean ToControl21 = false, ToControl22 = false, ToControl23 = false;
    Boolean ToControl31 = false, ToControl32 = false, ToControl33 = false;
    Boolean ToControl41 = false, ToControl42 = false, ToControl43 = false;
    Boolean ToControl51 = false, ToControl52 = false, ToControl53 = false;
    Boolean ToControl61 = false, ToControl62 = false, ToControl63 = false;
    Boolean ToControl91 = false, ToControl92 = false, ToControl93 = false;

    Boolean gameEnd1 = false, gameEnd2 = false, gameEnd3 = false;
    Boolean gameEndAll = false;
    float GameEnd = 0;
    [SerializeField] GameObject loadUI, loadUI2;

    public GameObject lineManager;

    private void Update()
    {

        if (GetComponent<Manager>().Generated)
        {
            firstObj = GetComponent<Manager>().firstPiece;
            secondObj = GetComponent<Manager>().SecondPiece;
            thirdObj = GetComponent<Manager>().ThirdPiece;

            /*if (firstObj != null && !firstObj.GetComponent<OnePiece>().Thrown)
            {
                //FIRST OBJECT
                Debug.Log("np1");
            }
            if(secondObj != null && !secondObj.GetComponent<OnePiece>().Thrown)
            {
                //SECOND OBJECT
                Debug.Log("np2");
            }
            if (thirdObj != null && !thirdObj.GetComponent<OnePiece>().Thrown)
            {
                //THIRDOBJECT
                Debug.Log("np3");
            }*/

            if (firstObj.GetComponent<TwoPiecesManager>() != null && !firstObj.GetComponent<TwoPiecesManager>().Thrown)
            {
                //FIRST OBJECT
                ToControl21 = false;
                firstObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    firstObj.transform.position = item.transform.position + new Vector3(0f, 0f, -1);
                    toControl21 = 0;
                    for (int i = 0; i < firstObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(firstObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl21 += 1;
                                if (toControl21 == 2)
                                {
                                    ToControl21 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                firstObj.transform.position = GetComponent<Manager>().firstSpawn.transform.position + new Vector3(0, 0, -4);
                firstObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl21)
                {
                    Debug.Log("np1");
                    gameEnd1 = false;
                }
                else
                {
                    Debug.Log("problem1");
                    gameEnd1 = true;
                }
                ToControl21 = false;
            }
            if(secondObj.GetComponent<TwoPiecesManager>() != null && !secondObj.GetComponent<TwoPiecesManager>().Thrown)
            {
                //SECOND OBJECT
                ToControl22 = false;
                secondObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    secondObj.transform.position = item.transform.position + new Vector3(0f, 0f, -1);
                    toControl22 = 0;
                    for (int i = 0; i < secondObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(secondObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl22 += 1;
                                if (toControl22 == 2)
                                {
                                    ToControl22 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                secondObj.transform.position = GetComponent<Manager>().SecondSpawn.transform.position + new Vector3(0, 0, -4);
                secondObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl22)
                {
                    Debug.Log("np2");
                    gameEnd2 = false;
                }
                else
                {
                    Debug.Log("problem2");
                    gameEnd2 = true;
                }
                ToControl22 = false;
            }
            if(thirdObj.GetComponent<TwoPiecesManager>() != null && !thirdObj.GetComponent<TwoPiecesManager>().Thrown)
            {

                //THIRDOBJECT
                ToControl23 = false;
                thirdObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    thirdObj.transform.position = item.transform.position + new Vector3(0f, 0f, -1);
                    toControl23 = 0;
                    for (int i = 0; i < thirdObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(thirdObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl23 += 1;
                                if (toControl23 == 2)
                                {
                                    ToControl23 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                thirdObj.transform.position = GetComponent<Manager>().ThirdSpawn.transform.position + new Vector3(0, 0, -4);
                thirdObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl23)
                {
                    Debug.Log("np3");
                    gameEnd3 = false;
                }
                else
                {
                    Debug.Log("problem3");
                    gameEnd3 = true;
                }
                ToControl23 = false;
            }

            if (firstObj.GetComponent<ThreePiecesManager>() != null && !firstObj.GetComponent<ThreePiecesManager>().Thrown)
            {
                //FIRST OBJECT
                ToControl31 = false;
                firstObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    firstObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl31 = 0;
                    for (int i = 0; i < firstObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(firstObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl31 += 1;
                                if (toControl31 == 3)
                                {
                                    ToControl31 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                firstObj.transform.position = GetComponent<Manager>().firstSpawn.transform.position + new Vector3(0, 0, -4);
                firstObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl31)
                {
                    Debug.Log("np1");
                    gameEnd1 = false;
                }
                else
                {
                    Debug.Log("problem1");
                    gameEnd1 = true;
                }
                ToControl31 = false;
            }
            if(secondObj.GetComponent<ThreePiecesManager>() != null && !secondObj.GetComponent<ThreePiecesManager>().Thrown)
            {
                //SECOND OBJECT
                ToControl32 = false;
                secondObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    secondObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl32 = 0;
                    for (int i = 0; i < secondObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(secondObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl32 += 1;
                                if (toControl32 == 3)
                                {
                                    ToControl32 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                secondObj.transform.position = GetComponent<Manager>().SecondSpawn.transform.position + new Vector3(0, 0, -4);
                secondObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl32)
                {
                    Debug.Log("np2");
                    gameEnd2 = false;
                }
                else
                {
                    Debug.Log("problem2");
                    gameEnd2 = true;
                }
                ToControl32 = false;
            }
            if(thirdObj.GetComponent<ThreePiecesManager>() != null && !thirdObj.GetComponent<ThreePiecesManager>().Thrown)
            {
                //THIRDOBJECT
                ToControl33 = false;
                thirdObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    thirdObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl33 = 0;
                    for (int i = 0; i < thirdObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(thirdObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl33 += 1;
                                if (toControl33 == 3)
                                {
                                    ToControl33 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                thirdObj.transform.position = GetComponent<Manager>().ThirdSpawn.transform.position + new Vector3(0, 0, -4);
                thirdObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl33)
                {
                    Debug.Log("np3");
                    gameEnd3 = false;
                }
                else
                {
                    Debug.Log("problem3");
                    gameEnd3 = true;
                }
                ToControl33 = false;
            }

            if (firstObj.GetComponent<FourPiecesManager>() != null && !firstObj.GetComponent<FourPiecesManager>().Thrown)
            {
                //FIRST OBJECT
                ToControl41 = false;
                firstObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    firstObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl41 = 0;
                    for (int i = 0; i < firstObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(firstObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl41 += 1;
                                if (toControl41 == 4)
                                {
                                    ToControl41 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                firstObj.transform.position = GetComponent<Manager>().firstSpawn.transform.position + new Vector3(0, 0, -4);
                firstObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl41)
                {
                    Debug.Log("np1");
                    gameEnd1 = false;
                }
                else
                {
                    Debug.Log("problem1");
                    gameEnd1 = true;
                }
                ToControl41 = false;
            }
            if (secondObj.GetComponent<FourPiecesManager>() != null && !secondObj.GetComponent<FourPiecesManager>().Thrown)
            {
                //SECOND OBJECT
                ToControl42 = false;
                secondObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    secondObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl42 = 0;
                    for (int i = 0; i < secondObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(secondObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl42 += 1;
                                if (toControl42 == 4)
                                {
                                    ToControl42 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                secondObj.transform.position = GetComponent<Manager>().SecondSpawn.transform.position + new Vector3(0, 0, -4);
                secondObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl42)
                {
                    Debug.Log("np2");
                    gameEnd2 = false;
                }
                else
                {
                    Debug.Log("problem2");
                    gameEnd2 = true;
                }
                ToControl42 = false;
            }
            if (thirdObj.GetComponent<FourPiecesManager>() != null && !thirdObj.GetComponent<FourPiecesManager>().Thrown)
            {
                //THIRD OBJECT
                ToControl43 = false;
                thirdObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    thirdObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl43 = 0;
                    for (int i = 0; i < thirdObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(thirdObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl43 += 1;
                                if (toControl43 == 4)
                                {
                                    ToControl43 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                thirdObj.transform.position = GetComponent<Manager>().ThirdSpawn.transform.position + new Vector3(0, 0, -4);
                thirdObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl43)
                {
                    Debug.Log("np3");
                    gameEnd3 = false;
                }
                else
                {
                    Debug.Log("problem3");
                    gameEnd3 = true;
                }
                ToControl43 = false;
            }

            if (firstObj.GetComponent<FivePiecesManager>() != null && !firstObj.GetComponent<FivePiecesManager>().Thrown)
            {
                //FIRST OBJECT
                ToControl51 = false;
                firstObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    firstObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl51 = 0;
                    for (int i = 0; i < firstObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(firstObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl51 += 1;
                                if (toControl51 == 5)
                                {
                                    ToControl51 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                firstObj.transform.position = GetComponent<Manager>().firstSpawn.transform.position + new Vector3(0, 0, -4);
                firstObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl51)
                {
                    Debug.Log("np1");
                    gameEnd1 = false;
                }
                else
                {
                    Debug.Log("problem1");
                    gameEnd1 = true;
                }
                ToControl51 = false;
            }
            if (secondObj.GetComponent<FivePiecesManager>() != null && !secondObj.GetComponent<FivePiecesManager>().Thrown)
            {
                //SECOND OBJECT
                ToControl52 = false;
                secondObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    secondObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl52 = 0;
                    for (int i = 0; i < secondObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(secondObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl52 += 1;
                                if (toControl52 == 5)
                                {
                                    ToControl52 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                secondObj.transform.position = GetComponent<Manager>().SecondSpawn.transform.position + new Vector3(0, 0, -4);
                secondObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl52)
                {
                    Debug.Log("np2");
                    gameEnd2 = false;
                }
                else
                {
                    Debug.Log("problem2");
                    gameEnd2 = true;
                }
                ToControl52 = false;
            }
            if (thirdObj.GetComponent<FivePiecesManager>() != null && !thirdObj.GetComponent<FivePiecesManager>().Thrown)
            {
                //THIRD OBJECT
                ToControl53 = false;
                thirdObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    thirdObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl53 = 0;
                    for (int i = 0; i < thirdObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(thirdObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl53 += 1;
                                if (toControl53 == 5)
                                {
                                    ToControl53 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                thirdObj.transform.position = GetComponent<Manager>().ThirdSpawn.transform.position + new Vector3(0, 0, -4);
                thirdObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl53)
                {
                    Debug.Log("np3");
                    gameEnd3 = false;
                }
                else
                {
                    Debug.Log("problem3");
                    gameEnd3 = true;
                }
                ToControl53 = false;
            }

            if (firstObj.GetComponent<SixPiecesManager>() != null && !firstObj.GetComponent<SixPiecesManager>().Thrown)
            {
                //FIRST OBJECT
                ToControl61 = false;
                firstObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    firstObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl61 = 0;
                    for (int i = 0; i < firstObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(firstObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl61 += 1;
                                if (toControl61 == 6)
                                {
                                    ToControl61 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                firstObj.transform.position = GetComponent<Manager>().firstSpawn.transform.position + new Vector3(0, 0, -4);
                firstObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl61)
                {
                    Debug.Log("np1");
                    gameEnd1 = false;
                }
                else
                {
                    Debug.Log("problem1");
                    gameEnd1 = true;
                }
                ToControl61 = false;
            }
            if(secondObj.GetComponent<SixPiecesManager>() != null && !secondObj.GetComponent<SixPiecesManager>().Thrown)
            {
                //SECOND OBJECT
                ToControl62 = false;
                secondObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    secondObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl62 = 0;
                    for (int i = 0; i < secondObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(secondObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl62 += 1;
                                if (toControl62 == 6)
                                {
                                    ToControl62 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                secondObj.transform.position = GetComponent<Manager>().SecondSpawn.transform.position + new Vector3(0, 0, -4);
                secondObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl62)
                {
                    Debug.Log("np2");
                    gameEnd2 = false;
                }
                else
                {
                    Debug.Log("problem2");
                    gameEnd2 = true;
                }
                ToControl62 = false;
            }
            if(thirdObj.GetComponent<SixPiecesManager>() != null && !thirdObj.GetComponent<SixPiecesManager>().Thrown)
            {
                //THIRD OBJECT
                ToControl63 = false;
                thirdObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    thirdObj.transform.position = item.transform.position + new Vector3(0, 0f, -1);
                    toControl63 = 0;
                    for (int i = 0; i < thirdObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(thirdObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl63 += 1;
                                if (toControl63 == 6)
                                {
                                    ToControl63 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                thirdObj.transform.position = GetComponent<Manager>().ThirdSpawn.transform.position + new Vector3(0, 0, -4);
                thirdObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl63)
                {
                    Debug.Log("np3");
                    gameEnd3 = false;
                }
                else
                {
                    Debug.Log("problem3");
                    gameEnd3 = true;
                }
                ToControl63 = false;
            }

            if (firstObj.GetComponent<NinePiecesManager>() != null && !firstObj.GetComponent<NinePiecesManager>().Thrown)
            {
                //FIRST OBJECT
                ToControl91 = false;
                firstObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    firstObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl91 = 0;
                    for (int i = 0; i < firstObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(firstObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl91 += 1;
                                if (toControl91 == 9)
                                {
                                    ToControl91 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                firstObj.transform.position = GetComponent<Manager>().firstSpawn.transform.position + new Vector3(0, 0, -4);
                firstObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl91)
                {
                    Debug.Log("np1");
                    gameEnd1 = false;
                }
                else
                {
                    Debug.Log("problem1");
                    gameEnd1 = true;
                }
                ToControl91 = false;
            }
            if (secondObj.GetComponent<NinePiecesManager>() != null && !secondObj.GetComponent<NinePiecesManager>().Thrown)
            {
                //SECOND OBJECT
                ToControl92 = false;
                secondObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    secondObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl92 = 0;
                    for (int i = 0; i < secondObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(secondObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl92 += 1;
                                if (toControl92 == 9)
                                {
                                    ToControl92 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                secondObj.transform.position = GetComponent<Manager>().SecondSpawn.transform.position + new Vector3(0, 0, -4);
                secondObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl92)
                {
                    Debug.Log("np2");
                    gameEnd2 = false;
                }
                else
                {
                    Debug.Log("problem2");
                    gameEnd2 = true;
                }
                ToControl92 = false;
            }
            if (thirdObj.GetComponent<NinePiecesManager>() != null && !thirdObj.GetComponent<NinePiecesManager>().Thrown)
            {
                //THIRD OBJECT
                ToControl93 = false;
                thirdObj.transform.localScale = new Vector3(1, 1, 0);
                foreach (var item in all)
                {
                    thirdObj.transform.position = item.transform.position + new Vector3(0, 0, -1);
                    toControl93 = 0;
                    for (int i = 0; i < thirdObj.transform.childCount; i++)
                    {
                        if (Physics.Raycast(thirdObj.transform.GetChild(i).transform.position, Vector3.forward, out RaycastHit hit, 5f, layerMask))
                        {
                            if (hit.collider != null)
                            {
                                //np
                                toControl93 += 1;
                                if (toControl93 == 9)
                                {
                                    ToControl93 = true;
                                }
                            }
                            else
                            {
                                //problem
                                break;
                            }
                        }
                    }
                }
                thirdObj.transform.position = GetComponent<Manager>().ThirdSpawn.transform.position + new Vector3(0, 0, -4);
                thirdObj.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0);
                if (ToControl93)
                {
                    Debug.Log("np3");
                    gameEnd3 = false;
                }
                else
                {
                    Debug.Log("problem3");
                    gameEnd3 = true;
                }
                ToControl93 = false;
            }
        }


        if (lineManager.GetComponent<LineManager>().scandone)
        {
            if (!GetComponent<Manager>().isFirstUsed && !GetComponent<Manager>().isSecondUsed && !GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd1 && gameEnd2 && gameEnd3)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
            if (!GetComponent<Manager>().isFirstUsed && GetComponent<Manager>().isSecondUsed && GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd1)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
            if (!GetComponent<Manager>().isFirstUsed && !GetComponent<Manager>().isSecondUsed && GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd1 && gameEnd2)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
            if (!GetComponent<Manager>().isFirstUsed && GetComponent<Manager>().isSecondUsed && !GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd1 && gameEnd3)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
            if (GetComponent<Manager>().isFirstUsed && !GetComponent<Manager>().isSecondUsed && GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd2)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
            if (GetComponent<Manager>().isFirstUsed && !GetComponent<Manager>().isSecondUsed && !GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd2 && gameEnd3)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
            if (GetComponent<Manager>().isFirstUsed && GetComponent<Manager>().isSecondUsed && !GetComponent<Manager>().isThirdUsed)
            {
                if (gameEnd3)
                {
                    Debug.Log("gameEnd");
                    gameEndAll = true;
                }
                else
                {
                    gameEndAll = false;
                }
            }
        }


        if (GameEnd >= 0.25f)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            gameEndAll = false;
            GameEnd = 0;
            // LOSE
            if(PlayerPrefs.GetInt("BestScore") < GetComponent<Manager>().points)
            {
                PlayerPrefs.SetInt("BestScore", GetComponent<Manager>().points);
                loadUI2.SetActive(true);
            }
            else
            {
                loadUI.SetActive(true);
            }
        }
    }

    private void FixedUpdate()
    {
        if (gameEndAll)
        {
            GameEnd += Time.deltaTime;
        }
    }

}
