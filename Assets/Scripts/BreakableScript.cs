using UnityEngine;
using System.Collections;

public class BreakableScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        
	}

	private void preBreak(Collision2D collider){
		if (collider.gameObject.GetComponent<CrusherScript>() != null)
		{
			CrusherScript crush = collider.gameObject.GetComponent<CrusherScript>();
			if(crush.crushing == true)
			{
				startBreak();
				GameObject.Destroy(this.gameObject);
			}
		}
		if (collider.gameObject.GetComponent<Crusher2Script>() != null)
		{
			Crusher2Script crush = collider.gameObject.GetComponent<Crusher2Script>();
			if(crush.crushing == true)
			{
				startBreak();
				GameObject.Destroy(this.gameObject);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collider){
		preBreak(collider);
	}

    void OnCollisionStay2D(Collision2D collider)
    {
		preBreak(collider);

    }

	void startBreak()
	{
		Vector3 pos = this.transform.position;
		Vector3 rotat = this.transform.eulerAngles;
		Vector3 scale = this.transform.localScale;

		GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube1.AddComponent("DestroyInvisibleObject");
		cube1.transform.position = pos + new Vector3 (-0.004196f, 0.0169106f, -0.1f);
		cube1.transform.Rotate (rotat.x, rotat.y, rotat.z -21.96021f);
		cube1.transform.localScale = new Vector3(scale.x * 0.206956f,scale.y,scale.z * 0.1f);
		cube1.renderer.material = Resources.Load("Materials/breakWood1", typeof(Material)) as Material;
		cube1.AddComponent<Rigidbody>();
		float rot = Random.Range (-50f, 50f);
		cube1.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube1.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);

		GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube2.AddComponent("DestroyInvisibleObject");
		cube2.transform.position = pos + new Vector3 (0, -0.4363046f, -0.1f);
		cube2.transform.localScale = new Vector3(scale.x,scale.y * 0.0210031f,scale.z * 0.1f);
		cube1.transform.Rotate (rotat.x, rotat.y, rotat.z);
		cube2.renderer.material = Resources.Load("Materials/breakWood2", typeof(Material)) as Material;
		cube2.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube2.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube2.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);

		GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube3.AddComponent("DestroyInvisibleObject");
		cube3.transform.position = pos + new Vector3 (0, 0.4243382f, -0.1f);
		cube3.transform.localScale = new Vector3(scale.x,scale.y * 0.0190131f,scale.z * 0.1f);
		cube1.transform.Rotate (rotat.x, rotat.y, rotat.z);
		cube3.renderer.material = cube2.renderer.material;
		cube3.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube3.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube3.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);


		GameObject cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube4.AddComponent("DestroyInvisibleObject");
		cube4.transform.position = pos + new Vector3 (-0.402901f, 0, -0.1f);
		cube4.transform.localScale = new Vector3(scale.x * 0.1929205f,scale.y,scale.z * 0.1f);
		cube4.transform.Rotate (rotat.x + 0, rotat.y + 0, rotat.z + 180);
		cube4.renderer.material = Resources.Load("Materials/breakWood3", typeof(Material)) as Material;
		cube4.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube4.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube4.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);

		GameObject cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube5.AddComponent("DestroyInvisibleObject");
		cube5.transform.position = pos + new Vector3 (-0.234429f, 0, -0.1f);
		cube5.transform.localScale = new Vector3(scale.x * 0.2025665f,scale.y,scale.z * 0.1f);
		cube5.transform.Rotate (rotat.x + 0, rotat.y + 0, rotat.z + 180);
		cube5.renderer.material = cube4.renderer.material;
		cube5.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube5.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube5.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);

		GameObject cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube6.AddComponent("DestroyInvisibleObject");
		cube6.transform.position = pos + new Vector3 (0.002002f, 0, -0.1f);
		cube6.transform.localScale = new Vector3(scale.x * 0.2685978f,scale.y,scale.z * 0.1f);
		cube6.transform.Rotate (rotat.x + 0, rotat.y + 0, rotat.z + 180);
		cube6.renderer.material = cube4.renderer.material;
		cube6.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube6.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube6.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);

		GameObject cube7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube7.AddComponent("DestroyInvisibleObject");
		cube7.transform.position = pos + new Vector3 (0.198314f, 0, -0.1f);
		cube7.transform.localScale = new Vector3(scale.x * 0.2960871f,scale.y,scale.z * 0.1f);
		cube7.transform.Rotate (rotat.x + 0, rotat.y + 0, rotat.z + 180);
		cube7.renderer.material = cube4.renderer.material;
		cube7.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube7.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube7.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);

		GameObject cube8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube8.AddComponent("DestroyInvisibleObject");
		cube8.transform.position = pos + new Vector3 (0.374595f, 0, -0.1f);
		cube8.transform.localScale = new Vector3(scale.x * 0.2553751f,scale.y,scale.z * 0.1f);
		cube8.transform.Rotate (rotat.x + 0, rotat.y + 0, rotat.z + 180);
		cube8.renderer.material = cube4.renderer.material;
		cube8.AddComponent<Rigidbody>();
		rot = Random.Range (-50f, 50f);
		cube8.rigidbody.AddTorque (new Vector3(rot,rot,rot));
		cube8.rigidbody.AddForce (10 * Mathf.Abs (rot) * Vector3.right);
	}


}
