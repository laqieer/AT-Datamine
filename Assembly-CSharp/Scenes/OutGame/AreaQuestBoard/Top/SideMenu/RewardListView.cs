// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.SideMenu.RewardListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top.SideMenu
{
  [Token(Token = "0x2003905")]
  internal class RewardListView : MonoBehaviour
  {
    [Token(Token = "0x400F942")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rewardIconParent;
    [Token(Token = "0x400F943")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RewardIconView rewardIcon;
    [Token(Token = "0x400F944")]
    [FieldOffset(Offset = "0x28")]
    private List<RewardIconView> createIcons;

    [Token(Token = "0x601669F")]
    [Address(RVA = "0x208372C", Offset = "0x208372C", VA = "0x208372C")]
    public void SetReward(
      IReadOnlyList<BattleRewardDescriptionData> rewards,
      Action<RewardTypeEnum, int> openItemDetailAction,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60166A0")]
    [Address(RVA = "0x2083BAC", Offset = "0x2083BAC", VA = "0x2083BAC")]
    public void SetReward(
      List<StaqData.RewardData> rewards,
      Action<RewardTypeEnum, int> openItemDetailAction,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60166A1")]
    [Address(RVA = "0x2083F10", Offset = "0x2083F10", VA = "0x2083F10")]
    public RewardListView()
    {
    }
  }
}
