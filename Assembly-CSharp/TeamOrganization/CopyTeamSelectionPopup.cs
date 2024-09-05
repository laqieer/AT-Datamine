// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CopyTeamSelectionPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
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
  [Token(Token = "0x2000814")]
  public class CopyTeamSelectionPopup : PopupBase
  {
    [Token(Token = "0x400263B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400263C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400263D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400263E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TeamSelectionCell teamCellOrign;
    [Token(Token = "0x400263F")]
    [FieldOffset(Offset = "0xA8")]
    private CopyTeamConfirmationPopup copyTeamConfirmationPrefab;
    [Token(Token = "0x4002640")]
    [FieldOffset(Offset = "0xB0")]
    private CopyTeamConfirmationPopup copyTeamConfirmationPopup;
    [Token(Token = "0x4002643")]
    [FieldOffset(Offset = "0xC8")]
    private List<TeamSelectionCell> teamCellList;
    [Token(Token = "0x4002644")]
    [FieldOffset(Offset = "0xD0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002645")]
    [FieldOffset(Offset = "0xD8")]
    private OrganizationTeam copyTeam;

    [Token(Token = "0x170006E3")]
    public Action<OrganizationTeam, OrganizationTeam> CallbackCopy
    {
      [Token(Token = "0x6002E4F"), Address(RVA = "0x3A92E3C", Offset = "0x3A92E3C", VA = "0x3A92E3C")] get
      {
        return (Action<OrganizationTeam, OrganizationTeam>) null;
      }
      [Token(Token = "0x6002E50"), Address(RVA = "0x3A92E44", Offset = "0x3A92E44", VA = "0x3A92E44")] set
      {
      }
    }

    [Token(Token = "0x170006E4")]
    public Action CallbackClose
    {
      [Token(Token = "0x6002E51"), Address(RVA = "0x3A92E4C", Offset = "0x3A92E4C", VA = "0x3A92E4C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6002E52"), Address(RVA = "0x3A92E54", Offset = "0x3A92E54", VA = "0x3A92E54")] set
      {
      }
    }

    [Token(Token = "0x6002E53")]
    [Address(RVA = "0x3A92E5C", Offset = "0x3A92E5C", VA = "0x3A92E5C")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E54")]
    [Address(RVA = "0x3A92F10", Offset = "0x3A92F10", VA = "0x3A92F10")]
    private void OnTeamCell(int teamId)
    {
    }

    [Token(Token = "0x6002E55")]
    [Address(RVA = "0x3A9326C", Offset = "0x3A9326C", VA = "0x3A9326C")]
    public void SetData(
      OrganizationTeam copyTeam,
      OrganizationTeam.TeamSizeType sizeType,
      Decks decks)
    {
    }

    [Token(Token = "0x6002E56")]
    [Address(RVA = "0x3A93758", Offset = "0x3A93758", VA = "0x3A93758")]
    private void AllTeamCellOff()
    {
    }

    [Token(Token = "0x6002E57")]
    [Address(RVA = "0x3A938A4", Offset = "0x3A938A4", VA = "0x3A938A4")]
    private TeamSelectionCell GetCell() => (TeamSelectionCell) null;

    [Token(Token = "0x6002E58")]
    [Address(RVA = "0x3A93AB0", Offset = "0x3A93AB0", VA = "0x3A93AB0")]
    public CopyTeamSelectionPopup()
    {
    }
  }
}
