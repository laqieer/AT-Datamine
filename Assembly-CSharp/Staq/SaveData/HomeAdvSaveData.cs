// Decompiled with JetBrains decompiler
// Type: staq.SaveData.HomeAdvSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D26")]
  public class HomeAdvSaveData
  {
    [Token(Token = "0x4010D01")]
    [FieldOffset(Offset = "0x0")]
    private static AdvDataListSaveHelper advDataListSaveHelper;

    [Token(Token = "0x1700503D")]
    public Dictionary<int, AdvDataListSaveHelper.AdvData> AdvDataTable
    {
      [Token(Token = "0x6018934"), Address(RVA = "0x29454BC", Offset = "0x29454BC", VA = "0x29454BC")] get
      {
        return (Dictionary<int, AdvDataListSaveHelper.AdvData>) null;
      }
    }

    [Token(Token = "0x6018935")]
    [Address(RVA = "0x2945520", Offset = "0x2945520", VA = "0x2945520")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018936")]
    [Address(RVA = "0x2945580", Offset = "0x2945580", VA = "0x2945580")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018937")]
    [Address(RVA = "0x2945598", Offset = "0x2945598", VA = "0x2945598")]
    public void Load()
    {
    }

    [Token(Token = "0x6018938")]
    [Address(RVA = "0x2945644", Offset = "0x2945644", VA = "0x2945644")]
    public void Read(byte[] buf)
    {
    }

    [Token(Token = "0x6018939")]
    [Address(RVA = "0x2945850", Offset = "0x2945850", VA = "0x2945850")]
    public void Save()
    {
    }

    [Token(Token = "0x601893A")]
    [Address(RVA = "0x2945948", Offset = "0x2945948", VA = "0x2945948")]
    public HomeAdvSaveData()
    {
    }

    [Token(Token = "0x601893B")]
    [Address(RVA = "0x2945950", Offset = "0x2945950", VA = "0x2945950")]
    static HomeAdvSaveData()
    {
    }
  }
}
