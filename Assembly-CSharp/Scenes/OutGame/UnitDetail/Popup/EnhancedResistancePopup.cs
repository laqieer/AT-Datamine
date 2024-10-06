// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Popup.EnhancedResistancePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using StaqData.StatusIcon;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Popup
{
  [Token(Token = "0x2003355")]
  public class EnhancedResistancePopup : PopupBase
  {
    [Token(Token = "0x400DE61")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private EnhancedResistanceIconController iconController;
    [Token(Token = "0x400DE62")]
    [FieldOffset(Offset = "0x90")]
    private IconFactory iconFactory;

    [Token(Token = "0x60142CF")]
    [Address(RVA = "0x1E132B4", Offset = "0x1E132B4", VA = "0x1E132B4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60142D0")]
    [Address(RVA = "0x1E13338", Offset = "0x1E13338", VA = "0x1E13338")]
    public void InitializeStyle(Style style)
    {
    }

    [Token(Token = "0x60142D1")]
    [Address(RVA = "0x1E13358", Offset = "0x1E13358", VA = "0x1E13358", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60142D2")]
    [Address(RVA = "0x1E13364", Offset = "0x1E13364", VA = "0x1E13364")]
    public IEnumerator InitAndOpen(Style style) => (IEnumerator) null;

    [Token(Token = "0x60142D3")]
    [Address(RVA = "0x1E13400", Offset = "0x1E13400", VA = "0x1E13400", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60142D4")]
    [Address(RVA = "0x1E134A4", Offset = "0x1E134A4", VA = "0x1E134A4", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60142D5")]
    [Address(RVA = "0x1E13534", Offset = "0x1E13534", VA = "0x1E13534")]
    public EnhancedResistancePopup()
    {
    }
  }
}
