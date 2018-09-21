using Mapbox.Unity.MeshGeneration.Interfaces;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoiLabelIconSetter : MonoBehaviour, IFeaturePropertySettable
{

    [SerializeField]
    SpriteRenderer _spriteRenderer;

    public void Set(Dictionary<string, object> props)
    {
        Sprite sp = Resources.Load(props["name"].ToString()) as Sprite;
        if (sp == null)
        {
            _spriteRenderer.sprite = sp;
        }
    }
}
