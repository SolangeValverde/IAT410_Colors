using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour
{
    private static LevelComplete instance = null;
    public static LevelComplete Instance
    {
        get { return instance; }
    }
    public AudioSource LVLsound;    // Add your Audi Clip Here;
                               // This Will Configure the  AudioSource Component; 
                               // MAke Sure You added AudioSouce to death Zone;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        // GetComponent<AudioSource> ().clip = saw;
        LVLsound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D()  //Plays Sound Whenever collision detected
    {
        Debug.Log("hits the door");
        LVLsound.Play();
    }
    // Make sure that deathzone has a collider, box, or mesh.. ect..,
    // Make sure to turn "off" collider trigger for your deathzone Area;
    // Make sure That anything that collides into deathzone, is rigidbody;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
       // DontDestroyOnLoad(this.gameObject);
    }
}