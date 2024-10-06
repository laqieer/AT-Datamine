// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindLoseDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.Utilities.SerializeUI;
using UnityEngine;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x200245B")]
  public class BattleRewindLoseDialog : MonoBehaviour
  {
    [Token(Token = "0x4009BF7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController fadeController;
    [Token(Token = "0x4009BF8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextContainer goldRareItemCountText;
    [Token(Token = "0x4009BF9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextContainer silverRareItemCountText;
    [Token(Token = "0x4009BFA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextContainer copperRareItemCountText;
    [Token(Token = "0x4009BFB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x4009BFC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton closeButton;

    [Token(Token = "0x600DF0F")]
    [Address(RVA = "0x2016E38", Offset = "0x2016E38", VA = "0x2016E38")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x600DF10")]
    [Address(RVA = "0x20151A0", Offset = "0x20151A0", VA = "0x20151A0")]
    public void Show(Action callback = null)
    {
    }

    [Token(Token = "0x600DF11")]
    [Address(RVA = "0x2015600", Offset = "0x2015600", VA = "0x2015600")]
    public void Hide(Action callback = null)
    {
    }

    [Token(Token = "0x600DF12")]
    [Address(RVA = "0x2014DE0", Offset = "0x2014DE0", VA = "0x2014DE0")]
    public void SetButtonEvent(Action decideFunction, Action closeFunction)
    {
    }

    [Token(Token = "0x600DF13")]
    [Address(RVA = "0x2017200", Offset = "0x2017200", VA = "0x2017200")]
    public void SetUpLosePanelInformation(IReadOnlyDictionary<int, int> dropItems)
    {
    }

    [Token(Token = "0x600DF14")]
    [Address(RVA = "0x20174A0", Offset = "0x20174A0", VA = "0x20174A0")]
    public BattleRewindLoseDialog()
    {
    }
  }
}
