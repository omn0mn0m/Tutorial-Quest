using UnityEngine;
using System.Collections;

public class Parallaxing : MonoBehaviour {
	
	public Transform[] layers;				// Array of layers to be parallaxed
	private float[] parallaxScales;			// Scaling factors of the camera movement to move each layer
	
	public float parallaxingAmount = 1f;	// How much to smooth the parallaxing (Cannout be 0.0)
	
	private Transform camera;				// Main Camera reference
	private Vector3 previousCameraPosition;	// The position of the camera in the previous frame

	// Called before Start()
	void Awake () {
		camera = Camera.main.transform;
	}
	
	// Use this for initialization
	void Start () {
		previousCameraPosition = camera.position;		// Sets the previous camera position to the current one
		
		parallaxScales = new float[layers.Length];		// Instantiates the parallax scale array with as many elements as layers
		for (int i = 0; i < layers.Length; i++) {
			parallaxScales[i] = layers[i].position.z * -1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < layers.Length; i++) {
			float parallax = (previousCameraPosition.x - camera.position.x) * parallaxScales[i];
			float layerTargetPositionX = layers[i].position.x + parallax;
			Vector3 layerTargetPosition = new Vector3(layerTargetPositionX, layers[i].position.y, layers[i].position.z);
			layers[i].position = Vector3.Lerp (layers[i].position, layerTargetPosition, parallaxingAmount * Time.deltaTime);
		}
		
		previousCameraPosition = camera.position;
	}
	
	
}
