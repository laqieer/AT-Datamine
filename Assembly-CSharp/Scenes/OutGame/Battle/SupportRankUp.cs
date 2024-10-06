// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.SupportRankUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003790")]
  public class SupportRankUp : ResultViewBase
  {
    [Token(Token = "0x400F29E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F29F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image leftCharactorImage;
    [Token(Token = "0x400F2A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image leftLoadingImage;
    [Token(Token = "0x400F2A1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image rightCharactorImage;
    [Token(Token = "0x400F2A2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image rightLoadingImage;
    [Token(Token = "0x400F2A3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text leftCharactorNameText;
    [Token(Token = "0x400F2A4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text rightCharactorNameText;
    [Token(Token = "0x400F2A5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text oldRankText;
    [Token(Token = "0x400F2A6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI newRankText;
    [Token(Token = "0x400F2A7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400F2A8")]
    [FieldOffset(Offset = "0x78")]
    private bool inDirect;
    [Token(Token = "0x400F2A9")]
    [FieldOffset(Offset = "0x80")]
    private string[] rankTextList;
    [Token(Token = "0x400F2AA")]
    [FieldOffset(Offset = "0x88")]
    private bool isInitialized;
    [Token(Token = "0x400F2AB")]
    [FieldOffset(Offset = "0x8C")]
    private int lChrID;
    [Token(Token = "0x400F2AC")]
    [FieldOffset(Offset = "0x90")]
    private int rChrID;

    [Token(Token = "0x6015E05")]
    [Address(RVA = "0x231F520", Offset = "0x231F520", VA = "0x231F520")]
    public void Initialize(
      BattleResultSubScene subScene,
      int leftChrID,
      int rightChrID,
      SupportRankTypeEnum oldRank,
      SupportRankTypeEnum newRank)
    {
    }

    [Token(Token = "0x6015E06")]
    [Address(RVA = "0x231F934", Offset = "0x231F934", VA = "0x231F934")]
    private IEnumerator ExecutePlay() => (IEnumerator) null;

    [Token(Token = "0x6015E07")]
    [Address(RVA = "0x231F9C4", Offset = "0x231F9C4", VA = "0x231F9C4")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6015E08")]
    [Address(RVA = "0x231FA4C", Offset = "0x231FA4C", VA = "0x231FA4C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015E09")]
    [Address(RVA = "0x231F9E4", Offset = "0x231F9E4", VA = "0x231F9E4")]
    private IEnumerator LoadwaitCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6015E0A")]
    [Address(RVA = "0x231FC4C", Offset = "0x231FC4C", VA = "0x231FC4C")]
    private IEnumerator LoadWaitthumb(int chrID, Image image, Image loading) => (IEnumerator) null;

    [Token(Token = "0x6015E0B")]
    [Address(RVA = "0x231F8B4", Offset = "0x231F8B4", VA = "0x231F8B4")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015E0C")]
    [Address(RVA = "0x231FD18", Offset = "0x231FD18", VA = "0x231FD18")]
    public SupportRankUp()
    {
    }
  }
}
