using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour
{
    // Start is called before the first frame update
   public void openLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/pratik-kumar-a61a46271/");
    }

    public void openInstagram()
    {
        Application.OpenURL("https://www.instagram.com/hoodboypk/");
    }

    public void openGithub()
    {
        Application.OpenURL("https://github.com/hoodboypk");
    }
}
