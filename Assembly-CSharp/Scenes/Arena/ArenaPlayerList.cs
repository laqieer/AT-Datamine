// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaPlayerList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003147")]
  public class ArenaPlayerList : ArenaPlayerListEnemy
  {
    [Token(Token = "0x400D1CE")]
    [FieldOffset(Offset = "0x90")]
    private List<PlayerDeckSlotInfo> deck;
    [Token(Token = "0x400D1CF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text timeRewardText;
    [Token(Token = "0x400D1D0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text timeRewardPerHourText;
    [Token(Token = "0x400D1D1")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject campaignObj;
    [Token(Token = "0x400D1D2")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button rewardButton;
    [Token(Token = "0x400D1D3")]
    [FieldOffset(Offset = "0xB8")]
    private bool isCampaign;

    [Token(Token = "0x60133B5")]
    [Address(RVA = "0x4A214CC", Offset = "0x4A214CC", VA = "0x4A214CC")]
    public void Initialize(APIArenaDetailResponse detail, ArenaTopSceneBase sceneBase, bool lowest)
    {
    }

    [Token(Token = "0x60133B6")]
    [Address(RVA = "0x4A21A8C", Offset = "0x4A21A8C", VA = "0x4A21A8C")]
    public void SetTimeReward(int num)
    {
    }

    [Token(Token = "0x60133B7")]
    [Address(RVA = "0x4A2193C", Offset = "0x4A2193C", VA = "0x4A2193C")]
    private void SetTimeReward(APIArenaDetailResponse detail)
    {
    }

    [Token(Token = "0x60133B8")]
    [Address(RVA = "0x4A2153C", Offset = "0x4A2153C", VA = "0x4A2153C")]
    private void SetLeaderUnit()
    {
    }

    [Token(Token = "0x60133B9")]
    [Address(RVA = "0x4A215A4", Offset = "0x4A215A4", VA = "0x4A215A4")]
    private void SetProfile()
    {
    }

    [Token(Token = "0x60133BA")]
    [Address(RVA = "0x4A21708", Offset = "0x4A21708", VA = "0x4A21708")]
    private void SetCombatPower(int combatPower)
    {
    }

    [Token(Token = "0x60133BB")]
    [Address(RVA = "0x4A21CD0", Offset = "0x4A21CD0", VA = "0x4A21CD0")]
    public void ButtonReceive()
    {
    }

    [Token(Token = "0x60133BC")]
    [Address(RVA = "0x4A21D1C", Offset = "0x4A21D1C", VA = "0x4A21D1C")]
    public void ButtonBattleHistory()
    {
    }

    [Token(Token = "0x60133BD")]
    [Address(RVA = "0x4A21DC4", Offset = "0x4A21DC4", VA = "0x4A21DC4")]
    public ArenaPlayerList()
    {
    }
  }
}
