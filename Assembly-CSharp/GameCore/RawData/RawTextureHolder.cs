// Decompiled with JetBrains decompiler
// Type: GameCore.RawData.RawTextureHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.RawData
{
  [Token(Token = "0x2000CC9")]
  public class RawTextureHolder : IRawTextureOwner
  {
    [Token(Token = "0x4003969")]
    [FieldOffset(Offset = "0x10")]
    private string url;
    [Token(Token = "0x400396A")]
    [FieldOffset(Offset = "0x18")]
    private Texture2D instance;
    [Token(Token = "0x400396B")]
    [FieldOffset(Offset = "0x20")]
    private int refCount;
    [Token(Token = "0x400396C")]
    [FieldOffset(Offset = "0x28")]
    public Action<string> TextureReleasedEvent;

    [Token(Token = "0x6004996")]
    [Address(RVA = "0x313A114", Offset = "0x313A114", VA = "0x313A114")]
    public RawTextureHolder(string url, Texture2D instance)
    {
    }

    [Token(Token = "0x6004997")]
    [Address(RVA = "0x313A140", Offset = "0x313A140", VA = "0x313A140")]
    public RawTextureHandle GetHandle() => (RawTextureHandle) null;

    [Token(Token = "0x6004998")]
    [Address(RVA = "0x313A1B4", Offset = "0x313A1B4", VA = "0x313A1B4", Slot = "4")]
    public void AddRefCount()
    {
    }

    [Token(Token = "0x6004999")]
    [Address(RVA = "0x313A1C4", Offset = "0x313A1C4", VA = "0x313A1C4", Slot = "5")]
    public void SubRefCount()
    {
    }

    [Token(Token = "0x600499A")]
    [Address(RVA = "0x313A274", Offset = "0x313A274", VA = "0x313A274")]
    public void ForceRelease()
    {
    }

    [Token(Token = "0x600499B")]
    [Address(RVA = "0x313A1E0", Offset = "0x313A1E0", VA = "0x313A1E0")]
    private void OnRefCountZero()
    {
    }

    [Token(Token = "0x600499C")]
    [Address(RVA = "0x313A27C", Offset = "0x313A27C", VA = "0x313A27C")]
    private void ReleaseTexture()
    {
    }
  }
}
