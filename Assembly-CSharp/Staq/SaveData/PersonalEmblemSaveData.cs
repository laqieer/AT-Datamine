// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PersonalEmblemSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D36")]
  public class PersonalEmblemSaveData
  {
    [Token(Token = "0x4010D39")]
    [FieldOffset(Offset = "0x18")]
    private bool loaded;

    [Token(Token = "0x17005063")]
    public List<int> CheckedContent
    {
      [Token(Token = "0x60189F1"), Address(RVA = "0x26384B8", Offset = "0x26384B8", VA = "0x26384B8")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x60189F2"), Address(RVA = "0x26384C0", Offset = "0x26384C0", VA = "0x26384C0")] set
      {
      }
    }

    [Token(Token = "0x17005064")]
    private static string Path
    {
      [Token(Token = "0x60189F3"), Address(RVA = "0x26384C8", Offset = "0x26384C8", VA = "0x26384C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189F4")]
    [Address(RVA = "0x2638518", Offset = "0x2638518", VA = "0x2638518")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60189F5")]
    [Address(RVA = "0x2638560", Offset = "0x2638560", VA = "0x2638560")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60189F6")]
    [Address(RVA = "0x2638590", Offset = "0x2638590", VA = "0x2638590")]
    public void Delete()
    {
    }

    [Token(Token = "0x60189F7")]
    [Address(RVA = "0x26385AC", Offset = "0x26385AC", VA = "0x26385AC")]
    public void Load()
    {
    }

    [Token(Token = "0x60189F8")]
    [Address(RVA = "0x26387CC", Offset = "0x26387CC", VA = "0x26387CC")]
    public void Save()
    {
    }

    [Token(Token = "0x60189F9")]
    [Address(RVA = "0x26388C4", Offset = "0x26388C4", VA = "0x26388C4")]
    public PersonalEmblemSaveData()
    {
    }
  }
}
