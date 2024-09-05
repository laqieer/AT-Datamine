// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003965")]
  public class ApRecoveryView : MonoBehaviour
  {
    [Token(Token = "0x400FAD2")]
    [FieldOffset(Offset = "0x18")]
    [Header("現在の所持数")]
    [SerializeField]
    private Text _coinNumTextPaid;
    [Token(Token = "0x400FAD3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _coinNumTextFree;
    [Token(Token = "0x400FAD4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text _itemNumText;
    [Token(Token = "0x400FAD5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Color enoughColor;
    [Token(Token = "0x400FAD6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Color shortageColor;
    [Token(Token = "0x400FAD7")]
    [FieldOffset(Offset = "0x50")]
    [Header("AP回復数")]
    [SerializeField]
    private Text _recoveryCountText;
    [Token(Token = "0x400FAD8")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private APIconView _recoveryIconView;
    [Token(Token = "0x400FAD9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton _buttonSelectLeft;
    [Token(Token = "0x400FADA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton _buttonSelectRight;
    [Token(Token = "0x400FADB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text _itemUseText;
    [Token(Token = "0x400FADC")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text _coinUseText;
    [Token(Token = "0x400FADD")]
    [FieldOffset(Offset = "0x80")]
    [Header("回復ボタン")]
    [SerializeField]
    private CommonButton _buttonUseItem;
    [Token(Token = "0x400FADE")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text _itemRecoveryRemainingCountText;
    [Token(Token = "0x400FADF")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton _buttonUseCoin;
    [Token(Token = "0x400FAE0")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text _coinRecoveryRemainingCountText;
    [Token(Token = "0x400FAE1")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Image _iconButtonUseItem;
    [Token(Token = "0x400FAE2")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Image _iconButtonUseCoin;
    [Token(Token = "0x400FAE3")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Color enableColor;
    [Token(Token = "0x400FAE4")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Color disableColor;
    [Token(Token = "0x400FAE5")]
    [FieldOffset(Offset = "0xD0")]
    private bool isUseItemButtonDisable;
    [Token(Token = "0x400FAE6")]
    [FieldOffset(Offset = "0xD1")]
    private bool isUseCoinButtonDisable;

    [Token(Token = "0x60168F8")]
    [Address(RVA = "0x42EFAFC", Offset = "0x42EFAFC", VA = "0x42EFAFC")]
    public void Initialize(
      int coinPaid,
      int coinFree,
      int itemNum,
      int ap,
      bool canDecRecoverAp,
      bool canIncRecoverAp,
      int itemRecoveryRemainingCount,
      int coinRecoveryRemainingCount)
    {
    }

    [Token(Token = "0x60168F9")]
    [Address(RVA = "0x42F09B0", Offset = "0x42F09B0", VA = "0x42F09B0")]
    public void SetInitAp(int ap)
    {
    }

    [Token(Token = "0x60168FA")]
    [Address(RVA = "0x42F0760", Offset = "0x42F0760", VA = "0x42F0760")]
    public void SetHavingNum(int coinNumPaid, int coinNumFree, int itemNum)
    {
    }

    [Token(Token = "0x60168FB")]
    [Address(RVA = "0x42F015C", Offset = "0x42F015C", VA = "0x42F015C")]
    public void SetRecoveryIconAp(int ap, int recoveryAp)
    {
    }

    [Token(Token = "0x60168FC")]
    [Address(RVA = "0x42F016C", Offset = "0x42F016C", VA = "0x42F016C")]
    public void SetRecoveryCountText(int ap)
    {
    }

    [Token(Token = "0x60168FD")]
    [Address(RVA = "0x42F01F8", Offset = "0x42F01F8", VA = "0x42F01F8")]
    public void SetRecoveryUseText(int item, int coin)
    {
    }

    [Token(Token = "0x60168FE")]
    [Address(RVA = "0x42EFCD4", Offset = "0x42EFCD4", VA = "0x42EFCD4")]
    public void SetSelectEvent(UnityAction left, UnityAction right)
    {
    }

    [Token(Token = "0x60168FF")]
    [Address(RVA = "0x42F01B4", Offset = "0x42F01B4", VA = "0x42F01B4")]
    public void SetSelectButtonEnable(bool isEnableLeft, bool isEnableRight)
    {
    }

    [Token(Token = "0x6016900")]
    [Address(RVA = "0x42F09C4", Offset = "0x42F09C4", VA = "0x42F09C4")]
    public void SetRecoveryRemainingCount(int item, int coin)
    {
    }

    [Token(Token = "0x6016901")]
    [Address(RVA = "0x42F026C", Offset = "0x42F026C", VA = "0x42F026C")]
    public void SetRecoveryButtonEnable(bool isEnable)
    {
    }

    [Token(Token = "0x6016902")]
    [Address(RVA = "0x42EFD5C", Offset = "0x42EFD5C", VA = "0x42EFD5C")]
    public void SetButtonUseItemEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6016903")]
    [Address(RVA = "0x42EFDAC", Offset = "0x42EFDAC", VA = "0x42EFDAC")]
    public void SetButtonUseCoinEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6016904")]
    [Address(RVA = "0x42EFBB4", Offset = "0x42EFBB4", VA = "0x42EFBB4")]
    public void SetDisabledColorButtonUseItem(bool isDisabled)
    {
    }

    [Token(Token = "0x6016905")]
    [Address(RVA = "0x42EFC44", Offset = "0x42EFC44", VA = "0x42EFC44")]
    public void SetDisabledColorButtonUseCoin(bool isDisabled)
    {
    }

    [Token(Token = "0x6016906")]
    [Address(RVA = "0x42F0A38", Offset = "0x42F0A38", VA = "0x42F0A38")]
    public ApRecoveryView()
    {
    }
  }
}
