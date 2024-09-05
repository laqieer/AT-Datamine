// Decompiled with JetBrains decompiler
// Type: GameCore.RawData.RawTextureHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.RawData
{
  [Token(Token = "0x2000CC7")]
  public class RawTextureHandle
  {
    [Token(Token = "0x4003965")]
    [FieldOffset(Offset = "0x10")]
    private string url;
    [Token(Token = "0x4003966")]
    [FieldOffset(Offset = "0x18")]
    private IRawTextureOwner owner;
    [Token(Token = "0x4003967")]
    [FieldOffset(Offset = "0x20")]
    private bool isReleased;

    [Token(Token = "0x17000ABF")]
    public bool IsValid
    {
      [Token(Token = "0x600498F"), Address(RVA = "0x3139F18", Offset = "0x3139F18", VA = "0x3139F18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000AC0")]
    public Texture2D Instance
    {
      [Token(Token = "0x6004990"), Address(RVA = "0x3139F78", Offset = "0x3139F78", VA = "0x3139F78")] get
      {
        return (Texture2D) null;
      }
      [Token(Token = "0x6004991"), Address(RVA = "0x3139F80", Offset = "0x3139F80", VA = "0x3139F80")] private set
      {
      }
    }

    [Token(Token = "0x6004992")]
    [Address(RVA = "0x3139F88", Offset = "0x3139F88", VA = "0x3139F88")]
    public RawTextureHandle(string url, Texture2D instance, IRawTextureOwner owner)
    {
    }

    [Token(Token = "0x6004993")]
    [Address(RVA = "0x313A05C", Offset = "0x313A05C", VA = "0x313A05C")]
    public void Release()
    {
    }
  }
}
