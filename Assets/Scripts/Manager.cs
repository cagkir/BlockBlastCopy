using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    int WhichSize1, WhichSize2, WhichSize3;
    [SerializeField] GameObject[] OnePieces;
    [SerializeField] GameObject[] TwoPieces;
    [SerializeField] GameObject[] ThreePieces;
    [SerializeField] GameObject[] FourPieces;
    [SerializeField] GameObject[] FivePieces;
    [SerializeField] GameObject[] SixPieces;
    [SerializeField] GameObject[] NinePieces;
    [SerializeField] Boolean isFirstUsed, isSecondUsed, isThirdUsed;
    [SerializeField] GameObject firstPiece, SecondPiece, ThirdPiece;
    [SerializeField] GameObject firstSpawn, SecondSpawn, ThirdSpawn;


    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    public int points = 0;
    public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        generateNewBlocks();
    }

    // Update is called once per frame
    void Update()
    {

        textMeshProUGUI.text = points.ToString();

        if (isFirstUsed && isSecondUsed && isThirdUsed)
        {
            generateNewBlocks();
        }
        else
        {
            
            if ((WhichSize1 == 0 && !isFirstUsed && firstPiece.GetComponent<OnePiece>().Thrown) || (WhichSize1 == 1 && !isFirstUsed && firstPiece.GetComponent<TwoPiecesManager>().Thrown) || (WhichSize1 == 2 && !isFirstUsed && firstPiece.GetComponent<ThreePiecesManager>().Thrown) || (WhichSize1 == 3 && !isFirstUsed && firstPiece.GetComponent<FourPiecesManager>().Thrown) || (WhichSize1 == 4 && !isFirstUsed && firstPiece.GetComponent<FivePiecesManager>().Thrown) || (WhichSize1 == 5 && !isFirstUsed && firstPiece.GetComponent<SixPiecesManager>().Thrown) || (WhichSize1 == 6 && !isFirstUsed && firstPiece.GetComponent<NinePiecesManager>().Thrown))
            {
                isFirstUsed = true;
            }
            if ((WhichSize2 == 0 && !isSecondUsed && SecondPiece.GetComponent<OnePiece>().Thrown) || (WhichSize2 == 1 && !isSecondUsed && SecondPiece.GetComponent<TwoPiecesManager>().Thrown) || (WhichSize2 == 2 && !isSecondUsed && SecondPiece.GetComponent<ThreePiecesManager>().Thrown) || (WhichSize2 == 3 && !isSecondUsed && SecondPiece.GetComponent<FourPiecesManager>().Thrown) || (WhichSize2 == 4 && !isSecondUsed && SecondPiece.GetComponent<FivePiecesManager>().Thrown) || (WhichSize2 == 5 && !isSecondUsed && SecondPiece.GetComponent<SixPiecesManager>().Thrown) || (WhichSize2 == 6 && !isSecondUsed && SecondPiece.GetComponent<NinePiecesManager>().Thrown))
            {
                isSecondUsed = true;
            }
            if ((WhichSize3 == 0 && !isThirdUsed && ThirdPiece.GetComponent<OnePiece>().Thrown) || (WhichSize3 == 1 && !isThirdUsed && ThirdPiece.GetComponent<TwoPiecesManager>().Thrown) || (WhichSize3 == 2 && !isThirdUsed && ThirdPiece.GetComponent<ThreePiecesManager>().Thrown) || (WhichSize3 == 3 && !isThirdUsed && ThirdPiece.GetComponent<FourPiecesManager>().Thrown) || (WhichSize3 == 4 && !isThirdUsed && ThirdPiece.GetComponent<FivePiecesManager>().Thrown) || (WhichSize3 == 5 && !isThirdUsed && ThirdPiece.GetComponent<SixPiecesManager>().Thrown) || (WhichSize3 == 6 && !isThirdUsed && ThirdPiece.GetComponent<NinePiecesManager>().Thrown))
            {
                isThirdUsed = true;
            }
        }


        if(points >= 150)
        {
            level = 2;
        }
        if (points >= 350)
        {
            level = 3;
        }
        if (points >= 600)
        {
            level = 4;
        }
        if (points >= 1000)
        {
            level = 5;
        }
        if (points >= 1500)
        {
            level = 6;
        }
    }

    void generateNewBlocks()
    {
        isFirstUsed = false;
        isSecondUsed = false;
        isThirdUsed = false;

        if(level == 1)
        {
            WhichSize1 = UnityEngine.Random.Range(0, 2);
            WhichSize2 = UnityEngine.Random.Range(0, 3);
            WhichSize3 = UnityEngine.Random.Range(0, 2);
        }
        if (level == 2)
        {
            WhichSize1 = UnityEngine.Random.Range(0, 3);
            WhichSize2 = UnityEngine.Random.Range(1, 3);
            WhichSize3 = UnityEngine.Random.Range(0, 3);
        }
        if (level == 3)
        {
            WhichSize1 = UnityEngine.Random.Range(1, 4);
            WhichSize2 = UnityEngine.Random.Range(0, 3);
            WhichSize3 = UnityEngine.Random.Range(1, 4);
        }
        if (level == 4)
        {
            WhichSize1 = UnityEngine.Random.Range(1, 5);
            WhichSize2 = UnityEngine.Random.Range(2, 4);
            WhichSize3 = UnityEngine.Random.Range(2, 5);
        }
        if (level == 5)
        {
            WhichSize1 = UnityEngine.Random.Range(3, 6);
            WhichSize2 = UnityEngine.Random.Range(1, 6);
            WhichSize3 = UnityEngine.Random.Range(3, 5);
        }
        if (level == 6)
        {
            WhichSize1 = UnityEngine.Random.Range(0, 7);
            WhichSize2 = UnityEngine.Random.Range(1, 7);
            WhichSize3 = UnityEngine.Random.Range(0, 7);
        }

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
        if (WhichSize1 == 3)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, FourPieces.Length);
            firstPiece = Instantiate(FourPieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<FourPiecesManager>().home = firstSpawn.transform.position;
        }
        if (WhichSize1 == 4)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, FivePieces.Length);
            firstPiece = Instantiate(FivePieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<FivePiecesManager>().home = firstSpawn.transform.position;
        }
        if (WhichSize1 == 5)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, SixPieces.Length);
            firstPiece = Instantiate(SixPieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<SixPiecesManager>().home = firstSpawn.transform.position;
        }
        if (WhichSize1 == 6)
        {
            int OneBlock1 = UnityEngine.Random.Range(0, NinePieces.Length);
            firstPiece = Instantiate(NinePieces[OneBlock1], firstSpawn.transform);
            firstPiece.GetComponent<NinePiecesManager>().home = firstSpawn.transform.position;
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
        if (WhichSize2 == 3)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, FourPieces.Length);
            SecondPiece = Instantiate(FourPieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<FourPiecesManager>().home = SecondSpawn.transform.position;
        }
        if (WhichSize2 == 4)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, FivePieces.Length);
            SecondPiece = Instantiate(FivePieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<FivePiecesManager>().home = SecondSpawn.transform.position;
        }
        if (WhichSize2 == 5)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, SixPieces.Length);
            SecondPiece = Instantiate(SixPieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<SixPiecesManager>().home = SecondSpawn.transform.position;
        }
        if (WhichSize2 == 6)
        {
            int OneBlock2 = UnityEngine.Random.Range(0, NinePieces.Length);
            SecondPiece = Instantiate(NinePieces[OneBlock2], SecondSpawn.transform);
            SecondPiece.GetComponent<NinePiecesManager>().home = SecondSpawn.transform.position;
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
        if (WhichSize3 == 3)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, FourPieces.Length);
            ThirdPiece = Instantiate(FourPieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<FourPiecesManager>().home = ThirdSpawn.transform.position;
        }
        if (WhichSize3 == 4)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, FivePieces.Length);
            ThirdPiece = Instantiate(FivePieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<FivePiecesManager>().home = ThirdSpawn.transform.position;
        }
        if (WhichSize3 == 5)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, SixPieces.Length);
            ThirdPiece = Instantiate(SixPieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<SixPiecesManager>().home = ThirdSpawn.transform.position;
        }
        if (WhichSize3 == 6)
        {
            int OneBlock3 = UnityEngine.Random.Range(0, NinePieces.Length);
            ThirdPiece = Instantiate(NinePieces[OneBlock3], ThirdSpawn.transform);
            ThirdPiece.GetComponent<NinePiecesManager>().home = ThirdSpawn.transform.position;
        }
    }
}
