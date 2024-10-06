// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Attend.AttendRewardListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Attend
{
  [Token(Token = "0x2002C4B")]
  public class AttendRewardListItem : InfiniteCellBase
  {
    [Token(Token = "0x400BCB6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text requiredAttend;
    [Token(Token = "0x400BCB7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemIconPrefab;
    [Token(Token = "0x400BCB8")]
    [FieldOffset(Offset = "0x38")]
    private List<ItemIcon> itemIcons;

    [Token(Token = "0x60115B5")]
    [Address(RVA = "0x4E18114", Offset = "0x4E18114", VA = "0x4E18114")]
    public void SetData(
      AssetCachedSpawner spawner,
      int requiredAttend,
      List<(RewardTypeEnum rewardType, int rewardId, int quantity)> info,
      Action<RewardTypeEnum, int> onClick)
    {
    }

    [Token(Token = "0x60115B6")]
    [Address(RVA = "0x4E185CC", Offset = "0x4E185CC", VA = "0x4E185CC", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60115B7")]
    [Address(RVA = "0x4E18670", Offset = "0x4E18670", VA = "0x4E18670")]
    public AttendRewardListItem()
    {
    }

    [Token(Token = "0x2002C4C")]
    public class AttendRewardCellData
    {
      [Token(Token = "0x400BCB9")]
      [FieldOffset(Offset = "0x10")]
      public AssetCachedSpawner spawner;
      [Token(Token = "0x400BCBA")]
      [FieldOffset(Offset = "0x18")]
      public int requiredAttend;
      [Token(Token = "0x400BCBB")]
      [FieldOffset(Offset = "0x20")]
      public List<(RewardTypeEnum rewardType, int rewardId, int quantity)> itemInfo;
      [Token(Token = "0x400BCBC")]
      [FieldOffset(Offset = "0x28")]
      public Action<RewardTypeEnum, int> onClick;

      [Token(Token = "0x60115B8")]
      [Address(RVA = "0x4E17BD0", Offset = "0x4E17BD0", VA = "0x4E17BD0")]
      public AttendRewardCellData()
      {
      }
    }
  }
}
