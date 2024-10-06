// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.MissionFirstClearCell
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

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003745")]
  public class MissionFirstClearCell : MonoBehaviour
  {
    [Token(Token = "0x400F157")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F158")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] checkMark;
    [Token(Token = "0x400F159")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform rewardItemThumbParent;
    [Token(Token = "0x400F15A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private MissionRewardItemThumb rewardItemThumbPrefab;
    [Token(Token = "0x400F15C")]
    [FieldOffset(Offset = "0x40")]
    private List<BattleRewardDescriptionData> rewards;
    [Token(Token = "0x400F15D")]
    [FieldOffset(Offset = "0x48")]
    private Func<string> quantityText;
    [Token(Token = "0x400F15E")]
    [FieldOffset(Offset = "0x50")]
    private bool isInitialized;
    [Token(Token = "0x400F15F")]
    [FieldOffset(Offset = "0x51")]
    private bool markCheck;
    [Token(Token = "0x400F160")]
    [FieldOffset(Offset = "0x54")]
    private float markWaitTime;

    [Token(Token = "0x170047F6")]
    public List<MissionRewardItemThumb> rewardItemThumbList
    {
      [Token(Token = "0x6015C45"), Address(RVA = "0x1B27E6C", Offset = "0x1B27E6C", VA = "0x1B27E6C")] get
      {
        return (List<MissionRewardItemThumb>) null;
      }
      [Token(Token = "0x6015C46"), Address(RVA = "0x1B27E74", Offset = "0x1B27E74", VA = "0x1B27E74")] private set
      {
      }
    }

    [Token(Token = "0x6015C47")]
    [Address(RVA = "0x1B27E7C", Offset = "0x1B27E7C", VA = "0x1B27E7C")]
    public void Initialized(
      AssetCachedSpawner assetCachedSpawner,
      IReadOnlyList<BattleRewardDescriptionData> rewards,
      float markWait,
      MissionFirstClearCell.eMissionClearState clearState,
      Action<RewardTypeEnum, int> OpenItemDetail)
    {
    }

    [Token(Token = "0x6015C48")]
    [Address(RVA = "0x1B28B0C", Offset = "0x1B28B0C", VA = "0x1B28B0C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6015C49")]
    [Address(RVA = "0x1B28B4C", Offset = "0x1B28B4C", VA = "0x1B28B4C")]
    private IEnumerator ClearMarkdisp() => (IEnumerator) null;

    [Token(Token = "0x6015C4A")]
    [Address(RVA = "0x1B28BDC", Offset = "0x1B28BDC", VA = "0x1B28BDC")]
    public void ShowRewardItemThumbs()
    {
    }

    [Token(Token = "0x6015C4B")]
    [Address(RVA = "0x1B28D7C", Offset = "0x1B28D7C", VA = "0x1B28D7C")]
    public MissionFirstClearCell()
    {
    }

    [Token(Token = "0x2003746")]
    public enum eMissionClearState
    {
      [Token(Token = "0x400F162")] Clear_Not,
      [Token(Token = "0x400F163")] Clear_Now,
      [Token(Token = "0x400F164")] Clear_Done,
    }
  }
}
