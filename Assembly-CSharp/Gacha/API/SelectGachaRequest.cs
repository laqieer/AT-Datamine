// Decompiled with JetBrains decompiler
// Type: Gacha.API.SelectGachaRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015B2")]
  internal class SelectGachaRequest : IGachaModuleInfo
  {
    [Token(Token = "0x170012DE")]
    public string GachaName
    {
      [Token(Token = "0x6007ACE"), Address(RVA = "0x229EE64", Offset = "0x229EE64", VA = "0x229EE64", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007ACF"), Address(RVA = "0x229EE6C", Offset = "0x229EE6C", VA = "0x229EE6C")] private set
      {
      }
    }

    [Token(Token = "0x170012DF")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x6007AD0"), Address(RVA = "0x229EE74", Offset = "0x229EE74", VA = "0x229EE74", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007AD1"), Address(RVA = "0x229EE7C", Offset = "0x229EE7C", VA = "0x229EE7C")] private set
      {
      }
    }

    [Token(Token = "0x170012E0")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x6007AD2"), Address(RVA = "0x229EE84", Offset = "0x229EE84", VA = "0x229EE84", Slot = "6")] get
      {
        return new GachaTypeEnum();
      }
      [Token(Token = "0x6007AD3"), Address(RVA = "0x229EE8C", Offset = "0x229EE8C", VA = "0x229EE8C")] private set
      {
      }
    }

    [Token(Token = "0x170012E1")]
    public int TargetId
    {
      [Token(Token = "0x6007AD4"), Address(RVA = "0x229EE94", Offset = "0x229EE94", VA = "0x229EE94")] get
      {
        return new int();
      }
      [Token(Token = "0x6007AD5"), Address(RVA = "0x229EE9C", Offset = "0x229EE9C", VA = "0x229EE9C")] private set
      {
      }
    }

    [Token(Token = "0x170012E2")]
    public int TargetOptionId
    {
      [Token(Token = "0x6007AD6"), Address(RVA = "0x229EEA4", Offset = "0x229EEA4", VA = "0x229EEA4")] get
      {
        return new int();
      }
      [Token(Token = "0x6007AD7"), Address(RVA = "0x229EEAC", Offset = "0x229EEAC", VA = "0x229EEAC")] private set
      {
      }
    }

    [Token(Token = "0x6007AD8")]
    [Address(RVA = "0x229EEB4", Offset = "0x229EEB4", VA = "0x229EEB4")]
    public static SelectGachaRequest Create(
      string gachaName,
      int targetId,
      int targetOptionId,
      string apiSchemaVersion,
      GachaTypeEnum gachaTypeEnum)
    {
      return (SelectGachaRequest) null;
    }

    [Token(Token = "0x6007AD9")]
    [Address(RVA = "0x229EF40", Offset = "0x229EF40", VA = "0x229EF40")]
    public SelectGachaRequest()
    {
    }
  }
}
