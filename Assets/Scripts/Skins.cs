using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
{
    public int num_skin;

    public GameController Skin;
    public string skin;
    private Animator anim;

    public void Start()
    {
        num_skin = Skin.num_skin;
        anim = GetComponent<Animator>();
        
    }

    public void Update()
    {
        num_skin = Skin.num_skin;
        skin = Skin.skins[num_skin];
        if (skin == "ladybug")
        {
            anim.SetBool("isLadybug", true);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "cat")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", true);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "fox")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", true);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "bee")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", true);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "peacock")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", true);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "butterfly")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", true);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "rabbit")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", true);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "horse")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", true);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "mouse")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", true);
            anim.SetBool("isTurtle", false);
        }
        else if (skin == "turtle")
        {
            anim.SetBool("isLadybug", false);
            anim.SetBool("isCat", false);
            anim.SetBool("isBee", false);
            anim.SetBool("isFox", false);
            anim.SetBool("isPeacock", false);
            anim.SetBool("isButterfly", false);
            anim.SetBool("isRabbit", false);
            anim.SetBool("isHorse", false);
            anim.SetBool("isMouse", false);
            anim.SetBool("isTurtle", true);
        }
    }
    
    
}
