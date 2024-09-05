// Decompiled with JetBrains decompiler
// Type: staq.SaveData.TodayInformationSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D51")]
  public class TodayInformationSaveData
  {
    [Token(Token = "0x4010D8F")]
    [FieldOffset(Offset = "0x10")]
    public bool check;
    [Token(Token = "0x4010D90")]
    [FieldOffset(Offset = "0x18")]
    public DateTime datetime;

    [Token(Token = "0x1700509C")]
    private string Path
    {
      [Token(Token = "0x6018ADC"), Address(RVA = "0x264063C", Offset = "0x264063C", VA = "0x264063C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018ADD")]
    [Address(RVA = "0x264068C", Offset = "0x264068C", VA = "0x264068C")]
    private string GetPath() => (string) null;

    [Token(Token = "0x6018ADE")]
    [Address(RVA = "0x26406D4", Offset = "0x26406D4", VA = "0x26406D4")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018ADF")]
    [Address(RVA = "0x26406EC", Offset = "0x26406EC", VA = "0x26406EC")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018AE0")]
    [Address(RVA = "0x264071C", Offset = "0x264071C", VA = "0x264071C")]
    public void Load()
    {
    }

    [Token(Token = "0x6018AE1")]
    [Address(RVA = "0x2640910", Offset = "0x2640910", VA = "0x2640910")]
    public void Save()
    {
    }

    [Token(Token = "0x6018AE2")]
    [Address(RVA = "0x2640A20", Offset = "0x2640A20", VA = "0x2640A20")]
    public TodayInformationSaveData()
    {
    }
  }
}
