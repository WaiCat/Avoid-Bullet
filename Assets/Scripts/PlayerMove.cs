using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 3;
    public float SMoveSpeed = 1.5f;
    SpriteRenderer sprite;
     
    public float Death = 0;

    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < 0f) worldpos.x = 0f;
        if (worldpos.y < 0f) worldpos.y = 0f;
        if (worldpos.x > 1f) worldpos.x = 1f;
        if (worldpos.y > 1f) worldpos.y = 1f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);

    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Keypad4))
            {
                transform.Translate(-SMoveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Keypad6))
            {
                transform.Translate(SMoveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Keypad8))
            {
                transform.Translate(0, SMoveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Keypad5))
            {
                transform.Translate(0, -SMoveSpeed * Time.deltaTime, 0);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Keypad4))
            {
                transform.Translate(-MoveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Keypad6))
            {
                transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Keypad8))
            {
                transform.Translate(0, MoveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Keypad5))
            {
                transform.Translate(0, -MoveSpeed * Time.deltaTime, 0);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            audio.Play();
            sprite.color = new Color(1, 1, 1, 0.5f);
            Death++;
            gameObject.layer = 10;
            Invoke("OffDamaged", 2f);
        }
    }
    void OffDamaged()
    {
        sprite.color = new Color(1, 1, 1);
        gameObject.layer = 8;
    }
}