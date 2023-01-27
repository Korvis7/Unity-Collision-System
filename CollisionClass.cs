using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionClass : Object {

    private GameObject colliderGO;
    private string colliderGOtag;
    private GameObject collideeGO;
    private string collideeGOtag;

    public CollisionClass(GameObject colliderGO, string colliderGOtag, GameObject collideeGO, string collideeGOtag) {
        this.colliderGO = colliderGO;
        this.colliderGOtag = colliderGOtag;
        this.collideeGO = collideeGO;
        this.collideeGOtag = collideeGOtag;
    }

    public GameObject GetColliderGO() {
        return colliderGO;
    }
    
    public GameObject GetCollideeGO() {
        return collideeGO;
    }

    public string GetColliderGOtag() {
        return colliderGOtag;
    }

    public string GetCollideeGOtag() {
        return collideeGOtag;
    }

}