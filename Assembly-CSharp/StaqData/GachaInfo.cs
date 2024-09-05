// Decompiled with JetBrains decompiler
// Type: StaqData.GachaInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.API;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200213B")]
  public class GachaInfo : IGachaModuleInfo
  {
    [Token(Token = "0x4008CFD")]
    [FieldOffset(Offset = "0x28")]
    private IGachaModuleInfo gachaModuleInfo;

    [Token(Token = "0x17002C78")]
    public string Title
    {
      [Token(Token = "0x600CB88"), Address(RVA = "0x1BA9B64", Offset = "0x1BA9B64", VA = "0x1BA9B64")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB89"), Address(RVA = "0x1BA9B6C", Offset = "0x1BA9B6C", VA = "0x1BA9B6C")] private set
      {
      }
    }

    [Token(Token = "0x17002C79")]
    public string DescriptionText
    {
      [Token(Token = "0x600CB8A"), Address(RVA = "0x1BA9B74", Offset = "0x1BA9B74", VA = "0x1BA9B74")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB8B"), Address(RVA = "0x1BA9B7C", Offset = "0x1BA9B7C", VA = "0x1BA9B7C")] private set
      {
      }
    }

    [Token(Token = "0x17002C7A")]
    public string ID
    {
      [Token(Token = "0x600CB8C"), Address(RVA = "0x1BA9B84", Offset = "0x1BA9B84", VA = "0x1BA9B84")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CB8D"), Address(RVA = "0x1BA9B8C", Offset = "0x1BA9B8C", VA = "0x1BA9B8C")] private set
      {
      }
    }

    [Token(Token = "0x17002C7B")]
    public string GachaName
    {
      [Token(Token = "0x600CB8E"), Address(RVA = "0x1BA4130", Offset = "0x1BA4130", VA = "0x1BA4130", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C7C")]
    public string ApiSchemaVersion
    {
      [Token(Token = "0x600CB8F"), Address(RVA = "0x1BA9B94", Offset = "0x1BA9B94", VA = "0x1BA9B94", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002C7D")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x600CB90"), Address(RVA = "0x1BA3ED4", Offset = "0x1BA3ED4", VA = "0x1BA3ED4", Slot = "6")] get
      {
        return new GachaTypeEnum();
      }
    }

    [Token(Token = "0x600CB91")]
    [Address(RVA = "0x1BA9C38", Offset = "0x1BA9C38", VA = "0x1BA9C38")]
    public GachaInfo(IGachaModuleInfo gachaModuleInfo)
    {
    }

    [Token(Token = "0x600CB92")]
    [Address(RVA = "0x1BA4D38", Offset = "0x1BA4D38", VA = "0x1BA4D38")]
    public static GachaInfo CreateFromServerData(
      IGachaModuleInfo gachaModuleInfo,
      G0000GachaDetailType serverData)
    {
      return (GachaInfo) null;
    }

    [Token(Token = "0x600CB93")]
    [Address(RVA = "0x1BA546C", Offset = "0x1BA546C", VA = "0x1BA546C")]
    public static GachaInfo CreateFromServerData(
      IGachaModuleInfo gachaModuleInfo,
      G0001GachaDetailType serverData)
    {
      return (GachaInfo) null;
    }
  }
}
