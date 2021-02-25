using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] Color mycolor;
    

    void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<TileGame>().ChangeColor(mycolor);
    }
}
