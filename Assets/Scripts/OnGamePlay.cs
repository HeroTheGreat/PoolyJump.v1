using UnityEngine;


public class OnGamePlay : MonoBehaviour
{
    [SerializeField]
    private RandomAnimations randomAnimations;

    [SerializeField]
    private GesturePatternChoose gesturePatternChoose;

    [SerializeField]
    private CharAndCamMovements charAndCamMovements;

    [SerializeField]
    private ScoreHandler scoreHandler;

    [SerializeField]
    private EndgameMovement endgameMovement;

    private void GameMovementStart()
    {
        if (Input.GetMouseButtonDown(1) && GetComponent<CharAndCamMovements>())
        {
            charAndCamMovements.DynamicCameraPos();
            charAndCamMovements.JumpingToPool();
            Destroy(GetComponent<CharAndCamMovements>());
            randomAnimations.StartAnimation();
         }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Colliders")
        {
            scoreHandler.StartCoroutine("CooldownForPlay");
            gesturePatternChoose.ChooseRandomChildPattern();
            randomAnimations.SlowTimeSet();
        }
        if (collider.tag=="EndCollider")
        {
            endgameMovement.EndPositionMovement();
        }
    }

    public void CloseUIPanel()
    {
        gesturePatternChoose.ChosenPattern.SetActive(false);
        gesturePatternChoose.DrawArea.SetActive(false);
        randomAnimations.NormalTimeSet();
    }

    private void Update()
    {
        GameMovementStart();
    }
}
