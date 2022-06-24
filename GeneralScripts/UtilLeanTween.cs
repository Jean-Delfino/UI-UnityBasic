using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public static class UtilLeanTween{
    public static float ChangeScaleAnimation(RectTransform rt, Vector3 finalScale, float time){
        if(rt.localScale == finalScale){
            return 0f;
        } 

        LeanTween.scale(rt, finalScale, time);
        return time;
    }

    public static float ChangeAlphaImageAnimation(RectTransform rt, float finalAlpha, float time){
        LeanTween.alpha(rt, finalAlpha, time); 
        return time;
    }

    public static float ChangeAlphaCanvasImageAnimation(CanvasGroup rt, float finalAlpha, float time){
        LeanTween.alphaCanvas(rt, finalAlpha, time); 
        return time;
    }
}