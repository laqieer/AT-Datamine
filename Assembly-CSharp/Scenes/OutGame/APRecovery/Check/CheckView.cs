// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.Check.CheckView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.APRecovery.Check
{
  [Token(Token = "0x2003978")]
  public class CheckView : MonoBehaviour
  {
    [Token(Token = "0x400FB1B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("メッセージ")]
    private Text _messageBody;
    [Token(Token = "0x400FB1C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("APアイコン")]
    private APIconView _iconView;
    [Token(Token = "0x400FB1D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("伝晶石表示")]
    private Text _coinPaid;
    [Token(Token = "0x400FB1E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _coinFree;
    [Token(Token = "0x400FB1F")]
    [FieldOffset(Offset = "0x38")]
    [Header("ボタン")]
    [SerializeField]
    private CommonButton _buttonClose;
    [Token(Token = "0x400FB20")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton _buttonRecovery;
    [Token(Token = "0x400FB21")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton _buttonLaw;
    [Token(Token = "0x400FB22")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x6016972")]
    [Address(RVA = "0x42F2308", Offset = "0x42F2308", VA = "0x42F2308")]
    public void SetMessageValue(int consumeCoin, int recoveryAp)
    {
    }

    [Token(Token = "0x6016973")]
    [Address(RVA = "0x42F23F0", Offset = "0x42F23F0", VA = "0x42F23F0")]
    public void SetApIcon(int nowAp, int recoveryAp)
    {
    }

    [Token(Token = "0x6016974")]
    [Address(RVA = "0x42F2408", Offset = "0x42F2408", VA = "0x42F2408")]
    public void SetCoinDiff(int prevCoinPaid, int prevCoinFree)
    {
    }

    [Token(Token = "0x6016975")]
    [Address(RVA = "0x42F24B4", Offset = "0x42F24B4", VA = "0x42F24B4")]
    public void SetButtonCloseEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6016976")]
    [Address(RVA = "0x42F25B0", Offset = "0x42F25B0", VA = "0x42F25B0")]
    public void SetButtonRecoveryEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6016977")]
    [Address(RVA = "0x42F2600", Offset = "0x42F2600", VA = "0x42F2600")]
    public void SetButtonLawEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6016978")]
    [Address(RVA = "0x42F29D4", Offset = "0x42F29D4", VA = "0x42F29D4")]
    public CheckView()
    {
    }
  }
}
