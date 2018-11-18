using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    public Canvas _canvas;
    public RectTransform _content;
    public RectTransform _tilePrefab;

    [Tooltip("Temp variable, Delete afterwards")]
    public int _numberOfTiles;

    private void Start()
    {
        Invoke("CreateContentTiles",1f);
    }

    void CreateContentTiles() {
        _content.sizeDelta = new Vector2 (1, _numberOfTiles *1080);
        
        for (int i=0; i < _numberOfTiles ; i++) {
            RectTransform tile = Instantiate(_tilePrefab) as RectTransform;
            tile.transform.parent = _content;
            tile.transform.localScale = Vector3.one;
            tile.anchoredPosition = new Vector3(0, -1080 * i, 1);
            tile.GetComponent<Image> ().color = Random.ColorHSV ();
            //tile.transform.position = 
            Debug.Log("Created some tiles!");
        }
    }
}
