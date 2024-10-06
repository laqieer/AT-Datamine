// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapStoryShopEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.Story;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001871")]
  public class FreeMapStoryShopEventUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x1700160C")]
    public ShopTypeEnum ShopTypeEnum
    {
      [Token(Token = "0x6008A86"), Address(RVA = "0x45222D8", Offset = "0x45222D8", VA = "0x45222D8")] get
      {
        return new ShopTypeEnum();
      }
      [Token(Token = "0x6008A87"), Address(RVA = "0x45222E0", Offset = "0x45222E0", VA = "0x45222E0")] private set
      {
      }
    }

    [Token(Token = "0x1700160D")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A88"), Address(RVA = "0x45222E8", Offset = "0x45222E8", VA = "0x45222E8", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x1700160E")]
    public int ObjectID
    {
      [Token(Token = "0x6008A89"), Address(RVA = "0x45222F0", Offset = "0x45222F0", VA = "0x45222F0")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A8A"), Address(RVA = "0x45222F8", Offset = "0x45222F8", VA = "0x45222F8")] private set
      {
      }
    }

    [Token(Token = "0x6008A8B")]
    [Address(RVA = "0x4522300", Offset = "0x4522300", VA = "0x4522300")]
    public FreeMapStoryShopEventUIParam(StoryShop storyShop)
    {
    }

    [Token(Token = "0x6008A8C")]
    [Address(RVA = "0x45223B0", Offset = "0x45223B0", VA = "0x45223B0", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A8D")]
    [Address(RVA = "0x45223B8", Offset = "0x45223B8", VA = "0x45223B8", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A8E")]
    [Address(RVA = "0x4522470", Offset = "0x4522470", VA = "0x4522470")]
    public string GetCharaName() => (string) null;

    [Token(Token = "0x6008A8F")]
    [Address(RVA = "0x452251C", Offset = "0x452251C", VA = "0x452251C")]
    public string GetDescription() => (string) null;

    [Token(Token = "0x6008A90")]
    [Address(RVA = "0x4522524", Offset = "0x4522524", VA = "0x4522524", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A91")]
    [Address(RVA = "0x452252C", Offset = "0x452252C", VA = "0x452252C", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A92")]
    [Address(RVA = "0x4522590", Offset = "0x4522590", VA = "0x4522590", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
