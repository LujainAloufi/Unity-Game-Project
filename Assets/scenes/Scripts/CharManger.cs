using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharManger : MonoBehaviour
{


    public CharDB CharDB;
    //public Text nameText;
    public SpriteRenderer artWorkSprite;
    private int selectedOption=0;
    
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

public void nextOption()
{
selectedOption++;
if(selectedOption >= CharDB.CharacterCount)
{
selectedOption=0;

}

updateCharacter(selectedOption);
save();

}
  


public void backOption()
{
selectedOption--;
if(selectedOption < 0)
{
selectedOption=CharDB.CharacterCount-1;
}

updateCharacter(selectedOption);
save();
}
  

public void updateCharacter(int selectedOption)
{
Character character= CharDB.GetCharacter(selectedOption);
artWorkSprite.sprite= character.characterSprite;
}




public void load (){
selectedOption= PlayerPrefs.GetInt("selectedOption");
}

public void save(){

PlayerPrefs.SetInt("selectedOption", selectedOption);

}

public void ChangeScene(int sceneID){
    SceneManager.LoadScene(sceneID);
}

}
