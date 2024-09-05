// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002527")]
  [RequireComponent(typeof (GridInputHandler), typeof (BoxCollider))]
  public sealed class GridBehaviour : MonoBehaviour
  {
    [Token(Token = "0x4009F95")]
    [FieldOffset(Offset = "0x18")]
    private BoxCollider boxCollider;
    [Token(Token = "0x4009F96")]
    [FieldOffset(Offset = "0x20")]
    private GridInputHandler inputHandler;
    [Token(Token = "0x4009F98")]
    [FieldOffset(Offset = "0x30")]
    private float baseWidth;
    [Token(Token = "0x4009F99")]
    [FieldOffset(Offset = "0x34")]
    private float baseHeight;
    [Token(Token = "0x4009F9A")]
    [FieldOffset(Offset = "0x38")]
    private float basePosY;
    [Token(Token = "0x4009F9B")]
    [FieldOffset(Offset = "0x3C")]
    private float baseHeightOffset;

    [Token(Token = "0x1700314E")]
    public GridObject GridObject
    {
      [Token(Token = "0x600E587"), Address(RVA = "0x4868FA4", Offset = "0x4868FA4", VA = "0x4868FA4")] get
      {
        return (GridObject) null;
      }
      [Token(Token = "0x600E588"), Address(RVA = "0x4868FAC", Offset = "0x4868FAC", VA = "0x4868FAC")] private set
      {
      }
    }

    [Token(Token = "0x600E589")]
    [Address(RVA = "0x4868FB4", Offset = "0x4868FB4", VA = "0x4868FB4")]
    public void Initialize(
      GridObject gridObject,
      float panelWidth,
      float panelHeight,
      float panelPositionY,
      float heightOffset)
    {
    }

    [Token(Token = "0x600E58A")]
    [Address(RVA = "0x4869194", Offset = "0x4869194", VA = "0x4869194")]
    public void Set(float panelWidth, float panelHeight, float panelPositionY)
    {
    }

    [Token(Token = "0x600E58B")]
    [Address(RVA = "0x4869224", Offset = "0x4869224", VA = "0x4869224")]
    public void AdjustPosY(float offsetY)
    {
    }

    [Token(Token = "0x600E58C")]
    [Address(RVA = "0x48692F4", Offset = "0x48692F4", VA = "0x48692F4")]
    public GridBehaviour()
    {
    }
  }
}
