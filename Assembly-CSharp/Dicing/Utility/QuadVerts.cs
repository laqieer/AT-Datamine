// Decompiled with JetBrains decompiler
// Type: Dicing.Utility.QuadVerts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Dicing.Utility
{
  [Token(Token = "0x2001F46")]
  public class QuadVerts
  {
    [Token(Token = "0x17002693")]
    public Vector4 Vert
    {
      [Token(Token = "0x600B9B0"), Address(RVA = "0x213E4A0", Offset = "0x213E4A0", VA = "0x213E4A0")] get
      {
        return new Vector4();
      }
      [Token(Token = "0x600B9B1"), Address(RVA = "0x213E4AC", Offset = "0x213E4AC", VA = "0x213E4AC")] private set
      {
      }
    }

    [Token(Token = "0x17002694")]
    public Rect UvRect
    {
      [Token(Token = "0x600B9B2"), Address(RVA = "0x213E4B8", Offset = "0x213E4B8", VA = "0x213E4B8")] get
      {
        return new Rect();
      }
      [Token(Token = "0x600B9B3"), Address(RVA = "0x213E4C4", Offset = "0x213E4C4", VA = "0x213E4C4")] private set
      {
      }
    }

    [Token(Token = "0x17002695")]
    public bool IsAllTransparent
    {
      [Token(Token = "0x600B9B4"), Address(RVA = "0x213E4D0", Offset = "0x213E4D0", VA = "0x213E4D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B9B5"), Address(RVA = "0x213E4D8", Offset = "0x213E4D8", VA = "0x213E4D8")] set
      {
      }
    }

    [Token(Token = "0x600B9B6")]
    [Address(RVA = "0x213C0AC", Offset = "0x213C0AC", VA = "0x213C0AC")]
    public void SetVert(float x, float y, float z, float w)
    {
    }

    [Token(Token = "0x600B9B7")]
    [Address(RVA = "0x213C0B8", Offset = "0x213C0B8", VA = "0x213C0B8")]
    public void SetUv(float uvX, float uvY, float uvW, float uvH)
    {
    }

    [Token(Token = "0x600B9B8")]
    [Address(RVA = "0x213C0A4", Offset = "0x213C0A4", VA = "0x213C0A4")]
    public QuadVerts()
    {
    }
  }
}
