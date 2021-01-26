using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public float speed;//相机移动速度
    public Transform target;//目标坐标

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                new Vector3(target.position.x, target.position.y, 
                transform.position.z), speed * Time.deltaTime);
        }
    }

    //函数方法在Room中判断碰撞进入后调用，新房间的坐标
    public void ChangeTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
