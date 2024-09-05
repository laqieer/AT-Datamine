// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A8")]
  public class UnitPanel : PopupBase
  {
    [Token(Token = "0x40097D0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UnitPanelUI panelUI;
    [Token(Token = "0x40097D1")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40097D3")]
    [FieldOffset(Offset = "0xA0")]
    public Action CloseCallBack;

    [Token(Token = "0x17002F02")]
    private CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x600D9F8"), Address(RVA = "0x22D46BC", Offset = "0x22D46BC", VA = "0x22D46BC")] get
      {
        return (CoroutineHandler) null;
      }
      [Token(Token = "0x600D9F9"), Address(RVA = "0x22D46C4", Offset = "0x22D46C4", VA = "0x22D46C4")] set
      {
      }
    }

    [Token(Token = "0x600D9FA")]
    [Address(RVA = "0x22D46CC", Offset = "0x22D46CC", VA = "0x22D46CC")]
    private void Update()
    {
    }

    [Token(Token = "0x600D9FB")]
    [Address(RVA = "0x22D46E8", Offset = "0x22D46E8", VA = "0x22D46E8")]
    public void Initialize(bool isNeedLp)
    {
    }

    [Token(Token = "0x600D9FC")]
    [Address(RVA = "0x22D47FC", Offset = "0x22D47FC", VA = "0x22D47FC")]
    public UnitPanelUI.UnitPanelView CreateUnitInfoView(Action action)
    {
      return (UnitPanelUI.UnitPanelView) null;
    }

    [Token(Token = "0x600D9FD")]
    [Address(RVA = "0x22D49D8", Offset = "0x22D49D8", VA = "0x22D49D8")]
    public void SetActiveLpUI(bool isEnable)
    {
    }

    [Token(Token = "0x600D9FE")]
    [Address(RVA = "0x22D4B04", Offset = "0x22D4B04", VA = "0x22D4B04")]
    public void SetActiveEquipmentDurableUI(bool isEnable)
    {
    }

    [Token(Token = "0x600D9FF")]
    [Address(RVA = "0x22D4C24", Offset = "0x22D4C24", VA = "0x22D4C24")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600DA00")]
    [Address(RVA = "0x22D4C40", Offset = "0x22D4C40", VA = "0x22D4C40", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x600DA01")]
    [Address(RVA = "0x22D4C90", Offset = "0x22D4C90", VA = "0x22D4C90", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x600DA02")]
    [Address(RVA = "0x22D4C9C", Offset = "0x22D4C9C", VA = "0x22D4C9C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x600DA03")]
    [Address(RVA = "0x22D4D38", Offset = "0x22D4D38", VA = "0x22D4D38")]
    public UnitPanel()
    {
    }
  }
}
