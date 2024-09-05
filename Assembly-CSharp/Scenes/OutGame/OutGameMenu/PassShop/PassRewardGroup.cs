// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PassShop.PassRewardGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.PassShop
{
  [Token(Token = "0x2003B4C")]
  public class PassRewardGroup : MonoBehaviour
  {
    [Token(Token = "0x40105EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x40105EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text categoryTitle;

    [Token(Token = "0x17004C0B")]
    public Action<ItemPurchaseData.ItemRewardData> OnClickItemAction
    {
      [Token(Token = "0x6017548"), Address(RVA = "0x272489C", Offset = "0x272489C", VA = "0x272489C")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData>) null;
      }
      [Token(Token = "0x6017549"), Address(RVA = "0x27248A4", Offset = "0x27248A4", VA = "0x27248A4")] set
      {
      }
    }

    [Token(Token = "0x601754A")]
    [Address(RVA = "0x27215BC", Offset = "0x27215BC", VA = "0x27215BC")]
    public void SetByBuyItem(
      AssetCachedSpawner cachedSpawner,
      GameObject passItemPrefab,
      PassRewardGroup.PassItemGroup passItem)
    {
    }

    [Token(Token = "0x601754B")]
    [Address(RVA = "0x2721790", Offset = "0x2721790", VA = "0x2721790")]
    public void SetByLoginBonus(
      AssetCachedSpawner cachedSpawner,
      GameObject passItemPrefab,
      PassRewardGroup.PassItemGroup[] passItems)
    {
    }

    [Token(Token = "0x601754C")]
    [Address(RVA = "0x2724BA0", Offset = "0x2724BA0", VA = "0x2724BA0")]
    public PassRewardGroup()
    {
    }

    [Token(Token = "0x2003B4D")]
    public class PassItemGroup
    {
      [Token(Token = "0x40105EE")]
      [FieldOffset(Offset = "0x10")]
      public ItemUtility.Parameter Parameter;
      [Token(Token = "0x40105EF")]
      [FieldOffset(Offset = "0x70")]
      public RewardTypeEnum RewardType;
      [Token(Token = "0x40105F0")]
      [FieldOffset(Offset = "0x74")]
      public int Num;

      [Token(Token = "0x601754D")]
      [Address(RVA = "0x27215B4", Offset = "0x27215B4", VA = "0x27215B4")]
      public PassItemGroup()
      {
      }
    }
  }
}
