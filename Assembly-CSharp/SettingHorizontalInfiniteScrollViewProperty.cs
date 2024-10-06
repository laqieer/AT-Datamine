// Decompiled with JetBrains decompiler
// Type: SettingHorizontalInfiniteScrollViewProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D0")]
public struct SettingHorizontalInfiniteScrollViewProperty
{
  [Token(Token = "0x4001065")]
  [FieldOffset(Offset = "0x0")]
  public float CellScale;
  [Token(Token = "0x4001066")]
  [FieldOffset(Offset = "0x8")]
  public RectOffset Padding;
  [Token(Token = "0x4001067")]
  [FieldOffset(Offset = "0x10")]
  public Vector2 Spacing;
  [Token(Token = "0x4001068")]
  [FieldOffset(Offset = "0x18")]
  public int RowCount;
  [Token(Token = "0x4001069")]
  [FieldOffset(Offset = "0x1C")]
  public bool IsAtLeft;
  [Token(Token = "0x400106A")]
  [FieldOffset(Offset = "0x1D")]
  public bool IsAtRight;

  [Token(Token = "0x6001195")]
  [Address(RVA = "0x1BF3F30", Offset = "0x1BF3F30", VA = "0x1BF3F30")]
  public SettingHorizontalInfiniteScrollViewProperty(
    float cellScale,
    RectOffset padding,
    Vector2 spacing,
    int rowCount,
    bool isAtLeft,
    bool isAtRight)
  {
  }
}
