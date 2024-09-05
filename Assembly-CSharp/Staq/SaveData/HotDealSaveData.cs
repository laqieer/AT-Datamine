// Decompiled with JetBrains decompiler
// Type: staq.SaveData.HotDealSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using Network.Param;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D27")]
  public class HotDealSaveData
  {
    [Token(Token = "0x4010D02")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<string, HotDealSaveData.HotDealData> hotDealDic;

    [Token(Token = "0x1700503E")]
    public static string Path
    {
      [Token(Token = "0x601893C"), Address(RVA = "0x29459DC", Offset = "0x29459DC", VA = "0x29459DC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601893D")]
    [Address(RVA = "0x2945A2C", Offset = "0x2945A2C", VA = "0x2945A2C")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601893E")]
    [Address(RVA = "0x2945A74", Offset = "0x2945A74", VA = "0x2945A74")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x601893F")]
    [Address(RVA = "0x2945AA4", Offset = "0x2945AA4", VA = "0x2945AA4")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018940")]
    [Address(RVA = "0x2945ABC", Offset = "0x2945ABC", VA = "0x2945ABC")]
    public void Load()
    {
    }

    [Token(Token = "0x6018941")]
    [Address(RVA = "0x2945DB8", Offset = "0x2945DB8", VA = "0x2945DB8")]
    public void Save()
    {
    }

    [Token(Token = "0x6018942")]
    [Address(RVA = "0x2945E64", Offset = "0x2945E64", VA = "0x2945E64")]
    private VectorOffset CreateHotDealDataVector(FlatBufferBuilder fbb) => new VectorOffset();

    [Token(Token = "0x6018943")]
    [Address(RVA = "0x2945C18", Offset = "0x2945C18", VA = "0x2945C18")]
    private void ExchangeSaveData(HotDealList data)
    {
    }

    [Token(Token = "0x6018944")]
    [Address(RVA = "0x2945FE8", Offset = "0x2945FE8", VA = "0x2945FE8")]
    public void Set(List<HotDealInfoType> response)
    {
    }

    [Token(Token = "0x6018945")]
    [Address(RVA = "0x29461F8", Offset = "0x29461F8", VA = "0x29461F8")]
    public void Update(string id)
    {
    }

    [Token(Token = "0x6018946")]
    [Address(RVA = "0x29462C8", Offset = "0x29462C8", VA = "0x29462C8")]
    public List<HotDealInfoType> CheckNewHotDeal(List<HotDealInfoType> response)
    {
      return (List<HotDealInfoType>) null;
    }

    [Token(Token = "0x6018947")]
    [Address(RVA = "0x2946510", Offset = "0x2946510", VA = "0x2946510")]
    public HotDealSaveData()
    {
    }

    [Token(Token = "0x2003D28")]
    public class HotDealData
    {
      [Token(Token = "0x4010D03")]
      [FieldOffset(Offset = "0x10")]
      public string hotDealId;
      [Token(Token = "0x4010D04")]
      [FieldOffset(Offset = "0x18")]
      public bool alreadyRead;

      [Token(Token = "0x6018948")]
      [Address(RVA = "0x2945FB8", Offset = "0x2945FB8", VA = "0x2945FB8")]
      public HotDealData(string hotDealId, bool alreadyRead)
      {
      }
    }
  }
}
