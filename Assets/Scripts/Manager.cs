using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] GameObject[] OnePieces;
    [SerializeField] Boolean isFirstUsed, isSecondUsed, isThirdUsed;
    [SerializeField] GameObject firstPiece, SecondPiece, ThirdPiece;
    [SerializeField] GameObject firstSpawn, SecondSpawn, ThirdSpawn;

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
            if (!isFirstUsed && firstPiece.GetComponent<OnePiece>().Thrown)
            {
                isFirstUsed = true;
            }
            if (!isSecondUsed && SecondPiece.GetComponent<OnePiece>().Thrown)
            {
                isSecondUsed = true;
            }
            if (!isThirdUsed && ThirdPiece.GetComponent<OnePiece>().Thrown)
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
        int ins1 = UnityEngine.Random.Range(0, OnePieces.Length);
        int ins2 = UnityEngine.Random.Range(0, OnePieces.Length);
        int ins3 = UnityEngine.Random.Range(0, OnePieces.Length);
        firstPiece = Instantiate(OnePieces[ins1], firstSpawn.transform);
        firstPiece.GetComponent<OnePiece>().home = firstSpawn.transform.position;
        SecondPiece = Instantiate(OnePieces[ins2], SecondSpawn.transform);
        SecondPiece.GetComponent<OnePiece>().home = SecondSpawn.transform.position;
        ThirdPiece = Instantiate(OnePieces[ins3], ThirdSpawn.transform);
        ThirdPiece.GetComponent<OnePiece>().home = ThirdSpawn.transform.position;
    }
}
