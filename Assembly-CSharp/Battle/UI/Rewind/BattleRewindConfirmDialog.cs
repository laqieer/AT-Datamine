// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindConfirmDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002456")]
  public class BattleRewindConfirmDialog : MonoBehaviour
  {
    [Token(Token = "0x4009BE5")]
    private const string DescriptionReplaceKeyword = "%NeedCoin%";
    [Token(Token = "0x4009BE6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController fadeController;
    [Token(Token = "0x4009BE7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI confirmBeforePaidCoinText;
    [Token(Token = "0x4009BE8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI confirmAfterPaidCoinText;
    [Token(Token = "0x4009BE9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI confirmBeforeFreeCoinText;
    [Token(Token = "0x4009BEA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI confirmAfterFreeCoinText;
    [Token(Token = "0x4009BEB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI confirmDescription;
    [Token(Token = "0x4009BEC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x4009BED")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton closeButton;

    [Token(Token = "0x600DEF7")]
    [Address(RVA = "0x2016EF0", Offset = "0x2016EF0", VA = "0x2016EF0")]
    public void SetConfirmBeforePaidCoin(string value)
    {
    }

    [Token(Token = "0x600DEF8")]
    [Address(RVA = "0x2016EFC", Offset = "0x2016EFC", VA = "0x2016EFC")]
    public void SetConfirmAfterPaidCoin(string value)
    {
    }

    [Token(Token = "0x600DEF9")]
    [Address(RVA = "0x2016F08", Offset = "0x2016F08", VA = "0x2016F08")]
    public void SetConfirmBeforeFreeCoin(string value)
    {
    }

    [Token(Token = "0x600DEFA")]
    [Address(RVA = "0x2016F14", Offset = "0x2016F14", VA = "0x2016F14")]
    public void SetConfirmAfterFreeCoin(string value)
    {
    }

    [Token(Token = "0x600DEFB")]
    [Address(RVA = "0x2016D5C", Offset = "0x2016D5C", VA = "0x2016D5C")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x600DEFC")]
    [Address(RVA = "0x20152C4", Offset = "0x20152C4", VA = "0x20152C4")]
    public void Show(Action callback = null)
    {
    }

    [Token(Token = "0x600DEFD")]
    [Address(RVA = "0x2015704", Offset = "0x2015704", VA = "0x2015704")]
    public void Hide(Action callback = null)
    {
    }

    [Token(Token = "0x600DEFE")]
    [Address(RVA = "0x2014B14", Offset = "0x2014B14", VA = "0x2014B14")]
    public void SetButtonEvent(Action decideFunction, Action closeFunction)
    {
    }

    [Token(Token = "0x600DEFF")]
    [Address(RVA = "0x2016F60", Offset = "0x2016F60", VA = "0x2016F60")]
    public void SetConfirmDescription(int needCoin)
    {
    }

    [Token(Token = "0x600DF00")]
    [Address(RVA = "0x2015BCC", Offset = "0x2015BCC", VA = "0x2015BCC")]
    public void SetInteractableDecideButton(bool enable)
    {
    }

    [Token(Token = "0x600DF01")]
    [Address(RVA = "0x2017014", Offset = "0x2017014", VA = "0x2017014")]
    public BattleRewindConfirmDialog()
    {
    }
  }
}
