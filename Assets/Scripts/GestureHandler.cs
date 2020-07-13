using UnityEngine;
using GestureRecognizer;
using UnityEngine.UI;


public class GestureHandler : MonoBehaviour
{
    [SerializeField]
    private Text textResult;

    [SerializeField]
    private GesturePatternDraw[] references;

    [SerializeField]
    private Transform referenceRoot;

    [SerializeField]
    private GesturePatternChoose gesturePatternChoose;

    [SerializeField]
    private int score;

    [SerializeField]
    private ScoreDive scoreDive;

    [SerializeField]
    private OnGamePlay onGamePlay;

    [SerializeField]
    private ScoreHandler scoreHandler;


    public int Score => score;

    void Start()
    {
        references = referenceRoot.GetComponentsInChildren<GesturePatternDraw>();
    }

    public void OnRecognize(RecognitionResult result)
    {
        score = Mathf.RoundToInt(result.score.score * 100);
        textResult.text = result != RecognitionResult.Empty ? gesturePatternChoose.ChosenPattern.name + "\n" + score + "%" : "?";
        scoreDive.SavingScores();
        onGamePlay.CloseUIPanel();
        scoreHandler.AfterHighScore();
    }
}
