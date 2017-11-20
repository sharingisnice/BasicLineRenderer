//Attach this to an empty gameobject
//Add this script as well as a line renderer component
//Don't forget to add line texture to line renderer component

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LineRendererScript : MonoBehaviour {

	LineRenderer line;
	List<Vector2> points;

	public float pointSpacing = 0.1f;
	
	[RequireComponent(typeof(LineRenderer))]

	void Start(){
		line = GetComponent<LineRenderer>();
		points = new List<Vector2>();

		SetPoint();
	}

	void Update(){

		if (Vector3.Distance(points.Last(),transform.position)> pointSpacing)
		{
			SetPoint();
		}
	}

	void SetPoint(){
		points.Add(transform.position);

		line.positionCount = points.Count;
		line.SetPosition(points.Count-1,transform.position);
	}

}
