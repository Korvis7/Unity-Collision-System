using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private GameObject collisionManagerGO;
    //private CollisionManager collisionManager;
    private string collideeGOtag;
    private CollisionClass thisCollision;

    private void OnTriggerEnter(Collider collidee){
        ProcessCollision(collidee.gameObject);
    }
    private void OnCollisionEnter(Collision collidee){
        ProcessCollision(collidee.gameObject);
    }
    void ProcessCollision(GameObject collideeGO){
        collideeGOtag = collideeGO.tag;

        //create a Collision class instance with current GO tag & collideeGO tag & send it to the CollisionManager to be added to the collection
        thisCollision = new CollisionClass(this.gameObject, this.gameObject.tag, collideeGO, collideeGOtag);
        CollisionManager.instance.CollectCollisions(thisCollision);
    }
}
