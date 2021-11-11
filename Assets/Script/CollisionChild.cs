using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChild : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rbKnife;           //←力を加える対象
    [SerializeField]
    private GameObject goKife;

    public AudioClip sound_can;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("柄で触れた");
        ////音(sound_can)を鳴らす
        //audioSource.PlayOneShot(sound_can);

    }
    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {

        Debug.Log("柄で触れた");
        //音(sound_can)を鳴らす
        audioSource.PlayOneShot(sound_can);

    }
}
