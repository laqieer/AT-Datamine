// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TeamSelectionPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000825")]
  public class TeamSelectionPopup : PopupBase
  {
    [Token(Token = "0x40026BD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x40026BE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x40026BF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x40026C0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TeamSelectionCell teamCellOrign;
    [Token(Token = "0x40026C1")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40026C4")]
    [FieldOffset(Offset = "0xC0")]
    private List<TeamSelectionCell> teamCellList;

    [Token(Token = "0x170006E9")]
    public Action<int> CallbackChange
    {
      [Token(Token = "0x6002ED1"), Address(RVA = "0x3E6929C", Offset = "0x3E6929C", VA = "0x3E6929C")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6002ED2"), Address(RVA = "0x3E692A4", Offset = "0x3E692A4", VA = "0x3E692A4")] set
      {
      }
    }

    [Token(Token = "0x170006EA")]
    public Action CallbackClose
    {
      [Token(Token = "0x6002ED3"), Address(RVA = "0x3E692AC", Offset = "0x3E692AC", VA = "0x3E692AC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6002ED4"), Address(RVA = "0x3E692B4", Offset = "0x3E692B4", VA = "0x3E692B4")] set
      {
      }
    }

    [Token(Token = "0x6002ED5")]
    [Address(RVA = "0x3E692BC", Offset = "0x3E692BC", VA = "0x3E692BC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002ED6")]
    [Address(RVA = "0x3E69414", Offset = "0x3E69414", VA = "0x3E69414")]
    private void OnTeamCell(int teamId)
    {
    }

    [Token(Token = "0x6002ED7")]
    [Address(RVA = "0x3E69430", Offset = "0x3E69430", VA = "0x3E69430")]
    public void SetData(int selectTeamId, OrganizationTeam.TeamSizeType sizeType, Decks decks)
    {
    }

    [Token(Token = "0x6002ED8")]
    [Address(RVA = "0x3E69918", Offset = "0x3E69918", VA = "0x3E69918")]
    private void AllTeamCellOff()
    {
    }

    [Token(Token = "0x6002ED9")]
    [Address(RVA = "0x3E69A60", Offset = "0x3E69A60", VA = "0x3E69A60")]
    private TeamSelectionCell GetCell() => (TeamSelectionCell) null;

    [Token(Token = "0x6002EDA")]
    [Address(RVA = "0x3E69C6C", Offset = "0x3E69C6C", VA = "0x3E69C6C")]
    public TeamSelectionPopup()
    {
    }
  }
}
