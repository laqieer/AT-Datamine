// Decompiled with JetBrains decompiler
// Type: Story.Facility.FacilityInfoPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Facility
{
  [Token(Token = "0x20006AA")]
  public class FacilityInfoPopup : PopupBase
  {
    [Token(Token = "0x4001FE9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private FacilityInfoContainer container;
    [Token(Token = "0x4001FEA")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x4001FEB")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x4001FEC")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4001FED")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x1700058E")]
    public Action OnClickFastTravelAction
    {
      [Token(Token = "0x60025CF"), Address(RVA = "0x2F3E60C", Offset = "0x2F3E60C", VA = "0x2F3E60C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60025D0"), Address(RVA = "0x2F3E614", Offset = "0x2F3E614", VA = "0x2F3E614")] set
      {
      }
    }

    [Token(Token = "0x60025D1")]
    [Address(RVA = "0x2F3E61C", Offset = "0x2F3E61C", VA = "0x2F3E61C")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x60025D2")]
    [Address(RVA = "0x2F3E648", Offset = "0x2F3E648", VA = "0x2F3E648")]
    public void SetData(int facilityId, GameObject itemIconPrefab)
    {
    }

    [Token(Token = "0x60025D3")]
    [Address(RVA = "0x2F3E878", Offset = "0x2F3E878", VA = "0x2F3E878")]
    public void OnClickToFastTravel()
    {
    }

    [Token(Token = "0x60025D4")]
    [Address(RVA = "0x2F3E894", Offset = "0x2F3E894", VA = "0x2F3E894")]
    public FacilityInfoPopup()
    {
    }
  }
}
