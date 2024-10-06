// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TeamCopyPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000827")]
  public class TeamCopyPopup : MonoBehaviour
  {
    [Token(Token = "0x40026CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40026CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x40026CF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x40026D0")]
    [FieldOffset(Offset = "0x30")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x40026D1")]
    [FieldOffset(Offset = "0x38")]
    private OrganizationTeam copyTeam;
    [Token(Token = "0x40026D2")]
    [FieldOffset(Offset = "0x40")]
    private Action closeAction;
    [Token(Token = "0x40026D3")]
    [FieldOffset(Offset = "0x48")]
    private bool isTeamEdit;

    [Token(Token = "0x6002EE8")]
    [Address(RVA = "0x3E6A328", Offset = "0x3E6A328", VA = "0x3E6A328")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6002EE9")]
    [Address(RVA = "0x3E6A448", Offset = "0x3E6A448", VA = "0x3E6A448")]
    public void SetData(Action closeAction, bool isTeamEdit)
    {
    }

    [Token(Token = "0x6002EEA")]
    [Address(RVA = "0x3E6A458", Offset = "0x3E6A458", VA = "0x3E6A458")]
    private void OnDecisionButtonAction()
    {
    }

    [Token(Token = "0x6002EEB")]
    [Address(RVA = "0x3E6A4A8", Offset = "0x3E6A4A8", VA = "0x3E6A4A8")]
    public void Open(OrganizationTeam team, OrganizationTeam copyTeam)
    {
    }

    [Token(Token = "0x6002EEC")]
    [Address(RVA = "0x3E6A5BC", Offset = "0x3E6A5BC", VA = "0x3E6A5BC")]
    public void Close(Action closeAction)
    {
    }

    [Token(Token = "0x6002EED")]
    [Address(RVA = "0x3E6A6E4", Offset = "0x3E6A6E4", VA = "0x3E6A6E4")]
    public TeamCopyPopup()
    {
    }
  }
}
