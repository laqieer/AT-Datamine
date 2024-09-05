// Decompiled with JetBrains decompiler
// Type: Gacha.RenderTextureHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001567")]
  internal struct RenderTextureHandle : IDisposable
  {
    [Token(Token = "0x17001292")]
    public RenderTexture Instance
    {
      [Token(Token = "0x6007929"), Address(RVA = "0x22946B8", Offset = "0x22946B8", VA = "0x22946B8")] readonly get
      {
        return (RenderTexture) null;
      }
      [Token(Token = "0x600792A"), Address(RVA = "0x22946C0", Offset = "0x22946C0", VA = "0x22946C0")] private set
      {
      }
    }

    [Token(Token = "0x17001293")]
    public bool IsValid
    {
      [Token(Token = "0x600792B"), Address(RVA = "0x22946C8", Offset = "0x22946C8", VA = "0x22946C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600792C")]
    [Address(RVA = "0x2294728", Offset = "0x2294728", VA = "0x2294728")]
    public static RenderTextureHandle Get(Vector2 size) => new RenderTextureHandle();

    [Token(Token = "0x600792D")]
    [Address(RVA = "0x2294754", Offset = "0x2294754", VA = "0x2294754")]
    public static RenderTextureHandle Get(int width, int height) => new RenderTextureHandle();

    [Token(Token = "0x600792E")]
    [Address(RVA = "0x229475C", Offset = "0x229475C", VA = "0x229475C")]
    private RenderTextureHandle(RenderTexture instance)
    {
    }

    [Token(Token = "0x600792F")]
    [Address(RVA = "0x2294764", Offset = "0x2294764", VA = "0x2294764", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
