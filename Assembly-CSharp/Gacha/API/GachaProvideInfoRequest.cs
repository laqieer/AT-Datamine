// Decompiled with JetBrains decompiler
// Type: Gacha.API.GachaProvideInfoRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015B0")]
  public class GachaProvideInfoRequest : IGachaModuleInfo
  {
    [Token(Token = "0x4006343")]
    [FieldOffset(Offset = "0x20")]
    public int GachaGroupId;

    [Token(Token = "0x170012DB")]
    public string GachaName
    {
      [Token(Token = "0x6007AC5"), Address(RVA = "0x229EDA8", Offset = "0x229EDA8", VA = "0x229EDA8", Slot = "4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007AC6"), Address(RVA = "0x229EDB0", Offset = "0x229EDB0", VA = "0x229EDB0")] private set
      {
      }
    }

    [Token(Token = "0x170012DC")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x6007AC7"), Address(RVA = "0x229EDB8", Offset = "0x229EDB8", VA = "0x229EDB8", Slot = "5")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007AC8"), Address(RVA = "0x229EDC0", Offset = "0x229EDC0", VA = "0x229EDC0")] private set
      {
      }
    }

    [Token(Token = "0x170012DD")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x6007AC9"), Address(RVA = "0x229EDC8", Offset = "0x229EDC8", VA = "0x229EDC8", Slot = "6")] get
      {
        return new GachaTypeEnum();
      }
      [Token(Token = "0x6007ACA"), Address(RVA = "0x229EDD0", Offset = "0x229EDD0", VA = "0x229EDD0")] private set
      {
      }
    }

    [Token(Token = "0x6007ACB")]
    [Address(RVA = "0x229EDD8", Offset = "0x229EDD8", VA = "0x229EDD8")]
    private GachaProvideInfoRequest()
    {
    }

    [Token(Token = "0x6007ACC")]
    [Address(RVA = "0x229EDE0", Offset = "0x229EDE0", VA = "0x229EDE0")]
    public static GachaProvideInfoRequest Create(
      string gachaName,
      int gachaGroupId,
      string apiSchemaVersion,
      GachaTypeEnum gachaTypeEnum)
    {
      return (GachaProvideInfoRequest) null;
    }
  }
}
