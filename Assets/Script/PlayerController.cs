using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D _rg;
    float speed = 5f;
    private Animator _playerAnimator;
    public static PlayerController instance;

    private bool canMove = true;

    public string areaTransetionName;

    private Vector3 bottomLeft;
    private Vector3 topRight;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
    }

   
    void Update()
    {
        if(canMove == true)
        {
            Movement();
        }
        
    }

    private void Movement()
    {
        float Hmove = Input.GetAxisRaw("Horizontal");
        float Vmove = Input.GetAxisRaw("Vertical");
        _playerAnimator.SetFloat("moveX", Hmove);
        _playerAnimator.SetFloat("moveY", Vmove);

        _rg.velocity = new Vector2(Hmove*speed,Vmove*speed);

        if(Hmove == 1|| Hmove ==-1||Vmove==1||Vmove == -1)
        {
            _playerAnimator.SetFloat("lastMoveX",Hmove);
            _playerAnimator.SetFloat("lastMoveY", Vmove);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeft.x, topRight.x), Mathf.Clamp(transform.position.y, bottomLeft.y, topRight.y), transform.position.z);

    }

    public void setcanwalk(float can)
    {
        speed = can;
    }

    public void playerLimit(Vector3 Lower,Vector3 Uper)
    {
        bottomLeft = Lower + new Vector3(1f, 1f, 0);
        topRight = Uper + new Vector3(-1f, -1f, 0);
    }

    public void setWalkState(bool can)
    {
        canMove = can;
    }
}
