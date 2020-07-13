using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public class ScoreDive : MonoBehaviour
{
    [SerializeField]
    private GestureHandler gestureHandler;

    [SerializeField]
    private List<int> scoreKeeper;

    [SerializeField]
    private double avarageScore;

    public double AvarageScore => avarageScore;

  public void SavingScores()
    {
        scoreKeeper.Add(gestureHandler.Score);
    }

    public void EndGameDive()
    {
        for (int i = 0; i < scoreKeeper.Count; i++)
        {
            scoreKeeper[i] = scoreKeeper[i];
            avarageScore = scoreKeeper.Average();
        }
    }

    void Update()
    {
        EndGameDive();
    }
}
    