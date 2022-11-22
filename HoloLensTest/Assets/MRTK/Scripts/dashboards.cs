using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dashboards : MonoBehaviour
{
    public string url;
    public Renderer renderer;
    public Image renderer2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine());
        renderer.material.color = Color.green;
    }

    private IEnumerator LoadFromLikeCoroutine()
    {
        WWW wwwLoader = new WWW(url);
        yield return wwwLoader;

        renderer.material.color = Color.white;
        renderer.material.mainTexture = wwwLoader.texture;
        //renderer2.sprite = Sprite.Create(wwwLoader.texture, new Rect(0, 0, wwwLoader.texture.width, wwwLoader.texture.height), Vector2.one / 2);
    }
}
