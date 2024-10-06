// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.SubjugationRewardView
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
  [Token(Token = "0x20029E8")]
  internal class SubjugationRewardView : MonoBehaviour
  {
    [Token(Token = "0x400B2AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400B2AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400B2AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MnemnographThumb mnemnographThumb;
    [Token(Token = "0x400B2AE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform subjugationRewardParent;

    [Token(Token = "0x601072D")]
    [Address(RVA = "0x488FE84", Offset = "0x488FE84", VA = "0x488FE84")]
    public void SetReward(
      int suppressId,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601072E")]
    [Address(RVA = "0x4890038", Offset = "0x4890038", VA = "0x4890038")]
    private void CreateRewardIcon(
      GuildRaidRewardSuppressDetailData reward,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601072F")]
    [Address(RVA = "0x4890428", Offset = "0x4890428", VA = "0x4890428")]
    public SubjugationRewardView()
    {
    }
  }
}
