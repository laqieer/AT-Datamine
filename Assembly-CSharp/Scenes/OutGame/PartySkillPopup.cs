// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PartySkillPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Input;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032B0")]
  public class PartySkillPopup : PopupBase
  {
    [Token(Token = "0x400D979")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UnitCellGroup unitCellGroup;
    [Token(Token = "0x400D97A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UnitCellGroup unitCellGroupNonSupport;
    [Token(Token = "0x400D97B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Sprite[] partySprite;
    [Token(Token = "0x400D97C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private UITweener partySkillBtnPartyFormationTweener;
    [Token(Token = "0x400D97D")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D981")]
    [FieldOffset(Offset = "0xC8")]
    private BoardData boardData;
    [Token(Token = "0x400D982")]
    [FieldOffset(Offset = "0xD0")]
    private BattleData battleData;
    [Token(Token = "0x400D983")]
    [FieldOffset(Offset = "0xD8")]
    private OrganizationParty[] partyData;
    [Token(Token = "0x400D984")]
    [FieldOffset(Offset = "0xE0")]
    private int selectPartyIndex;
    [Token(Token = "0x400D985")]
    [FieldOffset(Offset = "0xE4")]
    private bool isSupport;
    [Token(Token = "0x400D986")]
    [FieldOffset(Offset = "0xE8")]
    private OrganizationTeam.TeamSizeType teamSize;

    [Token(Token = "0x170041A1")]
    public Action OnCloseAction
    {
      [Token(Token = "0x6013C9E"), Address(RVA = "0x1ADE4EC", Offset = "0x1ADE4EC", VA = "0x1ADE4EC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013C9F"), Address(RVA = "0x1ADE4F4", Offset = "0x1ADE4F4", VA = "0x1ADE4F4")] set
      {
      }
    }

    [Token(Token = "0x170041A2")]
    public Action OnNextPartyAction
    {
      [Token(Token = "0x6013CA0"), Address(RVA = "0x1ADE4FC", Offset = "0x1ADE4FC", VA = "0x1ADE4FC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013CA1"), Address(RVA = "0x1ADE504", Offset = "0x1ADE504", VA = "0x1ADE504")] set
      {
      }
    }

    [Token(Token = "0x170041A3")]
    public Action OnPrevPartyAction
    {
      [Token(Token = "0x6013CA2"), Address(RVA = "0x1ADE50C", Offset = "0x1ADE50C", VA = "0x1ADE50C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013CA3"), Address(RVA = "0x1ADE514", Offset = "0x1ADE514", VA = "0x1ADE514")] set
      {
      }
    }

    [Token(Token = "0x6013CA4")]
    [Address(RVA = "0x1ADE51C", Offset = "0x1ADE51C", VA = "0x1ADE51C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6013CA5")]
    [Address(RVA = "0x1ADE5A8", Offset = "0x1ADE5A8", VA = "0x1ADE5A8")]
    public void SetData(
      bool isSupport,
      int selectPartyIndex,
      OrganizationParty[] partyData,
      OrganizationTeam.TeamSizeType teamSize)
    {
    }

    [Token(Token = "0x6013CA6")]
    [Address(RVA = "0x1ADECC8", Offset = "0x1ADECC8", VA = "0x1ADECC8")]
    public void SetDataPartyFormation(
      bool isSupport,
      int selectPartyIndex,
      OrganizationParty[] partyData,
      OrganizationTeam.TeamSizeType teamSize)
    {
    }

    [Token(Token = "0x6013CA7")]
    [Address(RVA = "0x1ADE74C", Offset = "0x1ADE74C", VA = "0x1ADE74C")]
    private void ChangeViewParty()
    {
    }

    [Token(Token = "0x6013CA8")]
    [Address(RVA = "0x1ADF504", Offset = "0x1ADF504", VA = "0x1ADF504")]
    public void OnClickArrowPrev()
    {
    }

    [Token(Token = "0x6013CA9")]
    [Address(RVA = "0x1ADF550", Offset = "0x1ADF550", VA = "0x1ADF550")]
    public void OnClickArrowNext()
    {
    }

    [Token(Token = "0x6013CAA")]
    [Address(RVA = "0x1ADF59C", Offset = "0x1ADF59C", VA = "0x1ADF59C")]
    public void OnClickToClose()
    {
    }

    [Token(Token = "0x6013CAB")]
    [Address(RVA = "0x1ADF5B8", Offset = "0x1ADF5B8", VA = "0x1ADF5B8")]
    public PartySkillPopup()
    {
    }
  }
}
