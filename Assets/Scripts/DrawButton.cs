using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class DrawButton : MonoBehaviour
{
    //可以被渲染 ，  可以被点击
    public UnityEngine.Color color;
    public Texture texture;
    Mesh mesh;

    public void Start()
    {
        DrawImg();
    }

    void DrawImg()
    {

        //需要有mesh 网格=》，由 三角面 => 顶点  
        mesh = new Mesh();
        VertexHelper vh = new VertexHelper();

        //uv的 混合色 
        UnityEngine.Color color32 = color;


        //Texture2D.g
        vh.AddVert(new Vector3(0, 0), color32, new Vector2(0, 0));
        vh.AddVert(new Vector3(0, 54), color32, new Vector2(0, 1));
        vh.AddVert(new Vector3(128, 54), color32, new Vector2(1, 1));
        vh.AddVert(new Vector3(128, 0), color32, new Vector2(1, 0));
        // 使用这些顶点组成 绘制 网格的 三角面
        vh.AddTriangle(0, 1, 2);
        vh.AddTriangle(2, 3, 0);
        //生成 网格
        vh.FillMesh(mesh);
        //uv 贴图 贴合这个 mesh  ，MeshFilter 设置完成后    MeshRender就对其进行渲染 。，
        GetComponent<MeshFilter>().mesh = mesh;
        //GetComponent<MeshRenderer>().material.mainTexture = texture;

        //生成boxCollider
        gameObject.AddComponent<BoxCollider>();



    }
    //被点击的事件 
    void OnMouseDown()
    {
        Debug.Log("被点击了");

    }



    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = color;
        GetComponent<MeshRenderer>().material.mainTexture = texture;

    }
}
