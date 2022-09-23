using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ball : MonoBehaviour
{
    

    
    [SerializeField] private float Speed = 100.0f;
    [SerializeField] public TextMeshPro text; 
    [SerializeField] private int score = 0;
    [SerializeField] private bool gameover = false;

    [SerializeField] private TextMeshPro GameOverText;
    [SerializeField] private GameObject[] GameOverDeleteList;
    // Start is called before the first frame update
    void Start()
    {
             text.text = score + "";   
    GetComponent<Rigidbody2D>().velocity = Vector2.up * Speed;
    //Setting velocity to speed Var
    }

    void OnCollisionEnter2D(Collision2D col)
    {
  if (col.gameObject.name == "Racket") {
     //Hit Racket?
    float x=hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

       
        Vector2 dir = new Vector2(x, 1).normalized;
     // Calculate direction, set length to 1

        GetComponent<Rigidbody2D>().velocity = dir * Speed;
     // Set Velocity with dir * speed
    }
    else if(col.gameObject.TryGetComponent<Block>(out Block H))
    {
     score++;
     text.text = score + "";   
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
    // 
    //
    // 1  -0.5  0  0.5   1  <- x value
    // ===================  <- racket

/*
⣿⠟⠫⢻⣿⣿⣿⣿⢟⣩⡍⣙⠛⢛⣿⣿⣿⠛⠛⠛⠛⠻⣿⣿⣿⣿⣿⡿⢿⣿
⣿⠤⠄⠄⠙⢿⣿⣿⣿⡿⠿⠛⠛⢛⣧⣿⠇⠄⠂⠄⠄⠄⠘⣿⣿⣿⣿⠁⠄⢻
⣿⣿⣿⣿⣶⣄⣾⣿⢟⣼⠒⢲⡔⣺⣿⣧⠄⠄⣠⠤⢤⡀⠄⠟⠉⣠⣤⣤⣤⣾
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣀⣬⣵⣿⣿⣿⣶⡤⠙⠄⠘⠃⠄⣴⣾⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢻⠿⢿⣿⣿⠿⠋⠁⠄⠂⠉⠒⢘⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⣿⡿⣡⣷⣶⣤⣤⣀⡀⠄⠄⠄⠄⠄⠄⠄⣾⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⣿⣿⡿⣸⣿⣿⣿⣿⣿⣿⣿⣷⣦⣰⠄⠄⠄⠄⢾⠿⢿⣿⣿⣿⣿
⣿⡿⠋⣡⣾⣿⣿⣿⡟⠉⠉⠈⠉⠉⠉⠉⠉⠄⠄⠄⠑⠄⠄⠐⡇⠄⠈⠙⠛⠋
⠋⠄⣾⣿⣿⣿⣿⡿⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢠⡇⠄⠄⠄⠄⠄
⠄⢸⣿⣿⣿⣿⣿⣯⠄⢠⡀⠄⠄⠄⠄⠄⠄⠄⠄⣀⠄⠄⠄⠄⠁⠄⠄⠄⠄⠄
⠁⢸⣿⣿⣿⣿⣿⣯⣧⣬⣿⣤⣐⣂⣄⣀⣠⡴⠖⠈⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
⠈⠈⣿⣟⣿⣿⣿⣿⣿⣿⣿⣿⣽⣉⡉⠉⠈⠁⠄⠁⠄⠄⠄⠄⡂⠄⠄⠄⠄⠄
⠄⠄⠙⣿⣿⠿⣿⣿⣿⣿⣷⡤⠈⠉⠉⠁⠄⠄⠄⠄⠄⠄⠄⠠⠔⠄⠄⠄⠄⠄
⠄⠄⠄⡈⢿⣷⣿⣿⢿⣿⣿⣷⡦⢤⡀⠄⠄⠄⠄⠄⠄⢐⣠⡿⠁⠄⠄⠄⠄⠄
*/
    return (ballPos.x - racketPos.x) / racketWidth;
}
}

private void FixedUpdate()
{

if(transform.position.y < -200.0f)
{
     Debug.Log(transform.position.y);
     GameOverText.color = new Color(255,0,0);
    // for(i=0. i <  i++)


}

}
}

