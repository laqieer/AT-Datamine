// Decompiled with JetBrains decompiler
// Type: Battle.Grid.SimplePlaneMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200253E")]
  [RequireComponent(typeof (MeshFilter), typeof (MeshRenderer))]
  public class SimplePlaneMesh : MonoBehaviour
  {
    [Token(Token = "0x400A019")]
    private const int JobCounts = 32;
    [Token(Token = "0x400A01A")]
    private const int IndicesPerPlane = 6;
    [Token(Token = "0x400A01B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Mesh mesh;
    [Token(Token = "0x400A01C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected MeshFilter meshFilter;
    [Token(Token = "0x400A01D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected MeshRenderer meshRenderer;
    [Token(Token = "0x400A01E")]
    [FieldOffset(Offset = "0x30")]
    protected int partitionX;
    [Token(Token = "0x400A01F")]
    [FieldOffset(Offset = "0x34")]
    protected int partitionY;

    [Token(Token = "0x1700316A")]
    public Mesh Mesh
    {
      [Token(Token = "0x600E607"), Address(RVA = "0x486BD0C", Offset = "0x486BD0C", VA = "0x486BD0C")] get
      {
        return (Mesh) null;
      }
    }

    [Token(Token = "0x1700316B")]
    public MeshFilter MeshFilter
    {
      [Token(Token = "0x600E608"), Address(RVA = "0x486BD14", Offset = "0x486BD14", VA = "0x486BD14")] get
      {
        return (MeshFilter) null;
      }
    }

    [Token(Token = "0x1700316C")]
    public MeshRenderer MeshRenderer
    {
      [Token(Token = "0x600E609"), Address(RVA = "0x486BD1C", Offset = "0x486BD1C", VA = "0x486BD1C")] get
      {
        return (MeshRenderer) null;
      }
    }

    [Token(Token = "0x600E60A")]
    [Address(RVA = "0x486BD24", Offset = "0x486BD24", VA = "0x486BD24")]
    public void Show()
    {
    }

    [Token(Token = "0x600E60B")]
    [Address(RVA = "0x486BD44", Offset = "0x486BD44", VA = "0x486BD44")]
    public void Hide()
    {
    }

    [Token(Token = "0x600E60C")]
    [Address(RVA = "0x486A548", Offset = "0x486A548", VA = "0x486A548", Slot = "4")]
    public virtual void CreateMesh(
      float planeWidth,
      float planeHeight,
      int partitionX,
      int partitionY)
    {
    }

    [Token(Token = "0x600E60D")]
    [Address(RVA = "0x486BD64", Offset = "0x486BD64", VA = "0x486BD64")]
    protected void CreateMeshIfNotExists()
    {
    }

    [Token(Token = "0x600E60E")]
    [Address(RVA = "0x486BE00", Offset = "0x486BE00", VA = "0x486BE00")]
    protected void CreateMeshFilterIfNotExists(Mesh mesh)
    {
    }

    [Token(Token = "0x600E60F")]
    [Address(RVA = "0x486BEEC", Offset = "0x486BEEC", VA = "0x486BEEC")]
    protected void CreateMeshRendererIfNotExists()
    {
    }

    [Token(Token = "0x600E610")]
    [Address(RVA = "0x486C0F0", Offset = "0x486C0F0", VA = "0x486C0F0", Slot = "5")]
    protected virtual void CreateVertices(
      float planeWidth,
      float planeHeight,
      int partitionX,
      int partitionY,
      out Vector3[] verts,
      out Vector2[] uvs)
    {
    }

    [Token(Token = "0x600E611")]
    [Address(RVA = "0x486C37C", Offset = "0x486C37C", VA = "0x486C37C", Slot = "6")]
    protected virtual int[] CreateIndices(int partitionX, int partitionY) => (int[]) null;

    [Token(Token = "0x600E612")]
    [Address(RVA = "0x486BFB4", Offset = "0x486BFB4", VA = "0x486BFB4")]
    protected void UpdateMesh(Vector3[] verts, Vector2[] uvs, int[] indices)
    {
    }

    [Token(Token = "0x600E613")]
    [Address(RVA = "0x486C518", Offset = "0x486C518", VA = "0x486C518", Slot = "7")]
    protected virtual void OnUpdateMesh(Vector3[] verts, Vector2[] uvs, int[] indices)
    {
    }

    [Token(Token = "0x600E614")]
    [Address(RVA = "0x486ADC4", Offset = "0x486ADC4", VA = "0x486ADC4")]
    public SimplePlaneMesh()
    {
    }

    [Token(Token = "0x200253F")]
    public struct JobCreateVertsAndUvs : IJobParallelFor, IDisposable
    {
      [Token(Token = "0x400A020")]
      [FieldOffset(Offset = "0x0")]
      [ReadOnly]
      public int partitionX;
      [Token(Token = "0x400A021")]
      [FieldOffset(Offset = "0x4")]
      [ReadOnly]
      public int partitionY;
      [Token(Token = "0x400A022")]
      [FieldOffset(Offset = "0x8")]
      [ReadOnly]
      public float width;
      [Token(Token = "0x400A023")]
      [FieldOffset(Offset = "0xC")]
      [ReadOnly]
      public float height;
      [Token(Token = "0x400A024")]
      [FieldOffset(Offset = "0x10")]
      [ReadOnly]
      public float partitionWidth;
      [Token(Token = "0x400A025")]
      [FieldOffset(Offset = "0x14")]
      [ReadOnly]
      public float partitionHeight;
      [Token(Token = "0x400A026")]
      [FieldOffset(Offset = "0x18")]
      public NativeArray<Vector3> verts;
      [Token(Token = "0x400A027")]
      [FieldOffset(Offset = "0x28")]
      public NativeArray<Vector2> uvs;

      [Token(Token = "0x600E615")]
      [Address(RVA = "0x486C51C", Offset = "0x486C51C", VA = "0x486C51C", Slot = "4")]
      public void Execute(int index)
      {
      }

      [Token(Token = "0x600E616")]
      [Address(RVA = "0x486C5FC", Offset = "0x486C5FC", VA = "0x486C5FC", Slot = "5")]
      public void Dispose()
      {
      }

      [Token(Token = "0x600E617")]
      [Address(RVA = "0x486C590", Offset = "0x486C590", VA = "0x486C590")]
      public Vector3 CreateVertex(
        int xIndex,
        int yIndex,
        float width,
        float height,
        float partitionWidth,
        float pertitionHeight)
      {
        return new Vector3();
      }

      [Token(Token = "0x600E618")]
      [Address(RVA = "0x486C5BC", Offset = "0x486C5BC", VA = "0x486C5BC")]
      public Vector2 CreateUV(int xIndex, int yIndex) => new Vector2();
    }

    [Token(Token = "0x2002540")]
    public struct JobCreateIndices : IJobParallelFor, IDisposable
    {
      [Token(Token = "0x400A028")]
      [FieldOffset(Offset = "0x0")]
      [ReadOnly]
      public int partitionX;
      [Token(Token = "0x400A029")]
      [FieldOffset(Offset = "0x4")]
      [ReadOnly]
      public int partitionY;
      [Token(Token = "0x400A02A")]
      [FieldOffset(Offset = "0x8")]
      public NativeArray<int> indices;

      [Token(Token = "0x600E619")]
      [Address(RVA = "0x486C66C", Offset = "0x486C66C", VA = "0x486C66C", Slot = "4")]
      public void Execute(int index)
      {
      }

      [Token(Token = "0x600E61A")]
      [Address(RVA = "0x486C6E0", Offset = "0x486C6E0", VA = "0x486C6E0", Slot = "5")]
      public void Dispose()
      {
      }
    }
  }
}
