using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public AnimationClip deathClip;

    PlayerMovement pm;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Death()
    {
        pm.enabled = false;

        //Start the material animation.

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
