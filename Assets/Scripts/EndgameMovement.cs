using UnityEngine;
using DG.Tweening;

public class EndgameMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 endPos1;

    [SerializeField] 
    private Vector3 endPos2;

    [SerializeField]
    private Vector3 betweenPositions;

    [SerializeField]
    private double avarageScore;

    [SerializeField]
    private float maxscore = 100f;

    [SerializeField]
    private float minValue;

    [SerializeField]
    private DrawSpawner drawSpawner;

    void Start()
    {
        endPos1 = GameObject.Find("MoveEndPosScore").GetComponent<Transform>().position;
        endPos2 = GameObject.Find("MoveEndPosScore2").GetComponent<Transform>().position;
    }

    private void AvarageScoreToTransform()
    {
        minValue = 1f / (drawSpawner.Points.Length * maxscore);
        betweenPositions = Vector3.Lerp(endPos1, endPos2, minValue * (float)avarageScore);
    }

    public void EndPositionMovement()
    {
        this.gameObject.transform.DOMoveY(betweenPositions.y, 3);
    }
    private void Update()
    {
        avarageScore = GetComponent<ScoreDive>().AvarageScore;
        AvarageScoreToTransform();
    }
}

