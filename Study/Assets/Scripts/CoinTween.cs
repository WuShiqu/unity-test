using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTween : MonoBehaviour
{
    private Image image;
   [SerializeField] private Vector2 _targetPos;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    public void PlayTween(float delay)
    {
        transform.DOScale(1, 0.3f).SetEase(Ease.OutSine).OnComplete(() =>
            {
                image.rectTransform.DOAnchorPos(_targetPos, 0.6f).SetEase(Ease.OutQuad).SetDelay(delay).OnComplete(() =>
                {
                    transform.DOScale(0, 0.1f).SetEase(Ease.InBack).OnComplete(() =>
                    {
                        Destroy(gameObject);
                        //¼ÆÊý
                        FindObjectOfType<CoinManager>().CoinCount++;
                        FindObjectOfType<CoinManager>().UpdateCounter();
                    });
                });
                image.rectTransform.DORotate(Vector3.zero, 0.6f).SetEase(Ease.OutQuad).SetDelay(delay);
            });
    }
}
