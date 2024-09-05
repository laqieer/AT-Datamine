// Decompiled with JetBrains decompiler
// Type: Gacha.API.GachaDetailRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015AA")]
  internal class GachaDetailRequest : IGachaModuleInfo
  {
    [Token(Token = "0x170012D2")]
    public string GachaName
    {
      [Token(Token = "0x6007AAF"), Address(RVA = "0x229EC34", Offset = "0x229EC34", VA = "0x229EC34", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007AB0"), Address(RVA = "0x229EC3C", Offset = "0x229EC3C", VA = "0x229EC3C")] private set
      {
      }
    }

    [Token(Token = "0x170012D3")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x6007AB1"), Address(RVA = "0x229EC44", Offset = "0x229EC44", VA = "0x229EC44", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007AB2"), Address(RVA = "0x229EC4C", Offset = "0x229EC4C", VA = "0x229EC4C")] private set
      {
      }
    }

    [Token(Token = "0x170012D4")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x6007AB3"), Address(RVA = "0x229EC54", Offset = "0x229EC54", VA = "0x229EC54", Slot = "6")] get
      {
        return new GachaTypeEnum();
      }
      [Token(Token = "0x6007AB4"), Address(RVA = "0x229EC5C", Offset = "0x229EC5C", VA = "0x229EC5C")] private set
      {
      }
    }

    [Token(Token = "0x6007AB5")]
    [Address(RVA = "0x229EC64", Offset = "0x229EC64", VA = "0x229EC64")]
    private GachaDetailRequest()
    {
    }

    [Token(Token = "0x6007AB6")]
    [Address(RVA = "0x229EC6C", Offset = "0x229EC6C", VA = "0x229EC6C")]
    public static GachaDetailRequest Create(
      string gachaName,
      string apiSchemaVersion,
      GachaTypeEnum gachaTypeEnum)
    {
      return (GachaDetailRequest) null;
    }
  }
}
