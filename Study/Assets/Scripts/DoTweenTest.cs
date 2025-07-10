using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoTweenTest : MonoBehaviour
{
    public Image image;
    public Text txt;
    public GameObject ima;
    [ContextMenu("测试方法")]
    public void Test()
    {
        //通过使用事件委托的方式，将一个动画播放完之后播放下一个
        ////image.transform.DOLocalMoveX(200, 3);
        //image.transform.DOLocalJump(Vector3.left, 300, 10, 3).OnComplete(()=> {
        //    image.transform.DOScale(Vector3.one * 2, 3).OnComplete(() => {
        //        image.DOFade(0, 3.5f);
        //    });
        //});
        //punch从start到end再start循环
        //image.transform.DOPunchScale(new Vector3 (0,1,0),2,2,0.3f);
        //image.transform.DOPunchPosition(new Vector3 (0,20,0),2,2,0.2f);
        //image.transform.DOPunchRotation(new Vector3 (0,0,20),2,5,0.2f);
        //image.transform.DOMove(new Vector3(0,0 ,200),3);
        //创建动画序列
        /*
         * Sequence sq = DOTween.Sequence();//队列
        sq.Append(image.transform.DOLocalJump(Vector3.left, 300, 10, 3));
        sq.Append(image.transform.DOScale(Vector3.one * 2, 3));
        txt.text = "";
        sq.Insert(1,image.DOFade(0, 3.5f)).OnComplete(() => {
            txt.DOText("今日份学习DOTween",3);
        });
         */

        ///移动到目标位置 DOMove（世界目标位置（vector3），持续时间（float））
        // image.transform.DOMove(txt.transform.position, 1);
        //.SetRelative();//相对位置 用完的感觉像DOLocalMove，但是一直点击可以累加
        //1s内移动到目标位置
        // image.transform.DOLocalMove(new Vector3 (-560,215,0), 1);
    }
}
