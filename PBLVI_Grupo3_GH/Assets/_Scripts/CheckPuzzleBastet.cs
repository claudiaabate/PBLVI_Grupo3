using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPuzzleBastet : MonoBehaviour
{
    public GameObject CorrectCard1;
    public GameObject CorrectCard2;
    public GameObject CorrectCard3;
    public GameObject CorrectCard4;

    public GameObject CardChild1;
    public GameObject CardChild2;
    public GameObject CardChild3;
    public GameObject CardChild4;

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;

    bool correct1 = false;
    bool correct2 = false;
    bool correct3 = false;
    bool correct4 = false;

    private Animator _animator;
    private Animator _animator2;
    private Animator _fade;
    //private Animator _fade2;
    public GameObject info;

    public GameObject PuzzleBastet2;
    public GameObject PistaRa;
    public GameObject PistaButton;
    public GameObject Congrats;
    public GameObject Fade;
    //public GameObject Fade2;

    public GameObject Char;

    void Start()
    {
        if (PuzzleBastet2.activeInHierarchy)
        {
            _animator = info.GetComponent<Animator>();
            StartCoroutine(WaitTime());
            _animator2 = PistaRa.GetComponent<Animator>();
            StartCoroutine(WaitTime2());
            _fade = Fade.GetComponent<Animator>();
            //_fade2 = Fade.GetComponent<Animator>();
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2.5f);
        _animator.SetBool("Bye", true);
    }

    IEnumerator WaitTime2()
    {
        yield return new WaitForSeconds(30f);
        PistaButton.SetActive(true);
    }

    IEnumerator WaitTime3()
    {
        yield return new WaitForSeconds(2.5f);
        _animator2.SetBool("Bye", true);
    }

    IEnumerator WaitTime4()
    {
        yield return new WaitForSeconds(2.5f);
        _fade.SetBool("fade", true);
        yield return new WaitForSeconds(2.0f);
        PuzzleBastet2.SetActive(false);
    }

    /*IEnumerator WaitTime5()
    {
        yield return new WaitForSeconds(2.5f);
        Fade.SetActive(false);
        _fade2.SetBool("fade", true);
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Card1.gameObject.transform.childCount > 0 && Card2.gameObject.transform.childCount > 0 && Card3.gameObject.transform.childCount > 0 && Card4.gameObject.transform.childCount > 0)
        {
            Check1();
            Check2();
            Check3();
            Check4();
        }

        if (correct1 && correct2 && correct3 && correct4)
        {
            Congrats.SetActive(true);
            StartCoroutine(WaitTime4());
            Char.transform.position = new Vector3(-0.68f, 8.49f, 1.51f);
            Char.transform.rotation = new Quaternion(0, 180, 0, 0);
            //StartCoroutine(WaitTime5());
            //_fade2.SetBool("fade", true);
        }

    }

    void Check1()
    {
        CardChild1 = Card1.gameObject.transform.GetChild(0).gameObject;

        if (CardChild1 == CorrectCard1)
            correct1 = true;
        //if (correct1)
            //Debug.Log("correct1");

    }

    void Check2()
    {
        CardChild2 = Card2.gameObject.transform.GetChild(0).gameObject;

        if (CardChild2 == CorrectCard2)
            correct2 = true;
        //if (correct2)
            //Debug.Log("correct2");
    }

    void Check3()
    {
        CardChild3 = Card3.gameObject.transform.GetChild(0).gameObject;

        if (CardChild3 == CorrectCard3)
            correct3 = true;
        //if (correct3)
            //Debug.Log("correct3");
    }

    void Check4()
    {
        CardChild4 = Card4.gameObject.transform.GetChild(0).gameObject;

        if (CardChild4 == CorrectCard4)
            correct4 = true;
        //if (correct4)
            //Debug.Log("correct4");
    }

    public void Back()
    {
        PuzzleBastet2.SetActive(false);
    }

    public void Pista()
    {
        PistaRa.SetActive(true);
        StartCoroutine(WaitTime3());
        PistaButton.SetActive(false);
    }
}

