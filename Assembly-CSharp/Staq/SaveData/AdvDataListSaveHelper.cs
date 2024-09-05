// Decompiled with JetBrains decompiler
// Type: staq.SaveData.AdvDataListSaveHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF0")]
  public class AdvDataListSaveHelper
  {
    [Token(Token = "0x17005007")]
    public Dictionary<int, AdvDataListSaveHelper.AdvData> AdvDataTable
    {
      [Token(Token = "0x60187CD"), Address(RVA = "0x2938198", Offset = "0x2938198", VA = "0x2938198")] get
      {
        return (Dictionary<int, AdvDataListSaveHelper.AdvData>) null;
      }
    }

    [Token(Token = "0x17005008")]
    public string Path
    {
      [Token(Token = "0x60187CE"), Address(RVA = "0x29381A0", Offset = "0x29381A0", VA = "0x29381A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17005009")]
    public string FileName
    {
      [Token(Token = "0x60187CF"), Address(RVA = "0x2938230", Offset = "0x2938230", VA = "0x2938230")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60187D0"), Address(RVA = "0x2938238", Offset = "0x2938238", VA = "0x2938238")] set
      {
      }
    }

    [Token(Token = "0x60187D1")]
    [Address(RVA = "0x2938240", Offset = "0x2938240", VA = "0x2938240")]
    public AdvDataListSaveHelper(string filename)
    {
    }

    [Token(Token = "0x60187D2")]
    [Address(RVA = "0x29382F4", Offset = "0x29382F4", VA = "0x29382F4")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60187D3")]
    [Address(RVA = "0x2938328", Offset = "0x2938328", VA = "0x2938328")]
    public void ReadAdvDataTable(AdvDataList advList)
    {
    }

    [Token(Token = "0x60187D4")]
    [Address(RVA = "0x29384C8", Offset = "0x29384C8", VA = "0x29384C8")]
    public Offset<staq.SaveSchema.AdvData> Serialize(
      FlatBufferBuilder fbb,
      AdvDataListSaveHelper.AdvData item)
    {
      return new Offset<staq.SaveSchema.AdvData>();
    }

    [Token(Token = "0x60187D5")]
    [Address(RVA = "0x29384F4", Offset = "0x29384F4", VA = "0x29384F4")]
    public VectorOffset CreateAdvsVector(FlatBufferBuilder fbb) => new VectorOffset();

    [Token(Token = "0x2003CF1")]
    public class AdvData
    {
      [Token(Token = "0x4010C53")]
      [FieldOffset(Offset = "0x10")]
      public int AdvID;
      [Token(Token = "0x4010C54")]
      [FieldOffset(Offset = "0x14")]
      public bool Watched;

      [Token(Token = "0x60187D6")]
      [Address(RVA = "0x2938498", Offset = "0x2938498", VA = "0x2938498")]
      public AdvData(int advID, bool watched)
      {
      }
    }
  }
}
