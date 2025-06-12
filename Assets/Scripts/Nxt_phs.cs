using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Nxt_phs : MonoBehaviour
{
    public GameObject player;
    public GameObject platf;
    public GameObject ac,pain,temp;
    public Player_Movement pm;
    public Player_Movement2 pm2;
    private Rigidbody2D rb;
    public AudioSource aud;
    public Animator a;
    public Animator stun;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        pm=player.GetComponent<Player_Movement>();
        pm2=player.GetComponent<Player_Movement2>();
        //PlayerPrefs.SetInt("rn1",Random.Range(1,1));
        //PlayerPrefs.SetInt("rn2",Random.Range(1,1));
        //PlayerPrefs.SetInt("rn3",Random.Range(1,1));
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
	if(other.gameObject.CompareTag("nxt_phs1"))
    {
        PlayerPrefs.SetFloat("a",1f);
		SceneManager.LoadScene("Platformer1_"+PlayerPrefs.GetInt("rn1",1).ToString());
        
    }
    if(other.gameObject.CompareTag("nxt_phs2"))
    {
        PlayerPrefs.SetFloat("a",1f);
		SceneManager.LoadScene("Platformer2_"+PlayerPrefs.GetInt("rn2",1).ToString());
        
    }
	if(other.gameObject.CompareTag("nxt_phs3"))
    {
        PlayerPrefs.SetFloat("a",1f);
		SceneManager.LoadScene("Platformer3_"+PlayerPrefs.GetInt("rn3",1).ToString());
    }
    if(other.gameObject.CompareTag("prv_phs"))
    {
        //Time.timeScale=0f;
        PlayerPrefs.SetFloat("a",0f);
        SceneManager.LoadScene("FD");
		//if(Input.GetKeyDown(KeyCode.Space)) 
       // {
            //Time.timeScale=1f;
           // SceneManager.LoadScene("Platformer1_"+PlayerPrefs.GetInt("rn1",1).ToString());
       // }
       // else
           // PlayerPrefs.SetFloat("a",0f);
    }
    if(other.gameObject.CompareTag("st_phs"))
    {
        PlayerPrefs.SetFloat("a",1f);
        SceneManager.LoadScene("Platformer1_"+PlayerPrefs.GetInt("rn1",1).ToString());
    }
    if(other.gameObject.CompareTag("g"))
    {
        PlayerPrefs.SetFloat("a",1f);
    }
    if(other.gameObject.CompareTag("win"))
    {
        PlayerPrefs.SetFloat("a",0f);
        if(PlayerPrefs.GetInt("lap")>=1)
            SceneManager.LoadScene("Win");
        else if(PlayerPrefs.GetInt("lap")==0)
        {
            PlayerPrefs.SetInt("lap",1);
            SceneManager.LoadScene(PlayerPrefs.GetString("map"));
        }
        
    }
    if(other.gameObject.CompareTag("col1"))
	{
        pm.enabled=false;
        rb.AddForce(Vector2.right*200);
        //aud.Play();
        Invoke("ply_Mo",0.3f);
    }
    if(other.gameObject.CompareTag("col2"))
	{
        pm.enabled=false;
        rb.AddForce(Vector2.left*200);
        //aud.Play();
        Invoke("ply_Mo",0.3f);
    }
    if(other.gameObject.CompareTag("P1"))
	{
        pm.enabled=false;
        rb.AddForce(Vector2.right*200);
        Invoke("ply_Mo",0.2f);
    }
    if(other.gameObject.CompareTag("P2"))
	{
        pm.enabled=false;
        rb.AddForce(Vector2.left*200);
        Invoke("ply_Mo",0.2f);
    }
    if(other.gameObject.CompareTag("snake"))
	{
        pm2.enabled=false;
        a.SetBool("walk",false);
        stun.SetBool("stun",true);
        Invoke("ply_Mo2",1f);
    }
    if(other.gameObject.CompareTag("magma"))
	{
        SceneManager.LoadScene("Loose");
    }
    if(other.gameObject.CompareTag("spike"))
	{
        player.transform.position=ac.transform.position;
        
        temp=Instantiate(pain,this.transform.position,this.transform.rotation);
        Invoke("desttemp",0.5f);
    }
    }

    void desttemp()
    {
        Destroy(temp.gameObject);
    }
    void ply_Mo()
   {
       pm.enabled=true;
   }
   void ply_Mo2()
   {
       stun.SetBool("stun",false);
       pm2.enabled=true;
   }
}