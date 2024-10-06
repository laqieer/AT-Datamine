// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.DamageRewardView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029B7")]
  internal class DamageRewardView : MonoBehaviour
  {
    [Token(Token = "0x400B1B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400B1B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400B1B6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MnemnographThumb mnemnographThumb;
    [Token(Token = "0x400B1B7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform damageRewardParent;
    [Token(Token = "0x400B1B8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject titleObj;

    [Token(Token = "0x6010610")]
    [Address(RVA = "0x4885080", Offset = "0x4885080", VA = "0x4885080")]
    public void SetReward(
      int suppressId,
      int score,
      int maxHp,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010611")]
    [Address(RVA = "0x488536C", Offset = "0x488536C", VA = "0x488536C")]
    private void CreateRewardIcon(
      GuildRaidRewardSuppressDetailData reward,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010612")]
    [Address(RVA = "0x488575C", Offset = "0x488575C", VA = "0x488575C")]
    public DamageRewardView()
    {
    }
  }
}
