// Decompiled with JetBrains decompiler
// Type: InfiniteCellData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D4")]
public class InfiniteCellData
{
  [Token(Token = "0x4001076")]
  [FieldOffset(Offset = "0x10")]
  public int index;
  [Token(Token = "0x4001077")]
  [FieldOffset(Offset = "0x14")]
  public Vector2 cellSize;
  [Token(Token = "0x4001078")]
  [FieldOffset(Offset = "0x20")]
  public object data;

  [Token(Token = "0x60011B1")]
  [Address(RVA = "0x27D7470", Offset = "0x27D7470", VA = "0x27D7470")]
  public InfiniteCellData()
  {
  }

  [Token(Token = "0x60011B2")]
  [Address(RVA = "0x27D7478", Offset = "0x27D7478", VA = "0x27D7478")]
  public InfiniteCellData(float width, float height)
  {
  }

  [Token(Token = "0x60011B3")]
  [Address(RVA = "0x27D74A4", Offset = "0x27D74A4", VA = "0x27D74A4")]
  public InfiniteCellData(Vector2 cellSize)
  {
  }

  [Token(Token = "0x60011B4")]
  [Address(RVA = "0x27D74D0", Offset = "0x27D74D0", VA = "0x27D74D0")]
  public InfiniteCellData(Vector2 cellSize, object data)
  {
  }
}
