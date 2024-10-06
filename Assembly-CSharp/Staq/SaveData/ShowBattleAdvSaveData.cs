// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ShowBattleAdvSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D44")]
  public class ShowBattleAdvSaveData
  {
    [Token(Token = "0x4010D5F")]
    [FieldOffset(Offset = "0x10")]
    public List<int> ShowBattleAdvIDList;

    [Token(Token = "0x17005079")]
    public static string Path
    {
      [Token(Token = "0x6018A69"), Address(RVA = "0x263C950", Offset = "0x263C950", VA = "0x263C950")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A6A")]
    [Address(RVA = "0x263C9A0", Offset = "0x263C9A0", VA = "0x263C9A0")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A6B")]
    [Address(RVA = "0x263C9E8", Offset = "0x263C9E8", VA = "0x263C9E8")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A6C")]
    [Address(RVA = "0x263CA18", Offset = "0x263CA18", VA = "0x263CA18")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A6D")]
    [Address(RVA = "0x263CA30", Offset = "0x263CA30", VA = "0x263CA30")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A6E")]
    [Address(RVA = "0x263CC64", Offset = "0x263CC64", VA = "0x263CC64")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A6F")]
    [Address(RVA = "0x263CD38", Offset = "0x263CD38", VA = "0x263CD38")]
    public void ShowBattleAdvIdSet(int advId)
    {
    }

    [Token(Token = "0x6018A70")]
    [Address(RVA = "0x263CE18", Offset = "0x263CE18", VA = "0x263CE18")]
    public bool ShowBattleAdvCheck(int advId) => new bool();

    [Token(Token = "0x6018A71")]
    [Address(RVA = "0x263CE70", Offset = "0x263CE70", VA = "0x263CE70")]
    public ShowBattleAdvSaveData()
    {
    }
  }
}
