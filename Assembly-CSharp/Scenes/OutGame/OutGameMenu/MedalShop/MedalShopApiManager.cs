// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.MedalShopApiManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B02")]
  public class MedalShopApiManager
  {
    [Token(Token = "0x4010432")]
    [FieldOffset(Offset = "0x10")]
    private bool isConnetingApi;
    [Token(Token = "0x4010434")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, PlayerMedalTradeCountType[]> tradeCountMap;

    [Token(Token = "0x17004BC1")]
    public bool IsConnectingApi
    {
      [Token(Token = "0x6017386"), Address(RVA = "0x301D340", Offset = "0x301D340", VA = "0x301D340")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004BC2")]
    public List<Reward> UnreceivedRewards
    {
      [Token(Token = "0x6017387"), Address(RVA = "0x301D348", Offset = "0x301D348", VA = "0x301D348")] get
      {
        return (List<Reward>) null;
      }
      [Token(Token = "0x6017388"), Address(RVA = "0x301D350", Offset = "0x301D350", VA = "0x301D350")] private set
      {
      }
    }

    [Token(Token = "0x6017389")]
    [Address(RVA = "0x301D358", Offset = "0x301D358", VA = "0x301D358")]
    public PlayerMedalTradeCountType[] GetItems(int medalShopId)
    {
      return (PlayerMedalTradeCountType[]) null;
    }

    [Token(Token = "0x601738A")]
    [Address(RVA = "0x301D3EC", Offset = "0x301D3EC", VA = "0x301D3EC")]
    public int GetRemainCount(int medalShopId, int prizeId) => new int();

    [Token(Token = "0x601738B")]
    [Address(RVA = "0x301D5DC", Offset = "0x301D5DC", VA = "0x301D5DC")]
    public IEnumerator CallMedalShopCount(
      int medalShopId,
      Func<NetworkErrorResult, IEnumerator> errorPurchase,
      Action onFinishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601738C")]
    [Address(RVA = "0x301D690", Offset = "0x301D690", VA = "0x301D690")]
    public IEnumerator CallTradeShopItem(
      int medalShopId,
      int prizeId,
      int count,
      Action<bool> finishAction,
      Func<NetworkErrorResult, IEnumerator> errorPurchase)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601738D")]
    [Address(RVA = "0x301D75C", Offset = "0x301D75C", VA = "0x301D75C")]
    public MedalShopApiManager()
    {
    }
  }
}
