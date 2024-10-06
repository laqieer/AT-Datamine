// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.EquipmentAdditionalParameterPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035EA")]
  public class EquipmentAdditionalParameterPopup : PopupBase
  {
    [Token(Token = "0x400EA89")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private AdditionalParametersUI additionalParametersUI;

    [Token(Token = "0x170046B4")]
    public CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x60153A1"), Address(RVA = "0x4D8CA6C", Offset = "0x4D8CA6C", VA = "0x4D8CA6C")] get
      {
        return (CoroutineHandler) null;
      }
      [Token(Token = "0x60153A2"), Address(RVA = "0x4D8CA74", Offset = "0x4D8CA74", VA = "0x4D8CA74")] private set
      {
      }
    }

    [Token(Token = "0x60153A3")]
    [Address(RVA = "0x4D8CA7C", Offset = "0x4D8CA7C", VA = "0x4D8CA7C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60153A4")]
    [Address(RVA = "0x4D8CADC", Offset = "0x4D8CADC", VA = "0x4D8CADC")]
    public AdditionalParameterView CreateView() => (AdditionalParameterView) null;

    [Token(Token = "0x60153A5")]
    [Address(RVA = "0x4D8CB40", Offset = "0x4D8CB40", VA = "0x4D8CB40")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60153A6")]
    [Address(RVA = "0x4D8CB58", Offset = "0x4D8CB58", VA = "0x4D8CB58")]
    private void Update()
    {
    }

    [Token(Token = "0x60153A7")]
    [Address(RVA = "0x4D8CB70", Offset = "0x4D8CB70", VA = "0x4D8CB70", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60153A8")]
    [Address(RVA = "0x4D8CB7C", Offset = "0x4D8CB7C", VA = "0x4D8CB7C")]
    public EquipmentAdditionalParameterPopup()
    {
    }
  }
}
