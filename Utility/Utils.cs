using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace DotweenStuff
{
    public static class Utils
    {
        public static TweenerCore<Color, Color, ColorOptions> AlphaOut(this Graphic target, float duration, float toAlpha)
        {
            return ChangeAlpha(target,1,toAlpha,duration).SetEase(Ease.OutSine);
        }
        
        public static TweenerCore<Color, Color, ColorOptions> AlphaOut(this Graphic target,float duration)
        {
            return ChangeAlpha(target,1,0,duration).SetEase(Ease.OutSine);
        }
        
        public static TweenerCore<Color, Color, ColorOptions> AlphaIn(this Graphic target, float duration)
        {
            return ChangeAlpha(target,0,1,duration).SetEase(Ease.OutSine);
        }
        
        public static TweenerCore<Color, Color, ColorOptions> AlphaIn(this Graphic target, float duration,float toAlpha)
        {
            return ChangeAlpha(target,0,toAlpha,duration).SetEase(Ease.OutSine);
        }
        
        public static TweenerCore<Color, Color, ColorOptions> ChangeAlpha(this Graphic target, float startValue, float endValue,float duration)
        {
            Color startColor = target.color;
            startColor.a = startValue;
        
            Color endColor = target.color;
            endColor.a = endValue;
        
            target.color = startColor;
            return  target.DOColor(endColor, duration);
        }

    }
}