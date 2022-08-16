using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    public GameObject character;
    public AudioSource source;
    public AudioClip ball_spawn;
    public AudioClip ball_throw;
    public GameObject prefab;
    public Timer_Count t;
    public int speed;
    void Start()
    {
        InvokeRepeating("Ball_Script", 4.0f, 15.0f);
        //Invoke("Ball_Script", 3.0f);
    }
    void Ball_Script()
    {
        Vector3 center = character.transform.position;
        center.y = 0f;
        Vector3 pos = RandomCircle(center, 65.0f);
        Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
        Instantiate(prefab, pos, rot);
        source.PlayOneShot(ball_spawn,2);
        GetComponent<Rigidbody>().useGravity = false;
        Vector3 shoot = (character.transform.position - this.gameObject.transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(shoot * speed);
        source.PlayOneShot(ball_throw, 2);
        GetComponent<Rigidbody>().useGravity = true;
        Invoke("Bye", 3.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        t.Stop();
        SceneManager.LoadScene(2);
    }
    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = UnityEngine.Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.y = 7.0f;
        return pos;
    }
    void Bye()
    {
        Destroy(this.gameObject);
    }
}
    

