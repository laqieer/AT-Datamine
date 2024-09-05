// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Common.ItemConvertCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Common
{
  [Token(Token = "0x2003700")]
  public class ItemConvertCheck
  {
    [Token(Token = "0x6015AA1")]
    [Address(RVA = "0x1D845C8", Offset = "0x1D845C8", VA = "0x1D845C8")]
    public static void ShowToaster()
    {
    }

    [Token(Token = "0x6015AA2")]
    [Address(RVA = "0x1D8465C", Offset = "0x1D8465C", VA = "0x1D8465C")]
    public bool IsConvertPiece(
      List<PlayerShopContentType> contentTypes,
      APIShopPurchaseResponse response)
    {
      return new bool();
    }

    [Token(Token = "0x6015AA3")]
    [Address(RVA = "0x1D84BE0", Offset = "0x1D84BE0", VA = "0x1D84BE0")]
    public bool IsConvertPiece(int articleId, APIStoryShopPurchaseResponse response) => new bool();

    [Token(Token = "0x6015AA4")]
    [Address(RVA = "0x1D84CB4", Offset = "0x1D84CB4", VA = "0x1D84CB4")]
    public bool IsConvertPiece(int priceId, APIMedal_trade_shopTradeResponse response)
    {
      return new bool();
    }

    [Token(Token = "0x6015AA5")]
    [Address(RVA = "0x1D8482C", Offset = "0x1D8482C", VA = "0x1D8482C")]
    private bool CheckItemData(
      int itemId,
      RewardTypeEnum rewardType,
      UpdatedPlayerItems updatedPlayerItems)
    {
      return new bool();
    }

    [Token(Token = "0x6015AA6")]
    [Address(RVA = "0x1D84DD8", Offset = "0x1D84DD8", VA = "0x1D84DD8")]
    public bool IsConvertPiece(APIPresentReceiveResponse response) => new bool();

    [Token(Token = "0x6015AA7")]
    [Address(RVA = "0x1D84F58", Offset = "0x1D84F58", VA = "0x1D84F58")]
    public ItemConvertCheck()
    {
    }
  }
}
