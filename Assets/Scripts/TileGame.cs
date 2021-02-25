using LLFramework;
using UnityEngine;

public class TileGame : TileBase, IColorable
{
    public enum Type
    {
        Hole,
        Floor,
    }

    public Type tipology;

    public void ChangeColor(Color _color)
    {
        gameObject.GetComponentInChildren<Renderer>().material.color = _color;
    }
}