// Decompiled with JetBrains decompiler
// Type: Gacha.API.GachaPayRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015AE")]
  internal class GachaPayRequest : IGachaModuleInfo
  {
    [Token(Token = "0x400633F")]
    [FieldOffset(Offset = "0x24")]
    public int GachaDetailId;
    [Token(Token = "0x4006340")]
    [FieldOffset(Offset = "0x28")]
    public int ExecuteCount;

    [Token(Token = "0x170012D8")]
    public string GachaName
    {
      [Token(Token = "0x6007ABC"), Address(RVA = "0x229ECE4", Offset = "0x229ECE4", VA = "0x229ECE4", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007ABD"), Address(RVA = "0x229ECEC", Offset = "0x229ECEC", VA = "0x229ECEC")] private set
      {
      }
    }

    [Token(Token = "0x170012D9")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x6007ABE"), Address(RVA = "0x229ECF4", Offset = "0x229ECF4", VA = "0x229ECF4", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007ABF"), Address(RVA = "0x229ECFC", Offset = "0x229ECFC", VA = "0x229ECFC")] private set
      {
      }
    }

    [Token(Token = "0x170012DA")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x6007AC0"), Address(RVA = "0x229ED04", Offset = "0x229ED04", VA = "0x229ED04", Slot = "6")] get
      {
        return new GachaTypeEnum();
      }
      [Token(Token = "0x6007AC1"), Address(RVA = "0x229ED0C", Offset = "0x229ED0C", VA = "0x229ED0C")] private set
      {
      }
    }

    [Token(Token = "0x6007AC2")]
    [Address(RVA = "0x229ED14", Offset = "0x229ED14", VA = "0x229ED14")]
    private GachaPayRequest()
    {
    }

    [Token(Token = "0x6007AC3")]
    [Address(RVA = "0x229ED1C", Offset = "0x229ED1C", VA = "0x229ED1C")]
    public static GachaPayRequest Create(
      string gachaName,
      int gachaDetailId,
      int executeCount,
      string apiSchemaVersion,
      GachaTypeEnum gachaTypeEnum)
    {
      return (GachaPayRequest) null;
    }
  }
}
