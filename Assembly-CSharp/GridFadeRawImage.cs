// Decompiled with JetBrains decompiler
// Type: GridFadeRawImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000190")]
public class GridFadeRawImage : RawImage
{
  [Token(Token = "0x4000A35")]
  [FieldOffset(Offset = "0xE8")]
  [SerializeField]
  private Vector2 m_dimensions;
  [Token(Token = "0x4000A36")]
  [FieldOffset(Offset = "0xF0")]
  [SerializeField]
  private float m_progress;

  [Token(Token = "0x170000CF")]
  public Vector2 dimensions
  {
    [Token(Token = "0x6000ABE"), Address(RVA = "0x4BBAAF4", Offset = "0x4BBAAF4", VA = "0x4BBAAF4")] get
    {
      return new Vector2();
    }
    [Token(Token = "0x6000ABF"), Address(RVA = "0x4BBAAFC", Offset = "0x4BBAAFC", VA = "0x4BBAAFC")] set
    {
    }
  }

  [Token(Token = "0x170000D0")]
  public float progress
  {
    [Token(Token = "0x6000AC0"), Address(RVA = "0x4BBAB10", Offset = "0x4BBAB10", VA = "0x4BBAB10")] get
    {
      return new float();
    }
    [Token(Token = "0x6000AC1"), Address(RVA = "0x4BBAB18", Offset = "0x4BBAB18", VA = "0x4BBAB18")] set
    {
    }
  }

  [Token(Token = "0x6000AC2")]
  [Address(RVA = "0x4BBAB2C", Offset = "0x4BBAB2C", VA = "0x4BBAB2C", Slot = "58")]
  public override Material GetModifiedMaterial(Material baseMaterial) => (Material) null;

  [Token(Token = "0x6000AC3")]
  [Address(RVA = "0x4BBABC8", Offset = "0x4BBABC8", VA = "0x4BBABC8")]
  public GridFadeRawImage()
  {
  }
}
