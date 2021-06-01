using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float Speed = 0.125f;
    //omogucuje dodatno podesavanje iz unitya
    public Vector3 offset;
  
    void LateUpdate ()
    {
        //postavlja poziciju kamere na poziciju objekta kojeg oredimo u unityu(u ovome slucaju igraca)
        //te ga pomice za vrijednost vektora offset
        transform.position = target.position + offset;
    }
}
