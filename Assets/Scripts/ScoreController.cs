using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour {

    public static ScoreController instance;
    [SerializeField] private TextMeshProUGUI scoreText;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);    //Preventing duplicates
        }
    }

    void Update(){
        UpdateScoreText();
    }

    public void IncrementScore(){
        Score.score++;
    }

    public void DecrementScore(){
        Score.score--;
    }

    void UpdateScoreText(){
        scoreText.text = "Score: " + Score.score;
    }
}
