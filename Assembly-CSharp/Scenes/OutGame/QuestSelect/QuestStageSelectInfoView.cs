// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestStageSelectInfoView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033FF")]
  internal class QuestStageSelectInfoView : MonoBehaviour
  {
    [Token(Token = "0x400E215")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestStageSelectInfo[] questInfos;
    [Token(Token = "0x400E216")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton[] buttons;
    [Token(Token = "0x400E217")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayableDirector playableDirectorPrevQuestInfo;
    [Token(Token = "0x400E218")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayableDirector playableDirectorNextQuestInfo;
    [Token(Token = "0x400E219")]
    [FieldOffset(Offset = "0x38")]
    private QuestInfo questData;
    [Token(Token = "0x400E21A")]
    [FieldOffset(Offset = "0x40")]
    private List<QuestStageSelectInfoView.ChangeInfoData> changeInfos;

    [Token(Token = "0x60146FA")]
    [Address(RVA = "0x1891600", Offset = "0x1891600", VA = "0x1891600")]
    public void Initialize(QuestAssetLoader assetLoader, Action<RewardTypeEnum, int> action)
    {
    }

    [Token(Token = "0x60146FB")]
    [Address(RVA = "0x1891644", Offset = "0x1891644", VA = "0x1891644")]
    public void setInfo(QuestInfo info)
    {
    }

    [Token(Token = "0x60146FC")]
    [Address(RVA = "0x1891674", Offset = "0x1891674", VA = "0x1891674")]
    private bool isPlayAnimation() => new bool();

    [Token(Token = "0x60146FD")]
    [Address(RVA = "0x1891728", Offset = "0x1891728", VA = "0x1891728")]
    public void PrevInfo(QuestInfo info)
    {
    }

    [Token(Token = "0x60146FE")]
    [Address(RVA = "0x1891978", Offset = "0x1891978", VA = "0x1891978")]
    public void NextInfo(QuestInfo info)
    {
    }

    [Token(Token = "0x60146FF")]
    [Address(RVA = "0x1891730", Offset = "0x1891730", VA = "0x1891730")]
    private void AddInfo(QuestInfo info, QuestStageSelectInfoView.ChangeInfoState state)
    {
    }

    [Token(Token = "0x6014700")]
    [Address(RVA = "0x1891980", Offset = "0x1891980", VA = "0x1891980")]
    private IEnumerator ChangeInfo(QuestStageSelectInfoView.ChangeInfoData changeInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014701")]
    [Address(RVA = "0x1891A24", Offset = "0x1891A24", VA = "0x1891A24")]
    private void Update()
    {
    }

    [Token(Token = "0x6014702")]
    [Address(RVA = "0x1891A28", Offset = "0x1891A28", VA = "0x1891A28")]
    private void UpdateChangeInfo()
    {
    }

    [Token(Token = "0x6014703")]
    [Address(RVA = "0x1891B00", Offset = "0x1891B00", VA = "0x1891B00")]
    public void VisiblePrevQuestButton(bool sw)
    {
    }

    [Token(Token = "0x6014704")]
    [Address(RVA = "0x1891B44", Offset = "0x1891B44", VA = "0x1891B44")]
    public void VisibleNextQuestButton(bool sw)
    {
    }

    [Token(Token = "0x6014705")]
    [Address(RVA = "0x1891B8C", Offset = "0x1891B8C", VA = "0x1891B8C")]
    public void OnSetNextOrPrevInfoSignal()
    {
    }

    [Token(Token = "0x6014706")]
    [Address(RVA = "0x1891B94", Offset = "0x1891B94", VA = "0x1891B94")]
    public QuestStageSelectInfoView()
    {
    }

    [Token(Token = "0x2003400")]
    private enum ChangeInfoState
    {
      [Token(Token = "0x400E21C")] Next,
      [Token(Token = "0x400E21D")] Prev,
    }

    [Token(Token = "0x2003401")]
    private struct ChangeInfoData
    {
      [Token(Token = "0x400E21E")]
      [FieldOffset(Offset = "0x0")]
      public QuestInfo info;
      [Token(Token = "0x400E21F")]
      [FieldOffset(Offset = "0x8")]
      public QuestStageSelectInfoView.ChangeInfoState state;
    }
  }
}
