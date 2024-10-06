// Decompiled with JetBrains decompiler
// Type: staq.SaveData.NewFlagRentalBookSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D31")]
  public class NewFlagRentalBookSaveData
  {
    [Token(Token = "0x4010D28")]
    [FieldOffset(Offset = "0x18")]
    private List<int> bookItemIDs;

    [Token(Token = "0x17005051")]
    public bool loaded
    {
      [Token(Token = "0x60189B1"), Address(RVA = "0x294A1D8", Offset = "0x294A1D8", VA = "0x294A1D8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60189B2"), Address(RVA = "0x294A1E0", Offset = "0x294A1E0", VA = "0x294A1E0")] private set
      {
      }
    }

    [Token(Token = "0x60189B3")]
    [Address(RVA = "0x294A1EC", Offset = "0x294A1EC", VA = "0x294A1EC")]
    public bool IsNew(int bookItemID) => new bool();

    [Token(Token = "0x60189B4")]
    [Address(RVA = "0x294A204", Offset = "0x294A204", VA = "0x294A204")]
    public bool Contains(int bookItemID) => new bool();

    [Token(Token = "0x60189B5")]
    [Address(RVA = "0x294A368", Offset = "0x294A368", VA = "0x294A368")]
    public void FlagOff(int bookItemID)
    {
    }

    [Token(Token = "0x17005052")]
    public static string Path
    {
      [Token(Token = "0x60189B6"), Address(RVA = "0x294A420", Offset = "0x294A420", VA = "0x294A420")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189B7")]
    [Address(RVA = "0x294A470", Offset = "0x294A470", VA = "0x294A470")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60189B8")]
    [Address(RVA = "0x294A4B8", Offset = "0x294A4B8", VA = "0x294A4B8")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60189B9")]
    [Address(RVA = "0x294A4E8", Offset = "0x294A4E8", VA = "0x294A4E8")]
    public void Delete()
    {
    }

    [Token(Token = "0x60189BA")]
    [Address(RVA = "0x294A504", Offset = "0x294A504", VA = "0x294A504")]
    public void Load()
    {
    }

    [Token(Token = "0x60189BB")]
    [Address(RVA = "0x294A74C", Offset = "0x294A74C", VA = "0x294A74C")]
    public void Save()
    {
    }

    [Token(Token = "0x60189BC")]
    [Address(RVA = "0x294A848", Offset = "0x294A848", VA = "0x294A848")]
    public NewFlagRentalBookSaveData()
    {
    }
  }
}
