using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class HideAndShowPanel : MonoBehaviour {

    public Image Background;

    public Vector2 AnchoredPositionShowed;
    public Vector2 AnchoredPositionHided;

    RectTransform recttransform;

    public float ApparitionTime = 0.8f;
    public bool StartHided = true;
    public bool InGame = false;

    public bool ContinueGameAfterShowed = false;

    bool showed = false;


    public void Awake()
    {
        recttransform = GetComponent<RectTransform>();

        if (StartHided)
        {
            recttransform.anchoredPosition = AnchoredPositionHided;
            if (Background != null) Background.color = new Color(0, 0, 0, 0);
        }


    }


    //public void Show()
    //{

    //    if (GameManager.instance.actualPhase == GameManager.GamePhases.END_TRACK || GameManager.instance.actualPhase == GameManager.GamePhases.REST_PLACE)
    //        return;

    //    //recttransform.DOSizeDelta(SizeDeltaShowed, 0.8f);
    //    recttransform.DOAnchorPos(AnchoredPositionShowed, ApparitionTime).OnComplete(() => { if (Background != null) Background.DOColor(new Color(0, 0, 0, 100f/255f), ApparitionTime); });

    //    GameManager.instance.StartedGame = false && InGame || ContinueGameAfterShowed;
    //    showed = true;
    //}


    //public void Hide()
    //{
    //    if (Background != null) Background.DOColor(new Color(0, 0, 0, 0), 0.2f);
    //    recttransform.DOAnchorPos(AnchoredPositionHided, ApparitionTime);

    //    GameManager.instance.StartedGame = true && InGame ;
    //    showed = false;
    //}



    //public void Update()
    //{
    //    if (GameManager.instance.StartedGame && showed)
    //    {
    //        Hide();
    //    }
    //}






}
