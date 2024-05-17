using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] GameObject[] OnePieces;
    [SerializeField] GameObject[] TwoPieces;
    [SerializeField] GameObject[] ThreePieces;
    [SerializeField] Boolean isFirstUsed, isSecondUsed, isThirdUsed;
    [SerializeField] GameObject firstPiece, SecondPiece, ThirdPiece;
    [SerializeField] GameObject firstSpawn, SecondSpawn, ThirdSpawn;
    int WhichSize1, WhichSize2, WhichSize3;

    // Start is called before the first frame update
    void Start()
    {
        generateNewBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFirstUsed && isSecondUsed && isThirdUsed)
        {
            generateNewBlocks();
        }
        else
        {
            
            if ((WhichSize1 == 0 && !isFirstUsed && firstPiece.GetComponent<OnePiece>().Thrown) || (WhichSize1 == 1 && !isFirstUsed && firstPiece.GetComponent<TwoPiecesManager>().Thrown) || (WhichSize1 == 2 && !isFirstUsed && firstPiece.GetComponent<ThreePiecesManager>().Thrown))
            {
                isFirstUsed = true;
            }
            if ((WhichSize2 == 0 && !isSecondUsed && SecondPiece.GetComponent<OnePiece>().Thrown) || (WhichSize2 == 1 && !isSecondUsed && SecondPiece.GetComponent<TwoPiecesManager>().Thrown) || (WhichSize2 == 2 && !isSecondUsed && SecondPiece.GetComponent<ThreePiecesManager>().Thrown))
            {
                isSecondUsed = true;
            }
            if ((WhichSize3 == 0 && !isThirdUsed && ThirdPiece.GetComponent<OnePiece>().Thrown) || (WhichSize3 == 1 && !isThirdUsed && ThirdPiece.GetComponent<TwoPiecesManager>().Thrown) || (WhichSize3 == 2 && !isThirdUsed && ThirdPiece.GetComponent<ThreePiecesManager>().Thrown))
            {
                isThirdUsed = true;
            }
        }  
    }

    void generateNewBlocks()
    {
        isFirstUsed = false;
        isSecondUsed = false;
        isThirdUsed = false;
        WhichSize1 = UnityEngine.Random.Range(0, 3);
        WhichSize2 = UnityEngine.Random.Range(0, 3);
        WhichSize3 = UnityEngine.Random.Range(0, 3);


        if (WhichSize1 == 0)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, OnePieces.Length);
            firstPiece = Instantiate(OnePieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<OnePiece>().home = firstSpawn.transform.position;
        }
        if (WhichSize1 == 1)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, TwoPieces.Length);
            firstPiece = Instantiate(TwoPieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<TwoPiecesManager>().home = firstSpawn.transform.position;
        }
        if (WhichSize1 == 2)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, ThreePieces.Length);
            firstPiece = Instantiate(ThreePieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<ThreePiecesManager>().home = firstSpawn.transform.position;
        }

        if (WhichSize2 == 0)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, OnePieces.Length);
            SecondPiece = Instantiate(OnePieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<OnePiece>().home = SecondSpawn.transform.position;
        }
        if (WhichSize2 == 1)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, TwoPieces.Length);
            SecondPiece = Instantiate(TwoPieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<TwoPiecesManager>().home = SecondSpawn.transform.position;
        }
        if (WhichSize2 == 2)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, ThreePieces.Length);
            SecondPiece = Instantiate(ThreePieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<ThreePiecesManager>().home = SecondSpawn.transform.position;
        }

        if (WhichSize3 == 0)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, OnePieces.Length);
            ThirdPiece = Instantiate(OnePieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<OnePiece>().home = ThirdSpawn.transform.position;
        }
        if (WhichSize3 == 1)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, TwoPieces.Length);
            ThirdPiece = Instantiate(TwoPieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<TwoPiecesManager>().home = ThirdSpawn.transform.position;
        }
        if (WhichSize3 == 2)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, ThreePieces.Length);
            ThirdPiece = Instantiate(ThreePieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<ThreePiecesManager>().home = ThirdSpawn.transform.position;
        }
    }
}
