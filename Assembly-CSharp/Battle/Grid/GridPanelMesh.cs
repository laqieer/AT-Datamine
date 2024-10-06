// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridPanelMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002530")]
  [RequireComponent(typeof (MeshFilter), typeof (MeshRenderer))]
  public class GridPanelMesh : SimplePlaneMesh
  {
    [Token(Token = "0x4009FD3")]
    private const int JOB_COUNTS = 32;
    [Token(Token = "0x4009FD4")]
    private const int INDICES_PER_PLANE = 6;
    [Token(Token = "0x4009FD5")]
    private const int VERTECIES_PER_PLANE = 4;
    [Token(Token = "0x4009FD6")]
    private const int VERTECIES_PER_PLANE_SEGMENT = 2;
    [Token(Token = "0x4009FD7")]
    private const int CELLINFO_IDX_ACTION_RANGE = 0;
    [Token(Token = "0x4009FD8")]
    private const int CELLINFO_IDX_COUTION_RANGE = 1;
    [Token(Token = "0x4009FD9")]
    private const int CELLINFO_IDX_FIERCE_RANGE = 2;
    [Token(Token = "0x4009FDA")]
    private const int CELLINFO_IDX_MOVE_ROOT = 3;
    [Token(Token = "0x4009FDB")]
    private const int CELLINFO_MAX = 7;
    [Token(Token = "0x4009FDC")]
    private const float HEIGHT_ORDER_RANGE = 0.1f;
    [Token(Token = "0x4009FDD")]
    [FieldOffset(Offset = "0x38")]
    private float[] vertHeights3d;
    [Token(Token = "0x4009FDE")]
    [FieldOffset(Offset = "0x40")]
    private int[] indicesOrderedByHeights3d;
    [Token(Token = "0x4009FDF")]
    [FieldOffset(Offset = "0x48")]
    private Vector2[][] rangePanelCellInfos;
    [Token(Token = "0x4009FE0")]
    [FieldOffset(Offset = "0x50")]
    private bool modified;

    [Token(Token = "0x600E5BC")]
    [Address(RVA = "0x4869E30", Offset = "0x4869E30", VA = "0x4869E30", Slot = "4")]
    public override void CreateMesh(
      float planeWidth,
      float planeHeight,
      int partitionX,
      int partitionY)
    {
    }

    [Token(Token = "0x600E5BD")]
    [Address(RVA = "0x486A40C", Offset = "0x486A40C", VA = "0x486A40C")]
    public void CreateMesh(
      float planeWidth,
      float planeHeight,
      List<List<float>> heights3d,
      int partitionX,
      int partitionY)
    {
    }

    [Token(Token = "0x600E5BE")]
    [Address(RVA = "0x486A544", Offset = "0x486A544", VA = "0x486A544")]
    public void CreateMesh(
      float planeWidth,
      float planeHeight,
      float[] heights3d,
      int partitionX,
      int partitionY)
    {
    }

    [Token(Token = "0x600E5BF")]
    [Address(RVA = "0x4869E40", Offset = "0x4869E40", VA = "0x4869E40")]
    private void CreateMeshInternal(
      float planeWidth,
      float planeHeight,
      float[] heights3d,
      int partitionX,
      int partitionY)
    {
    }

    [Token(Token = "0x600E5C0")]
    [Address(RVA = "0x486A600", Offset = "0x486A600", VA = "0x486A600", Slot = "5")]
    protected override void CreateVertices(
      float planeWidth,
      float planeHeight,
      int partitionX,
      int partitionY,
      out Vector3[] verts,
      out Vector2[] uvs)
    {
    }

    [Token(Token = "0x600E5C1")]
    [Address(RVA = "0x486A8B8", Offset = "0x486A8B8", VA = "0x486A8B8", Slot = "6")]
    protected override int[] CreateIndices(int partitionX, int partitionY) => (int[]) null;

    [Token(Token = "0x600E5C2")]
    [Address(RVA = "0x486AAA8", Offset = "0x486AAA8", VA = "0x486AAA8", Slot = "7")]
    protected override void OnUpdateMesh(Vector3[] verts, Vector2[] uvs, int[] indices)
    {
    }

    [Token(Token = "0x600E5C3")]
    [Address(RVA = "0x486AB78", Offset = "0x486AB78", VA = "0x486AB78")]
    public void SetGridCellInfoAt(
      int x,
      int y,
      int basePanelCellNo,
      int baseAngle,
      int overridePanelCellNo,
      int overrideAngle)
    {
    }

    [Token(Token = "0x600E5C4")]
    [Address(RVA = "0x486AC44", Offset = "0x486AC44", VA = "0x486AC44")]
    public void SetSubOverrideCellInfoAt(int x, int y, int cellNo, int angle)
    {
    }

    [Token(Token = "0x600E5C5")]
    [Address(RVA = "0x486ACE0", Offset = "0x486ACE0", VA = "0x486ACE0")]
    public void SetPredictionMoveCellInfoAt(int x, int y, int cellNo, int angle)
    {
    }

    [Token(Token = "0x600E5C6")]
    [Address(RVA = "0x486AD84", Offset = "0x486AD84", VA = "0x486AD84")]
    public void ClearAllGridCellInfo()
    {
    }

    [Token(Token = "0x600E5C7")]
    [Address(RVA = "0x486ADB8", Offset = "0x486ADB8", VA = "0x486ADB8")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600E5C8")]
    [Address(RVA = "0x486AAB4", Offset = "0x486AAB4", VA = "0x486AAB4")]
    public void ApplyCellInfoIfModified()
    {
    }

    [Token(Token = "0x600E5C9")]
    [Address(RVA = "0x486ADBC", Offset = "0x486ADBC", VA = "0x486ADBC")]
    public GridPanelMesh()
    {
    }

    [Token(Token = "0x2002531")]
    public new struct JobCreateVertsAndUvs : IJobParallelFor, IDisposable
    {
      [Token(Token = "0x4009FE1")]
      [FieldOffset(Offset = "0x0")]
      [ReadOnly]
      public int partitionX;
      [Token(Token = "0x4009FE2")]
      [FieldOffset(Offset = "0x4")]
      [ReadOnly]
      public int partitionY;
      [Token(Token = "0x4009FE3")]
      [FieldOffset(Offset = "0x8")]
      [ReadOnly]
      public float width;
      [Token(Token = "0x4009FE4")]
      [FieldOffset(Offset = "0xC")]
      [ReadOnly]
      public float height;
      [Token(Token = "0x4009FE5")]
      [FieldOffset(Offset = "0x10")]
      [ReadOnly]
      public float partitionWidth;
      [Token(Token = "0x4009FE6")]
      [FieldOffset(Offset = "0x14")]
      [ReadOnly]
      public float partitionHeight;
      [Token(Token = "0x4009FE7")]
      [FieldOffset(Offset = "0x18")]
      [ReadOnly]
      public NativeArray<float> heights3d;
      [Token(Token = "0x4009FE8")]
      [FieldOffset(Offset = "0x28")]
      public NativeArray<Vector3> verts;
      [Token(Token = "0x4009FE9")]
      [FieldOffset(Offset = "0x38")]
      public NativeArray<Vector2> uvs;

      [Token(Token = "0x600E5CA")]
      [Address(RVA = "0x486ADCC", Offset = "0x486ADCC", VA = "0x486ADCC", Slot = "4")]
      public void Execute(int index)
      {
      }

      [Token(Token = "0x600E5CB")]
      [Address(RVA = "0x486AEF0", Offset = "0x486AEF0", VA = "0x486AEF0", Slot = "5")]
      public void Dispose()
      {
      }

      [Token(Token = "0x600E5CC")]
      [Address(RVA = "0x486AE54", Offset = "0x486AE54", VA = "0x486AE54")]
      public Vector3 CreateVertex(int index, int rectIndex, int xIndex, int yIndex)
      {
        return new Vector3();
      }

      [Token(Token = "0x600E5CD")]
      [Address(RVA = "0x486AEB0", Offset = "0x486AEB0", VA = "0x486AEB0")]
      public Vector2 CreateUV(int xIndex, int yIndex) => new Vector2();
    }

    [Token(Token = "0x2002532")]
    public new struct JobCreateIndices : IJobParallelFor, IDisposable
    {
      [Token(Token = "0x4009FEA")]
      [FieldOffset(Offset = "0x0")]
      [ReadOnly]
      public int partitionX;
      [Token(Token = "0x4009FEB")]
      [FieldOffset(Offset = "0x4")]
      [ReadOnly]
      public int partitionY;
      [Token(Token = "0x4009FEC")]
      [FieldOffset(Offset = "0x8")]
      [ReadOnly]
      public NativeArray<int> indicesHeights3d;
      [Token(Token = "0x4009FED")]
      [FieldOffset(Offset = "0x18")]
      public NativeArray<int> indices;

      [Token(Token = "0x600E5CE")]
      [Address(RVA = "0x486AF80", Offset = "0x486AF80", VA = "0x486AF80", Slot = "4")]
      public void Execute(int index)
      {
      }

      [Token(Token = "0x600E5CF")]
      [Address(RVA = "0x486AFEC", Offset = "0x486AFEC", VA = "0x486AFEC", Slot = "5")]
      public void Dispose()
      {
      }
    }
  }
}
