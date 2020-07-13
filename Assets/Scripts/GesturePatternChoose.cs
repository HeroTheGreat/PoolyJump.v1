using UnityEngine;


public class GesturePatternChoose : MonoBehaviour
{
    [SerializeField]
    private GameObject[] childPatterns;

    [SerializeField]
    private GameObject chosenPattern;

    [SerializeField]
    private GameObject drawArea;

    [SerializeField]
    private int index;

    public GameObject[] ChildPatterns => childPatterns;
    public GameObject ChosenPattern => chosenPattern;
    public GameObject DrawArea => drawArea;
    public int İndex => index;

    void Start()
    { 
        CountChildPatterns();
    }

    void CountChildPatterns()
    {
        childPatterns = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            childPatterns[i] = transform.GetChild(i).gameObject;
        }
    }

    public void ChooseRandomChildPattern()
    {
        index = Random.Range(0, childPatterns.Length);
        chosenPattern = childPatterns[index];
        childPatterns[index].SetActive(true);
        drawArea.SetActive(true);
    }
}
