using UnityEngine;
using DG.Tweening;


public class CharAndCamMovements : MonoBehaviour
{
    [SerializeField]
    private Transform Pos1;

    [SerializeField]
    private Transform Pos2;

    [SerializeField]
    [Range(70.0f, 85.0f)]
    private float CamRotX = 85f;

    [SerializeField]
    [Range(0.0f, 0.5f)]
    private float CamPosZ = 0.5f;

    [SerializeField]
    [Range(2.5f, 4.0f)]
    private float CamPosY = 3f;

    [SerializeField]
    [Range(-1f, 1f)]
    private float CamPosX = 0f;

    public void JumpingToPool()
    {
        Sequence Position = DOTween.Sequence();
        Position.Append(transform.DOMove(new Vector3(Pos1.position.x, Pos1.position.y, Pos1.position.z), 1.5f));
        Position.Append(transform.DOMove(new Vector3(Pos2.position.x, Pos2.position.y, Pos2.position.z), 10));
    }

    public void DynamicCameraPos()
    {
        Sequence Rotation = DOTween.Sequence();
        Rotation.Join(GameObject.Find("Camera").transform.DOLocalRotate(new Vector3(CamRotX, transform.rotation.y, transform.rotation.z), 2));
        Rotation.Join(GameObject.Find("Camera").transform.DOLocalMove(new Vector3(CamPosX, CamPosY, CamPosZ), 2));
    }
}
