using Mapbox.Unity.MeshGeneration.Interfaces;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoiLabelSetter : MonoBehaviour, IFeaturePropertySettable
{
	[SerializeField]
	TextMesh _textMesh;

	[SerializeField]
	Image _background;

	[SerializeField]
	SpriteRenderer _spriteRenderer;

    public void Set(Dictionary<string, object> props)
	{
		_textMesh.text = "";

		if (props.ContainsKey("name"))
		{
			_textMesh.text = props["name"].ToString();
		}

		float textWidth = _textMesh.GetComponent<Renderer>().bounds.size.x;
		RectTransform backgroundRect = _background.GetComponent<RectTransform>();
		backgroundRect.sizeDelta = new Vector2 (textWidth + 4f, 6f);
        Sprite _imageSprite = Resources.Load<Sprite>(props["name"].ToString());
		if (_imageSprite != null)
		{
		    _spriteRenderer.sprite = _imageSprite;
		}

	    float _iconSize = float.Parse(props["size"].ToString());
        _spriteRenderer.gameObject.transform.localScale = new Vector3(_iconSize, _iconSize, _iconSize);
	    Vector3 _heightVector = new Vector3(_textMesh.gameObject.transform.position.x, _spriteRenderer.bounds.extents.y + 23.0f, _textMesh.gameObject.transform.position.z);
        Debug.Log(_spriteRenderer.bounds.extents.y.ToString());
	    _textMesh.gameObject.transform.position = _heightVector;
	    _background.gameObject.transform.position = _heightVector;
        
	}
}