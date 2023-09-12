using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UI;
using UnityEngine.UI;

public class Tets : MonoBehaviour
{
    MeshFilter meshFilter;
    public Image img;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {

        return;
        ////查看源码调试 过程
        btn.onClick.AddListener(() =>
        {
            Debug.Log("点击响应");
        });

        Debug.Log(img.preferredWidth);
        Debug.Log(img.preferredHeight);
        // 这一帧 设置color属性 =》  Graphic的基类 SetVerticesDirty =》添加 接口ICanvasElement 进入CanvasUpdateRegistry 的渲染 容器。 =》下一帧
        img.color = Color.green;
        //下一帧 Canvas.willRenderCanvases事件 =》进入CanvasUpdateRegistry的方法PerformUpdate =》   把  CanvasUpdateRegistry 的ICanvasElement渲染容器 按顺序调用并移除。 完成一次 渲染（如果 也添加进了 ICanvasElement布局容器 ，先整体把 布局调用 ，然后 在渲染） 

        //btn.GetComponentInChildren<Text>().text = "545";

        Debug.Log(222);
    }
    public void ClickTest()
    {
        Debug.Log("点击响应");
    }
    public void ClickTestCube()
    {
        Debug.Log("Cube");
    }


    // Update is called once per frame
    void Update()
    {

        //Debug.Log("img.depth" + img.depth);
        //if (Input.anyKeyDown)
        //{
        //    RaycastHit hit;
        //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    bool isHit = Physics.Raycast(ray, out hit);
        //    if (isHit)
        //    {
        //        Debug.Log(hit.collider.gameObject.name);

        //    }

        //}



        meshFilter = GetComponent<MeshFilter>();
        VertexHelper vertexHelper = new VertexHelper();
        Color color = Color.red;
        vertexHelper.AddVert(new Vector2(0, 0), color, new Vector2(0, 0));
        vertexHelper.AddVert(new Vector2(1, 1), color, new Vector2(1, 1));
        vertexHelper.AddVert(new Vector2(0, 1), color, new Vector2(0, 1));
        vertexHelper.AddVert(new Vector2(1, 0), color, new Vector2(1, 0));
        //三角形状的 0 1 2 3 分别对应 上面添加的 坐标顺序。
        vertexHelper.AddTriangle(0, 1, 2);
        vertexHelper.AddTriangle(0, 3, 1);
        vertexHelper.FillMesh(meshFilter.mesh);



    }
}
