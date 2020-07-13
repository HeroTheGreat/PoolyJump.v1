using UnityEngine;
using System.Collections;


public class ScoreHandler : MonoBehaviour
{
    [SerializeField]
    [Range(0, 100)]
    private int handlerscore;

    [SerializeField]
    [Range(0.1f, 1f)]
    private float CooldownCount;

    [SerializeField]
    private GestureHandler gestureHandler;

    [SerializeField]
    private RandomAnimations randomAnimations;

    [SerializeField]
    private GesturePatternChoose gesturePatternChoose;

    public void AfterHighScore()
    {
        if (gestureHandler.Score > handlerscore || gestureHandler.Score == handlerscore)
        {
            randomAnimations.PlayOnHighScore();
        }
    }

    public IEnumerator CooldownForPlay()
    {
        yield return new WaitForSeconds(CooldownCount);
        randomAnimations.NormalTimeSet();
        gesturePatternChoose.ChosenPattern.gameObject.SetActive(false);
        gesturePatternChoose.DrawArea.gameObject.SetActive(false);
    }
}
