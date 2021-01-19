using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    [Header("石板介面")]
    public Text textStone;
    [Header("動物分數")]
    public int animal;
    [Header("加分")]
    public int animalname = 2;
    [Header("放對的音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.tag == "animal")
        {
            AddScore();
        }
        // 如果 碰撞的根物件名稱為 Player
        if (other.transform.root.name == "Player")
        {
            
            animalname = 3;
        }
    }

   
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            
            animalname = 2;
        }
    }

    private void AddScore()
    {
        animal += animalname;                                  
        textStone.text = "送回獎勵分數：" + animal;                 
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));     
    }
}
