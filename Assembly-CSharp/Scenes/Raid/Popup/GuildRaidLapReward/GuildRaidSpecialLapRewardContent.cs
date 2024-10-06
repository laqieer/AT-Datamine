// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidLapReward.GuildRaidSpecialLapRewardContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidLapReward
{
  [Token(Token = "0x20029FF")]
  internal class GuildRaidSpecialLapRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400B2DC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildRaidRewardItemIconBase raidRewardItemIconBase;
    [Token(Token = "0x400B2DD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TMP_Text missionTitle;
    [Token(Token = "0x400B2DE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image receiveIcon;
    [Token(Token = "0x400B2DF")]
    [FieldOffset(Offset = "0x30")]
    private RewardContentBase contentBase;

    [Token(Token = "0x6010770")]
    [Address(RVA = "0x48926D0", Offset = "0x48926D0", VA = "0x48926D0")]
    public void Setup(
      AssetCachedSpawner assetCachedSpawner,
      int missionLap,
      int clearLap,
      IEnumerable<GuildRaidRewardSpecialLapDetailData> data,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x6010771")]
    [Address(RVA = "0x4892C3C", Offset = "0x4892C3C", VA = "0x4892C3C")]
    private void SetTitleSafe(string text)
    {
    }

    [Token(Token = "0x6010772")]
    [Address(RVA = "0x4892CDC", Offset = "0x4892CDC", VA = "0x4892CDC")]
    private void SetActiveSafeReceiveIcon(bool active)
    {
    }

    [Token(Token = "0x6010773")]
    [Address(RVA = "0x4892D80", Offset = "0x4892D80", VA = "0x4892D80")]
    public GuildRaidSpecialLapRewardContent()
    {
    }
  }
}
