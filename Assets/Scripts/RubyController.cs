using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Cela modifie le taux de rafraichissement de l'image de 60 à 10 frames par seconde
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Time.deltaTime permet d'être "Frame independent" donc ne dépend pas du nbre de frames mais juste des secondes.
        Vector2 position = transform.position;
        position.x = position.x + 0.3f * horizontal * Time.deltaTime;
        position.y = position.y + 0.3f * vertical * Time.deltaTime;
        transform.position = position;


    }
}
