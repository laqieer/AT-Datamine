// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.QuestMissionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003752")]
  public class QuestMissionCell : MonoBehaviour
  {
    [Token(Token = "0x400F1A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F1A6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] checkMark;
    [Token(Token = "0x400F1A7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text missionText;
    [Token(Token = "0x400F1A8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text rewardItemNameText;
    [Token(Token = "0x400F1A9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text rewardItemNumText;
    [Token(Token = "0x400F1AA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private MissionRewardItemThumb rewardItemThumb;
    [Token(Token = "0x400F1AB")]
    [FieldOffset(Offset = "0x48")]
    private Func<string> quantityText;
    [Token(Token = "0x400F1AC")]
    [FieldOffset(Offset = "0x50")]
    private bool markCheck;
    [Token(Token = "0x400F1AD")]
    [FieldOffset(Offset = "0x51")]
    private bool playAnimation;
    [Token(Token = "0x400F1AE")]
    [FieldOffset(Offset = "0x54")]
    private float markWaitTime;
    [Token(Token = "0x400F1AF")]
    [FieldOffset(Offset = "0x58")]
    private bool isInitialized;

    [Token(Token = "0x6015C91")]
    [Address(RVA = "0x1B2B560", Offset = "0x1B2B560", VA = "0x1B2B560")]
    public void Initialized(
      AssetCachedSpawner assetCachedSpawner,
      List<BattleRewardDescriptionData> rewards,
      string missionName,
      bool isClear,
      bool isAnimation,
      float markWait,
      Action<RewardTypeEnum, int> OpenItemDetail)
    {
    }

    [Token(Token = "0x6015C92")]
    [Address(RVA = "0x1B2BBB4", Offset = "0x1B2BBB4", VA = "0x1B2BBB4")]
    private void SetCheckMark(bool isOn)
    {
    }

    [Token(Token = "0x6015C93")]
    [Address(RVA = "0x1B2BC24", Offset = "0x1B2BC24", VA = "0x1B2BC24")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6015C94")]
    [Address(RVA = "0x1B2BC64", Offset = "0x1B2BC64", VA = "0x1B2BC64")]
    private IEnumerator ClearMarkdisp() => (IEnumerator) null;

    [Token(Token = "0x6015C95")]
    [Address(RVA = "0x1B2BCF4", Offset = "0x1B2BCF4", VA = "0x1B2BCF4")]
    public QuestMissionCell()
    {
    }
  }
}
