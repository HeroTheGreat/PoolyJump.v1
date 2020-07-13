using UnityEngine;


public class RandomAnimations : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private string[] highScoreAnimations = { "ForwardFlip", "BackFlip", "JumpInAir" };

    private void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        animator.SetTrigger("GoDive");
    }

    public void PlayOnHighScore()
    {
        System.Random rnd = new System.Random();
        int anims = rnd.Next(highScoreAnimations.Length);
        string Trigger = highScoreAnimations[anims];
        animator.SetTrigger(Trigger);
    }

    public void SlowTimeSet()
    {
        Time.timeScale = 0.1f;
        Debug.Log("SlowedTimeSet!!");
    }

    public void NormalTimeSet()
    {
        Time.timeScale = 0.75f;
    }
}
