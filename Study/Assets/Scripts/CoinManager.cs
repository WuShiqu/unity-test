using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private Transform imaParent;
    [SerializeField] private Image imaPrefab;
    [SerializeField] private int posMin, posMax;
    [SerializeField] private int rotationMin, rotationMax;
    [SerializeField] private Text coinNum;
    int coinAllNum;
    private int coinCount = 0;
    private  List<Image> coins = new List<Image>();

    public int CoinCount
    { 
        get => coinCount;
        set => coinCount = value;
    }

    public void Reward()
    {
        coins.Clear();
        GeneratedCoin();
        MakeTween();
    }

    private void MakeTween()
    {
        float delay = 0f;
        for (int i = 0; i < coinAllNum; i++)
        {
            coins[i].GetComponent<CoinTween>().PlayTween(delay);
        }delay += 0.1f;
    }

    private  void GeneratedCoin()
    {//随机生成金币
        int numRandom = Random.Range(7, 14);
        for (int i = 0; i < numRandom; i++)
        {
            Image ima = Instantiate(imaPrefab,Vector3.zero,Quaternion.identity,imaParent);
            ima.transform.localPosition = new Vector3(Random.Range(posMin, posMax + 1), Random.Range(posMin, posMax + 1), 0);
            ima.transform.rotation = Quaternion.Euler(0, 0, Random.Range(rotationMin, rotationMax + 1));
            coins.Add(ima);
        }
        coinAllNum = numRandom;
        
    }
    
    public void UpdateCounter()
    {
        coinNum.DOCounter(CoinCount-coinAllNum, CoinCount, 0.2f);
    }
}
