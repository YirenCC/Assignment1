using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    Rigidbody m_Rigidbody;
    public float m_Speed;
    public float m_JumpSpeed;


	// Use this for initialization
	void Start ()
    {
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * m_Speed, m_Rigidbody.velocity.y, Input.GetAxis("Vertical") * m_Speed);
        
        if(Input.GetButtonDown("Jump"))
        {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_JumpSpeed, m_Rigidbody.velocity.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "DialogueZone")
        {
            Debug.LogWarning("Enter Region");
            GameObject.FindObjectOfType<Dialogue>().ShowBox();
        }
   }

}
