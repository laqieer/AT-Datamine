// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.MissionSubCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200374C")]
  public class MissionSubCell : MonoBehaviour
  {
    [Token(Token = "0x400F174")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F175")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] checkMark;
    [Token(Token = "0x400F176")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text missionText;
    [Token(Token = "0x400F177")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject[] subThumb;
    [Token(Token = "0x400F178")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image[] charThumb;
    [Token(Token = "0x400F179")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image[] markThumb;
    [Token(Token = "0x400F17A")]
    [FieldOffset(Offset = "0x48")]
    private ItemUtility.Parameter itemParam;
    [Token(Token = "0x400F17B")]
    [FieldOffset(Offset = "0xA8")]
    private int itemID;
    [Token(Token = "0x400F17C")]
    [FieldOffset(Offset = "0xAC")]
    private bool isInitialized;
    [Token(Token = "0x400F17D")]
    [FieldOffset(Offset = "0xAD")]
    private bool markCheck;
    [Token(Token = "0x400F17E")]
    [FieldOffset(Offset = "0xAE")]
    private bool playAnimation;
    [Token(Token = "0x400F17F")]
    [FieldOffset(Offset = "0xB0")]
    private float markWaitTime;
    [Token(Token = "0x400F180")]
    [FieldOffset(Offset = "0xB8")]
    private List<StoryBattleMissionRewardDescriptionData> missionReward;

    [Token(Token = "0x6015C62")]
    [Address(RVA = "0x1B294A4", Offset = "0x1B294A4", VA = "0x1B294A4")]
    public void Initialized(
      List<StoryBattleMissionRewardDescriptionData> missionReward,
      string missionName,
      bool isClear,
      bool isAnimation,
      float markWait)
    {
    }

    [Token(Token = "0x6015C63")]
    [Address(RVA = "0x1B29A04", Offset = "0x1B29A04", VA = "0x1B29A04")]
    private void SetCheckMark(bool isOn)
    {
    }

    [Token(Token = "0x6015C64")]
    [Address(RVA = "0x1B29A74", Offset = "0x1B29A74", VA = "0x1B29A74")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6015C65")]
    [Address(RVA = "0x1B29B0C", Offset = "0x1B29B0C", VA = "0x1B29B0C")]
    public void RewardItemClick(int idx)
    {
    }

    [Token(Token = "0x6015C66")]
    [Address(RVA = "0x1B29AA4", Offset = "0x1B29AA4", VA = "0x1B29AA4")]
    private IEnumerator ClearMarkdisp() => (IEnumerator) null;

    [Token(Token = "0x6015C67")]
    [Address(RVA = "0x1B29B38", Offset = "0x1B29B38", VA = "0x1B29B38")]
    public MissionSubCell()
    {
    }
  }
}
