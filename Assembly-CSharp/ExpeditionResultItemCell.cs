// Decompiled with JetBrains decompiler
// Type: ExpeditionResultItemCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using TMPro;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000263")]
public class ExpeditionResultItemCell : InfiniteCellBase
{
  [Token(Token = "0x4000E24")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject Img_Treasure_Gold;
  [Token(Token = "0x4000E25")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private GameObject Img_Treasure_Bronze;
  [Token(Token = "0x4000E26")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private GameObject Img_Treasure_Silver;
  [Token(Token = "0x4000E27")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private ItemIcon itemIcon;
  [Token(Token = "0x4000E28")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private TextMeshProUGUI itemNumText;
  [Token(Token = "0x4000E29")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private Text itemNumText2;

  [Token(Token = "0x17000148")]
  public ItemDetailPopupProvider ItemPopupGenerator
  {
    [Token(Token = "0x6000EFC"), Address(RVA = "0x1C94050", Offset = "0x1C94050", VA = "0x1C94050")] get
    {
      return (ItemDetailPopupProvider) null;
    }
    [Token(Token = "0x6000EFD"), Address(RVA = "0x1C94058", Offset = "0x1C94058", VA = "0x1C94058")] set
    {
    }
  }

  [Token(Token = "0x17000149")]
  public AssetCachedSpawner Spawner
  {
    [Token(Token = "0x6000EFE"), Address(RVA = "0x1C94060", Offset = "0x1C94060", VA = "0x1C94060")] get
    {
      return (AssetCachedSpawner) null;
    }
    [Token(Token = "0x6000EFF"), Address(RVA = "0x1C94068", Offset = "0x1C94068", VA = "0x1C94068")] set
    {
    }
  }

  [Token(Token = "0x1700014A")]
  public Action<ExpeditionResultItemCell.Parameter> CallbackUpdate
  {
    [Token(Token = "0x6000F00"), Address(RVA = "0x1C94070", Offset = "0x1C94070", VA = "0x1C94070")] get
    {
      return (Action<ExpeditionResultItemCell.Parameter>) null;
    }
    [Token(Token = "0x6000F01"), Address(RVA = "0x1C94078", Offset = "0x1C94078", VA = "0x1C94078")] set
    {
    }
  }

  [Token(Token = "0x6000F02")]
  [Address(RVA = "0x1C94080", Offset = "0x1C94080", VA = "0x1C94080", Slot = "4")]
  public override void OnUpdate()
  {
  }

  [Token(Token = "0x6000F03")]
  [Address(RVA = "0x1C93DC8", Offset = "0x1C93DC8", VA = "0x1C93DC8")]
  public void SetInfo(int stageItemDropDescriptionId, AssetCachedSpawner spawner)
  {
  }

  [Token(Token = "0x6000F04")]
  [Address(RVA = "0x1C94194", Offset = "0x1C94194", VA = "0x1C94194")]
  public void Initialize(
    RewardTypeEnum rewardType,
    int rewardId,
    int quantity,
    ItemDetailPopupProvider itemDetailPopupGenerator,
    AssetCachedSpawner spawner)
  {
  }

  [Token(Token = "0x6000F05")]
  [Address(RVA = "0x1C94174", Offset = "0x1C94174", VA = "0x1C94174")]
  public void CancelLoad()
  {
  }

  [Token(Token = "0x6000F06")]
  [Address(RVA = "0x1C94568", Offset = "0x1C94568", VA = "0x1C94568")]
  public ExpeditionResultItemCell()
  {
  }

  [Token(Token = "0x2000264")]
  public class Parameter
  {
    [Token(Token = "0x4000E2D")]
    [FieldOffset(Offset = "0x10")]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x4000E2E")]
    [FieldOffset(Offset = "0x14")]
    public int rewardId;
    [Token(Token = "0x4000E2F")]
    [FieldOffset(Offset = "0x18")]
    public int quantity;

    [Token(Token = "0x6000F07")]
    [Address(RVA = "0x1C94570", Offset = "0x1C94570", VA = "0x1C94570")]
    public Parameter()
    {
    }
  }
}
