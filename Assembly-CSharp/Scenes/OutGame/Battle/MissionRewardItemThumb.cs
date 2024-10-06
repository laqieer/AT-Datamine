// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.MissionRewardItemThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003749")]
  public class MissionRewardItemThumb : MonoBehaviour
  {
    [Token(Token = "0x400F16A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400F16B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400F16C")]
    [FieldOffset(Offset = "0x28")]
    private ItemUtility.Parameter itemParam;
    [Token(Token = "0x400F16D")]
    [FieldOffset(Offset = "0x88")]
    private bool isInitialized;
    [Token(Token = "0x400F16E")]
    [FieldOffset(Offset = "0x90")]
    private BattleRewardDescriptionData reward;

    [Token(Token = "0x6015C55")]
    [Address(RVA = "0x1B289BC", Offset = "0x1B289BC", VA = "0x1B289BC")]
    public void Initialized(
      BattleRewardDescriptionData reward,
      Action<RewardTypeEnum, int> OpenItemDetail)
    {
    }

    [Token(Token = "0x6015C56")]
    [Address(RVA = "0x1B29188", Offset = "0x1B29188", VA = "0x1B29188")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6015C57")]
    [Address(RVA = "0x1B291B8", Offset = "0x1B291B8", VA = "0x1B291B8")]
    private IEnumerator LoadWaitthumb() => (IEnumerator) null;

    [Token(Token = "0x6015C58")]
    [Address(RVA = "0x1B28D24", Offset = "0x1B28D24", VA = "0x1B28D24")]
    public void PlayInTween()
    {
    }

    [Token(Token = "0x6015C59")]
    [Address(RVA = "0x1B29248", Offset = "0x1B29248", VA = "0x1B29248")]
    public MissionRewardItemThumb()
    {
    }
  }
}
