using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    public static CollisionManager instance;
    public static CollisionManager Instance { get { return instance; } }

    private List<CollisionClass> collectedCollisions;
    private GameObject colliderGO;
    private GameObject collideeGO;
    private string colliderGOtag;
    private string collideeGOtag;

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
          	DontDestroyOnLoad(gameObject);
        }
    }
    
    public void CollectCollisions(CollisionClass collision) {
        collectedCollisions.Add(collision);
    }

    private void Update() {
        if (collectedCollisions.Count != 0) {
            foreach (CollisionClass collision in collectedCollisions) {
                ProcessCollision(collision);
            }
        }
        
        if (collectedCollisions.Count != 0) {
            collectedCollisions.Clear();
        }

        
    }

    private void ProcessCollision(CollisionClass collision) {
        colliderGO = collision.GetColliderGO();
        collideeGO = collision.GetCollideeGO();
        colliderGOtag = collision.GetColliderGOtag();
        collideeGOtag = collision.GetCollideeGOtag();

        // Collisions can be interpreted via the names of the objects & their tags with nested if logic below
        if (colliderGO.name == "1") {

            if (collideeGO.name == "a") {

                Debug.Log(colliderGO.name + " collidied into " + collideeGO.name);
                Debug.Log("tags are " + colliderGOtag + " " + collideeGOtag);

            } else if (collideeGO.name == "b") {

                Debug.Log(colliderGO.name + " collidied into " + collideeGO.name);
                Debug.Log("tags are " + colliderGOtag + " " + collideeGOtag);
            }

        } else if (colliderGO.name == "2") {

            if (collideeGO.name == "a") {

                Debug.Log(colliderGO.name + " collidied into " + collideeGO.name);
                Debug.Log("tags are " + colliderGOtag + " " + collideeGOtag);

            } else if (collideeGO.name == "b") {

                Debug.Log(colliderGO.name + " collidied into " + collideeGO.name);
                Debug.Log("tags are " + colliderGOtag + " " + collideeGOtag);
            }
        }
    }
}
