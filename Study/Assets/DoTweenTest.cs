using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoTweenTest : MonoBehaviour
{
    public Image image;
    public Text txt;
    [ContextMenu("���Է���")]
    public void Test()
    {
        //ͨ��ʹ���¼�ί�еķ�ʽ����һ������������֮�󲥷���һ��
        ////image.transform.DOLocalMoveX(200, 3);
        //image.transform.DOLocalJump(Vector3.left, 300, 10, 3).OnComplete(()=> {
        //    image.transform.DOScale(Vector3.one * 2, 3).OnComplete(() => {
        //        image.DOFade(0, 3.5f);
        //    });
        //});
        //punch��start��end��startѭ��
        //image.transform.DOPunchScale(new Vector3 (0,1,0),2,2,0.3f);
        //image.transform.DOPunchPosition(new Vector3 (0,20,0),2,2,0.2f);
        //image.transform.DOPunchRotation(new Vector3 (0,0,20),2,5,0.2f);
        //image.transform.DOMove(new Vector3(0,0 ,200),3);
        //������������
        Sequence sq = DOTween.Sequence();
        sq.Append(image.transform.DOLocalJump(Vector3.left, 300, 10, 3));
        sq.Append(image.transform.DOScale(Vector3.one * 2, 3));
        txt.text = "";
        sq.Insert(1,image.DOFade(0, 3.5f)).OnComplete(() => {
            txt.DOText("���շ�ѧϰDOTween",3);
        });
    }
}
