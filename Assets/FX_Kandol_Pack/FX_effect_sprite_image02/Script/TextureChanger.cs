using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Texture[] textures;
    public float changeInterval = 0.05f;

    void Update()
    {
        if (textures.Length == 0) // nothing if no textures
            return;

        // we want this texture index now
        int index = (int)(Time.time / changeInterval);

        // take a modulo with size so that animation repeats
        index = index % textures.Length;

        // assign it
        GetComponent<Renderer>().material.mainTexture = textures[index];
    }
}
