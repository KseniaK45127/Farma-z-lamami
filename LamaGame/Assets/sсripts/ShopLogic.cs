
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class ShopLogic : MonoBehaviour
{
    public Text scoreText;
    public Text scorepersecText;
    public Text scoreperclickText;
    private int score;
    private int MouseClick = 1;
    private int ClickPerSec = 0;

    [Header("Shop")]
    public float[] shopCosts;
    public int[] shopBonuses;
    public Text[] shopbttonsText;


    public GameObject shopPan;

    [Header("Lama")]
    public GameObject[] LamaObject;
    public int[] LamaObjectIlosc;
    public int[] Lamalevel;
    public Text[] LamaLvlText;

    private void Start()

    {
        score = 0;
        StartCoroutine(BonusPerSec());


    }
    private void Update()
    {
        scoreText.text = score + "";
        scoreperclickText.text = MouseClick + "";
        scorepersecText.text = ClickPerSec + "";

    }
    public void shopPan_ShowAndHide()
    {
        shopPan.SetActive(!shopPan.activeSelf);
    }
    public void shopbtton_addBonus(int index)
    {
        if (score >= shopCosts[index])
        {
            MouseClick += shopBonuses[index];
            score -= Mathf.RoundToInt(shopCosts[index]);
            shopCosts[index] = Mathf.RoundToInt(shopCosts[index] * 1.2f);
            shopbttonsText[index].text = shopCosts[index] + "";
            if (LamaObjectIlosc[index] < 1)
            {
                LamaObject[index].SetActive(true);
                LamaObjectIlosc[index]++;
            }
            Lamalevel[index]++;
            LamaLvlText[index].text = "Lvl\n" + Lamalevel[index];
        }
    }


    public void HireWorker(int index)
    {
        if (score >= shopCosts[index])
        {
            score -= Mathf.RoundToInt(shopCosts[index]);
            shopCosts[index] = Mathf.RoundToInt(shopCosts[index] * 1.2f);
            ClickPerSec += shopBonuses[index];
            shopbttonsText[index].text = shopCosts[index] + "";

            if (LamaObjectIlosc[index] < 1)
            {
                LamaObject[index].SetActive(true);
                LamaObjectIlosc[index]++;

            }
            Lamalevel[index]++;
            LamaLvlText[index].text = "Lvl\n" + Lamalevel[index];
        }
    }


    IEnumerator BonusPerSec()
    {
        while (true)
        {
            score += ClickPerSec;
            yield return new WaitForSeconds(1);
        }
    }


    public void OnClick()
    {
        score += MouseClick;
        scoreText.text = score + "$";
    }
}

