using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movimentacao_Char : MonoBehaviour
{

    public GameObject player, vida_image1, vida_image2, vida_image3, Player_Body, gameover, vitoria;
    public float speed;
    public Text contador_Coletavel, contador_Coletavel2;
    public int contagem = 0, vidas = 3, quatidadeMissao=3;
	public AudioClip hit, coin;
	public AudioSource somPlayer;
    // Use this for initialization

    void Start()
    {
        //contador_Coletavel.text = "oi";
    }

    // Update is called once per frame
    void Update()
    {
		if(contagem == 5)
        {
            vitoria.SetActive(true);
            Player_Body.SetActive(false);
			player.SetActive (false);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;

        //if (Input.GetAxisRaw("Vertical")==1)
        //{
        //    //player.transform.position =  player.transform.position * Vector3.up*;
        //    GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        //}
        //if (Input.GetAxisRaw("Vertical") == -1)
        //{

        //    Debug.Log("ok");
        //}
    }

    void OnParticleCollision(GameObject obj)
    {
        if (obj.name == "Coletavel")
        {
            contagem = contagem + 1;
            contador_Coletavel.GetComponent<Text>().text = contagem.ToString();
            contador_Coletavel2.GetComponent<Text>().text = contagem.ToString();
            Debug.Log(contagem);
			somPlayer.PlayOneShot(coin);

        }
        if (obj.name == "Asteroid")
        {
			somPlayer.PlayOneShot(hit);
            player.GetComponent<Animator>().Play("Alien_Dano");
            vidas = vidas - 1;
            if(vidas == 2)
            {
                vida_image1.SetActive(false);
            }
            if (vidas == 1)
            {
                vida_image2.SetActive(false);
            }
            if (vidas == 0)
            {
                vida_image3.SetActive(false);
                Invoke("GameOver", 1);
                //Player_Body.GetComponent<Rigidbody2D>.
                player.GetComponent<Animator>().Play("Alien_Morte");
            }
        }
    }


    void GameOver()
    {
        gameover.SetActive(true);
        player.SetActive(false);
    }
    
	public void Restart(string fase)
    {
        SceneManager.LoadScene(fase);
    }
}
