using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NearestObjectScript : MonoBehaviour
{
    public string objectTag = "Obstacle";
    public float distanceToSearch;

    void Update()
    {
        GameObject nearestObject = FindNearestObject();
        if (nearestObject != null)
        {
            float distance = Vector3.Distance(transform.position, nearestObject.transform.position);
            if (distance < distanceToSearch)
            {
                transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
            }
        }
    }

    GameObject FindNearestObject()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(objectTag); // Find all objects with the tag
        GameObject nearestObject = null;
        float minDistance = Mathf.Infinity; // Set to a very large value to find the smallest distance

        foreach (GameObject obj in objects)
        {
            if (obj == gameObject)
            continue;

            float distance = Vector3.Distance(transform.position, obj.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestObject = obj; // Update nearest object if this one is closer
            }
        }

        return nearestObject; // Return the closest object
    }
}
