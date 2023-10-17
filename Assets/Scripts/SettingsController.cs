using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour
{
    private Animator anim;
    public bool VoiceOn;
    public string LanguageChoice;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Voice()
    {
        if (VoiceOn == true)
        {
            anim.SetBool("VoiceOn", false);
            VoiceOn = false;
        }
        else
        {
            anim.SetBool("VoiceOn", true);
            VoiceOn = true;
        }
    }

    public void Language()
    {
        if (LanguageChoice == "en")
        {
            anim.SetBool("en", false);
            anim.SetBool("ru", true);
            LanguageChoice = "ru";
        }
        else if (LanguageChoice == "ru")
        {
            anim.SetBool("en", true);
            anim.SetBool("ru", false);
            LanguageChoice = "ru";
        }
    }
} 
