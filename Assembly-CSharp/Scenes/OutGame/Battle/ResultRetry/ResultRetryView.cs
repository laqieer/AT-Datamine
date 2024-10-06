// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.ResultRetryView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037C4")]
  public class ResultRetryView : MonoBehaviour
  {
    [Token(Token = "0x400F3BE")]
    [FieldOffset(Offset = "0x18")]
    [Header("表示/非表示制御")]
    [SerializeField]
    private ShowHideCtrl _showHideCtrl;
    [Token(Token = "0x400F3BF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("ボタン")]
    private CommonButton _buttonBackToQuestSelect;
    [Token(Token = "0x400F3C0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F3C1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton _buttonRetryQuest;
    [Token(Token = "0x400F3C2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton _buttonNextQuest;
    [Token(Token = "0x400F3C3")]
    [FieldOffset(Offset = "0x40")]
    [Header("消費コスト")]
    [SerializeField]
    private APIconView _consumeAP;
    [Token(Token = "0x400F3C4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ConsumeItem _consumeEP;
    [Token(Token = "0x400F3C5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ConsumeItem _consumeEPNext;

    [Token(Token = "0x1700489C")]
    public Action<Action> OnClickCallback
    {
      [Token(Token = "0x6015F34"), Address(RVA = "0x232B9D0", Offset = "0x232B9D0", VA = "0x232B9D0")] get
      {
        return (Action<Action>) null;
      }
      [Token(Token = "0x6015F35"), Address(RVA = "0x232B9D8", Offset = "0x232B9D8", VA = "0x232B9D8")] set
      {
      }
    }

    [Token(Token = "0x6015F36")]
    [Address(RVA = "0x232B1A4", Offset = "0x232B1A4", VA = "0x232B1A4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015F37")]
    [Address(RVA = "0x232B588", Offset = "0x232B588", VA = "0x232B588")]
    public void SetEventBackToQuestSelect(Action callback)
    {
    }

    [Token(Token = "0x6015F38")]
    [Address(RVA = "0x232B6D0", Offset = "0x232B6D0", VA = "0x232B6D0")]
    public void SetEventRetryQuest(Action callback)
    {
    }

    [Token(Token = "0x6015F39")]
    [Address(RVA = "0x232B8A0", Offset = "0x232B8A0", VA = "0x232B8A0")]
    public void SetDisabledRetryQuestButton(bool isDisable)
    {
    }

    [Token(Token = "0x6015F3A")]
    [Address(RVA = "0x232B7B8", Offset = "0x232B7B8", VA = "0x232B7B8")]
    public void SetEventNextQuest(Action callback)
    {
    }

    [Token(Token = "0x6015F3B")]
    [Address(RVA = "0x232B8F0", Offset = "0x232B8F0", VA = "0x232B8F0")]
    public void SetDisabledNextQuestButton(bool isDisable)
    {
    }

    [Token(Token = "0x6015F3C")]
    [Address(RVA = "0x232B8C0", Offset = "0x232B8C0", VA = "0x232B8C0")]
    public void SetActiveNextQuestButton(bool isActive)
    {
    }

    [Token(Token = "0x6015F3D")]
    [Address(RVA = "0x232B1A8", Offset = "0x232B1A8", VA = "0x232B1A8")]
    public void ShowHide(BattleComsumeCostTypeEnum costType, bool isShow)
    {
    }

    [Token(Token = "0x6015F3E")]
    [Address(RVA = "0x232BDA8", Offset = "0x232BDA8", VA = "0x232BDA8")]
    public void SetConsumeAP(int ap)
    {
    }

    [Token(Token = "0x6015F3F")]
    [Address(RVA = "0x232B4E4", Offset = "0x232B4E4", VA = "0x232B4E4")]
    public void SetConsumeCost(
      AssetCachedSpawner spawner,
      BattleComsumeCostTypeEnum costType,
      int cost,
      int costItem)
    {
    }

    [Token(Token = "0x6015F40")]
    [Address(RVA = "0x232B52C", Offset = "0x232B52C", VA = "0x232B52C")]
    public void SetNextConsumeCost(
      AssetCachedSpawner spawner,
      BattleComsumeCostTypeEnum costType,
      int cost,
      int costItem)
    {
    }

    [Token(Token = "0x6015F41")]
    [Address(RVA = "0x232B558", Offset = "0x232B558", VA = "0x232B558")]
    public void SetActiveConsumeCostNext(bool isActive)
    {
    }

    [Token(Token = "0x6015F42")]
    [Address(RVA = "0x232BDC0", Offset = "0x232BDC0", VA = "0x232BDC0")]
    private void OnClickButtonBase(Action callback)
    {
    }

    [Token(Token = "0x6015F43")]
    [Address(RVA = "0x232BDFC", Offset = "0x232BDFC", VA = "0x232BDFC")]
    public ResultRetryView()
    {
    }
  }
}
