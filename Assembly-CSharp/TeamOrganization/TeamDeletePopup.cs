// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TeamDeletePopup
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
  [Token(Token = "0x2000829")]
  public class TeamDeletePopup : MonoBehaviour
  {
    [Token(Token = "0x40026D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x40026D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x40026D9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x40026DA")]
    [FieldOffset(Offset = "0x30")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x40026DB")]
    [FieldOffset(Offset = "0x38")]
    private Action closeAction;
    [Token(Token = "0x40026DC")]
    [FieldOffset(Offset = "0x40")]
    private bool isTeamEdit;

    [Token(Token = "0x6002EF4")]
    [Address(RVA = "0x3E6A910", Offset = "0x3E6A910", VA = "0x3E6A910")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6002EF5")]
    [Address(RVA = "0x3E6AA30", Offset = "0x3E6AA30", VA = "0x3E6AA30")]
    public void SetData(Action closeAction, bool isTeamEdit)
    {
    }

    [Token(Token = "0x6002EF6")]
    [Address(RVA = "0x3E6AA40", Offset = "0x3E6AA40", VA = "0x3E6AA40")]
    private void OnDecisionButtonAction()
    {
    }

    [Token(Token = "0x6002EF7")]
    [Address(RVA = "0x3E6AA44", Offset = "0x3E6AA44", VA = "0x3E6AA44")]
    public void Open(OrganizationTeam team)
    {
    }

    [Token(Token = "0x6002EF8")]
    [Address(RVA = "0x3E6AB4C", Offset = "0x3E6AB4C", VA = "0x3E6AB4C")]
    public void Close(Action closeAction)
    {
    }

    [Token(Token = "0x6002EF9")]
    [Address(RVA = "0x3E6AC74", Offset = "0x3E6AC74", VA = "0x3E6AC74")]
    public TeamDeletePopup()
    {
    }
  }
}
