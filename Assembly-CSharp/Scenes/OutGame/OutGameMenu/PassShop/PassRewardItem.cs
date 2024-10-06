// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PassShop.PassRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.PassShop
{
  [Token(Token = "0x2003B4E")]
  public class PassRewardItem : MonoBehaviour
  {
    [Token(Token = "0x40105F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x40105F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text itemNum;

    [Token(Token = "0x17004C0C")]
    public Action<ItemPurchaseData.ItemRewardData> OnClickItemAction
    {
      [Token(Token = "0x601754E"), Address(RVA = "0x2724BA8", Offset = "0x2724BA8", VA = "0x2724BA8")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData>) null;
      }
      [Token(Token = "0x601754F"), Address(RVA = "0x2724BB0", Offset = "0x2724BB0", VA = "0x2724BB0")] set
      {
      }
    }

    [Token(Token = "0x6017550")]
    [Address(RVA = "0x2724A20", Offset = "0x2724A20", VA = "0x2724A20")]
    public void Set(
      AssetCachedSpawner cachedSpawner,
      ItemUtility.Parameter parameter,
      RewardTypeEnum rewardType,
      int num)
    {
    }

    [Token(Token = "0x6017551")]
    [Address(RVA = "0x27248AC", Offset = "0x27248AC", VA = "0x27248AC")]
    public void PaidCoinSet(
      AssetCachedSpawner cachedSpawner,
      ItemUtility.Parameter parameter,
      int num)
    {
    }

    [Token(Token = "0x6017552")]
    [Address(RVA = "0x2724BC8", Offset = "0x2724BC8", VA = "0x2724BC8")]
    public PassRewardItem()
    {
    }
  }
}
