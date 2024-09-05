// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.RewardHorizontal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D46")]
  public class RewardHorizontal : MonoBehaviour
  {
    [Token(Token = "0x400C245")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RewardHorizontal.InstanceType instanceType;
    [Token(Token = "0x400C246")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ExpeditionResultItemCell[] items;
    [Token(Token = "0x400C247")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ExpeditionResultItemCell original;
    [Token(Token = "0x400C248")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect scrollView;
    [Token(Token = "0x400C24A")]
    [FieldOffset(Offset = "0x40")]
    private Vector2 cellSize;
    [Token(Token = "0x400C24B")]
    [FieldOffset(Offset = "0x48")]
    private Action CancelInitializeItem;
    [Token(Token = "0x400C24C")]
    [FieldOffset(Offset = "0x50")]
    private bool isInitializing;

    [Token(Token = "0x17003C88")]
    public ScrollRect ScrollView
    {
      [Token(Token = "0x6011B26"), Address(RVA = "0x42B3FA8", Offset = "0x42B3FA8", VA = "0x42B3FA8")] get
      {
        return (ScrollRect) null;
      }
    }

    [Token(Token = "0x17003C89")]
    private AssetCachedSpawner Spawner
    {
      [Token(Token = "0x6011B27"), Address(RVA = "0x42B3FB0", Offset = "0x42B3FB0", VA = "0x42B3FB0")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x6011B28"), Address(RVA = "0x42B3FB8", Offset = "0x42B3FB8", VA = "0x42B3FB8")] set
      {
      }
    }

    [Token(Token = "0x6011B29")]
    [Address(RVA = "0x42B3FC0", Offset = "0x42B3FC0", VA = "0x42B3FC0")]
    public void Initialize(
      List<ExpeditionBossRareRewardData> data,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6011B2A")]
    [Address(RVA = "0x42AF7C4", Offset = "0x42AF7C4", VA = "0x42AF7C4")]
    public void Initialize(
      List<ExpeditionBossRareRewardData> data,
      int index,
      int size,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6011B2B")]
    [Address(RVA = "0x42B4024", Offset = "0x42B4024", VA = "0x42B4024")]
    private void Initialize(
      HorizontalInfiniteScrollView hScrollView,
      List<ExpeditionBossRareRewardData> datas,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6011B2C")]
    [Address(RVA = "0x42B49EC", Offset = "0x42B49EC", VA = "0x42B49EC")]
    private void OnUpdateScrollItem(ExpeditionResultItemCell.Parameter param)
    {
    }

    [Token(Token = "0x6011B2D")]
    [Address(RVA = "0x42B4970", Offset = "0x42B4970", VA = "0x42B4970")]
    private void InitItem(
      ExpeditionResultItemCell item,
      RewardTypeEnum rewardType,
      int id,
      int quantity,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6011B2E")]
    [Address(RVA = "0x42B475C", Offset = "0x42B475C", VA = "0x42B475C")]
    private void ExpandItems(int newSize)
    {
    }

    [Token(Token = "0x6011B2F")]
    [Address(RVA = "0x42B4900", Offset = "0x42B4900", VA = "0x42B4900")]
    private void DisableItems()
    {
    }

    [Token(Token = "0x6011B30")]
    [Address(RVA = "0x42B4A08", Offset = "0x42B4A08", VA = "0x42B4A08")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6011B31")]
    [Address(RVA = "0x42B4A2C", Offset = "0x42B4A2C", VA = "0x42B4A2C")]
    public RewardHorizontal()
    {
    }

    [Token(Token = "0x2002D47")]
    private enum InstanceType
    {
      [Token(Token = "0x400C24E")] Fixed,
      [Token(Token = "0x400C24F")] Flexible,
    }
  }
}
