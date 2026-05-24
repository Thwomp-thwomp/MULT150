using UnityEngine;
using UnityEngine.Experimental.AI;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    Renderer renderer;
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (offset > 1)
            offset -= 1;
        renderer.material.mainTextureOffset = new Vector2 (0, offset);
    }
}
