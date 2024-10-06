// Decompiled with JetBrains decompiler
// Type: Battle.UI.StylePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Style;
using Scenes.OutGame.Info.Style.UI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A7")]
  public class StylePanel : BattlePopupPanel
  {
    [Token(Token = "0x40097CE")]
    [FieldOffset(Offset = "0x90")]
    private StylePopup popup;
    [Token(Token = "0x40097CF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x600D9F2")]
    [Address(RVA = "0x22D45A0", Offset = "0x22D45A0", VA = "0x22D45A0")]
    public void Initialize(StylePopup popup)
    {
    }

    [Token(Token = "0x17002F01")]
    public CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x600D9F3"), Address(RVA = "0x22D4654", Offset = "0x22D4654", VA = "0x22D4654")] get
      {
        return (CoroutineHandler) null;
      }
    }

    [Token(Token = "0x600D9F4")]
    [Address(RVA = "0x22D4670", Offset = "0x22D4670", VA = "0x22D4670")]
    public StylePopupView CreateView(UIManager uiManager = null) => (StylePopupView) null;

    [Token(Token = "0x600D9F5")]
    [Address(RVA = "0x22D468C", Offset = "0x22D468C", VA = "0x22D468C")]
    public StyleStatusView CreateStatusView() => (StyleStatusView) null;

    [Token(Token = "0x600D9F6")]
    [Address(RVA = "0x22D46A8", Offset = "0x22D46A8", VA = "0x22D46A8")]
    public StylePanel()
    {
    }
  }
}
