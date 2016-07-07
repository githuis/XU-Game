using UnityEngine;
using System.Collections;

public class AnimateOnlyOnKeyPress : MonoBehaviour
{
    //Animer KUN når en/flere af disse keys bliver trykket på
    public KeyCode[] keys;

    //Bestemmer om der bliver animeret eller ej.
    private bool animate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckAnimate();

        if (!animate)
            GetComponent<Animator>().Stop();
        else
            GetComponent<Animator>().Play(0);
    }

    void CheckAnimate()
    {
        animate = false;

        foreach (KeyCode key in keys)
        {
            if (Input.GetKey(key))
            {
                animate = true;
                break;
            }
        }
    }
}
