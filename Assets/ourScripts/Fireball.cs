using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Gamekit3D{
public class Fireball : MonoBehaviour {
	public float speed = 10.0f;
	public int damage = 1;
	protected Vector3 m_Direction;
	protected GameObject m_Owner;
	protected bool m_IsThrowingHit = false;

	void Update() {
		transform.Translate(0, 0, speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		Damageable d = other.GetComponentInParent<Damageable>();
		Debug.Log(other);
		Damageable.DamageMessage message = new Damageable.DamageMessage
        {
            damageSource = transform.position,
            damager = this,
           amount = damage,
            direction = (other.transform.position - transform.position).normalized,
            throwing = false
        };

                
		//Damageable.DamageMessage data;

		//data.amount = damage;
        //data.damager = this;
        //data.direction = m_Direction.normalized;
        //data.damageSource = GameObject.Find("Ellen").transform.position;
        //data.throwing = m_IsThrowingHit;
        //data.stopCamera = false;
		


		Debug.Log("Hi");
		Debug.Log(other.tag);
		string EnemyTag = "Enemy";
		if(other.tag == EnemyTag){
			Debug.Log("Sup");
			GameObject Enemy = GameObject.FindGameObjectWithTag(EnemyTag);
			Gamekit3D.Damageable damageableScript = Enemy.GetComponent<Gamekit3D.Damageable>();
			damageableScript.maxHitPoints -= 1;
			d.ApplyDamage(message);
		}

		if(other.tag != "InfoZone" && other.tag != "Checkpoint" || other.gameObject.tag == "Enemy"){
			Destroy(this.gameObject);
		}
	}
}
}
