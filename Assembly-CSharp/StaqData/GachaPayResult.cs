// Decompiled with JetBrains decompiler
// Type: StaqData.GachaPayResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.API;
using Il2CppDummyDll;
using Network.API;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002124")]
  internal class GachaPayResult
  {
    [Token(Token = "0x4008C9D")]
    [FieldOffset(Offset = "0x10")]
    public GachaResultInfo GachaResultInfo;
    [Token(Token = "0x4008C9E")]
    [FieldOffset(Offset = "0x18")]
    public GachaDetailGroupInfo GachaDetailGroupInfo;
    [Token(Token = "0x4008C9F")]
    [FieldOffset(Offset = "0x20")]
    public IPostApiResult PostApiResult;

    [Token(Token = "0x600CA9C")]
    [Address(RVA = "0x1BA69FC", Offset = "0x1BA69FC", VA = "0x1BA69FC")]
    public static GachaPayResult CreateFromServerData(
      GachaPayRequest reequest,
      APIG0000PayResponse serverData)
    {
      return (GachaPayResult) null;
    }

    [Token(Token = "0x600CA9D")]
    [Address(RVA = "0x1BA6CFC", Offset = "0x1BA6CFC", VA = "0x1BA6CFC")]
    public static GachaPayResult CreateFromServerData(
      GachaPayRequest reequest,
      APIG0001PayResponse serverData)
    {
      return (GachaPayResult) null;
    }

    [Token(Token = "0x600CA9E")]
    [Address(RVA = "0x1BA6A98", Offset = "0x1BA6A98", VA = "0x1BA6A98")]
    public GachaPayResult()
    {
    }
  }
}
