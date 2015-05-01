using UnityEngine;
using System.Collections;

public class GhostFollow : MonoBehaviour {

    public Transform target;
    public Transform self;

    Player player;

    public float currentDistance;
    public float smoothTime = 0.05f;

    public Vector3 offset;

    public float bobbingAmount;
    public float bobbingSpeed;
    public Vector3 bobOffset;

    void Start() {
        target = GameObject.FindGameObjectWithTag( "Player" ).transform;
        self = transform;
        player = target.GetComponent<Player>();
    }

    void Update() {
        currentDistance = Vector2.Distance( self.position, target.position );

        //Bobbing motion
        bobOffset = new Vector3( 0, Mathf.Sin( Time.time * bobbingSpeed ) * bobbingAmount, 0 );
        
        offset = new Vector3( Mathf.Abs(offset.x) * -(int)player.facingDirection, offset.y, offset.z ); //Flip facing direction so ghost is on opposite side
        self.position = Vector3.Lerp( self.position, target.position + offset + bobOffset, smoothTime );     
    }
}