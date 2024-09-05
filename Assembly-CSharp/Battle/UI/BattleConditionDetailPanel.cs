// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleConditionDetailPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200237B")]
  public class BattleConditionDetailPanel : BattlePopupPanel
  {
    [Token(Token = "0x4009717")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform[] headerObjects;
    [Token(Token = "0x4009718")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform[] footerObjects;
    [Token(Token = "0x4009719")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BattleConditionScrollView scrollView;
    [Token(Token = "0x400971A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x600D8B6")]
    [Address(RVA = "0x1B98910", Offset = "0x1B98910", VA = "0x1B98910", Slot = "10")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600D8B7")]
    [Address(RVA = "0x1B935F4", Offset = "0x1B935F4", VA = "0x1B935F4")]
    public void UpdateView(StatusConditionModel[] models)
    {
    }

    [Token(Token = "0x600D8B8")]
    [Address(RVA = "0x1B98A50", Offset = "0x1B98A50", VA = "0x1B98A50")]
    public BattleConditionDetailPanel()
    {
    }
  }
}
