using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //char
    public CharDB CharDB;
    public SpriteRenderer artWorkSprite;
    private int selectedOption=0;
    
//
    // Start is called before the first frame update
    void Start()
    {
                if(!PlayerPrefs.HasKey("selectedOption")){

            selectedOption=0;
        }else{
            load();
        }
        updateCharacter(selectedOption);

    }

public void updateCharacter(int selectedOption)
{
Character character= CharDB.GetCharacter(selectedOption);
artWorkSprite.sprite= character.characterSprite;
}




public void load (){
selectedOption= PlayerPrefs.GetInt("selectedOption");
}
  
}
