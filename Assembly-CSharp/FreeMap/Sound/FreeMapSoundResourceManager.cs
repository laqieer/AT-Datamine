// Decompiled with JetBrains decompiler
// Type: FreeMap.Sound.FreeMapSoundResourceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Sound
{
  [Token(Token = "0x2001844")]
  public class FreeMapSoundResourceManager
  {
    [Token(Token = "0x40069E4")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, int> fileReferenceDic;

    [Token(Token = "0x6008949")]
    [Address(RVA = "0x43E3738", Offset = "0x43E3738", VA = "0x43E3738")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600894A")]
    [Address(RVA = "0x43E373C", Offset = "0x43E373C", VA = "0x43E373C")]
    public FreeMapSoundResourceManager.Handler Load(string filename)
    {
      return (FreeMapSoundResourceManager.Handler) null;
    }

    [Token(Token = "0x600894B")]
    [Address(RVA = "0x43E38DC", Offset = "0x43E38DC", VA = "0x43E38DC")]
    public void Remove(FreeMapSoundResourceManager.Handler handler)
    {
    }

    [Token(Token = "0x600894C")]
    [Address(RVA = "0x43E3A4C", Offset = "0x43E3A4C", VA = "0x43E3A4C")]
    public void Release()
    {
    }

    [Token(Token = "0x600894D")]
    [Address(RVA = "0x43E3A50", Offset = "0x43E3A50", VA = "0x43E3A50")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600894E")]
    [Address(RVA = "0x43E3C08", Offset = "0x43E3C08", VA = "0x43E3C08")]
    public FreeMapSoundResourceManager()
    {
    }

    [Token(Token = "0x2001845")]
    public class Handler : IDisposable
    {
      [Token(Token = "0x40069E5")]
      [FieldOffset(Offset = "0x10")]
      private FreeMapSoundResourceManager manager;

      [Token(Token = "0x600894F")]
      [Address(RVA = "0x43E38B0", Offset = "0x43E38B0", VA = "0x43E38B0")]
      public Handler(FreeMapSoundResourceManager manager, string filename)
      {
      }

      [Token(Token = "0x170015A8")]
      public string FileName
      {
        [Token(Token = "0x6008950"), Address(RVA = "0x43E3C84", Offset = "0x43E3C84", VA = "0x43E3C84")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6008951")]
      [Address(RVA = "0x43E3A3C", Offset = "0x43E3A3C", VA = "0x43E3A3C")]
      public bool IsValid() => new bool();

      [Token(Token = "0x6008952")]
      [Address(RVA = "0x43E3C8C", Offset = "0x43E3C8C", VA = "0x43E3C8C", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
