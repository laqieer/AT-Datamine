// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CopyTeamConfirmationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000813")]
  public class CopyTeamConfirmationPopup : PopupBase
  {
    [Token(Token = "0x4002634")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4002635")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x4002636")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CopyTeamCell copyTeamCell;
    [Token(Token = "0x4002637")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CopyTeamCell baseTeamCell;
    [Token(Token = "0x4002639")]
    [FieldOffset(Offset = "0xB0")]
    private OrganizationTeam baseTeam;
    [Token(Token = "0x400263A")]
    [FieldOffset(Offset = "0xB8")]
    private OrganizationTeam copyTeam;

    [Token(Token = "0x170006E2")]
    public Action<OrganizationTeam, OrganizationTeam> CallbackCopy
    {
      [Token(Token = "0x6002E48"), Address(RVA = "0x3A92BDC", Offset = "0x3A92BDC", VA = "0x3A92BDC")] get
      {
        return (Action<OrganizationTeam, OrganizationTeam>) null;
      }
      [Token(Token = "0x6002E49"), Address(RVA = "0x3A92BE4", Offset = "0x3A92BE4", VA = "0x3A92BE4")] set
      {
      }
    }

    [Token(Token = "0x6002E4A")]
    [Address(RVA = "0x3A92BEC", Offset = "0x3A92BEC", VA = "0x3A92BEC")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E4B")]
    [Address(RVA = "0x3A92CC0", Offset = "0x3A92CC0", VA = "0x3A92CC0")]
    public void SetData(OrganizationTeam baseTeam, OrganizationTeam copyTeam)
    {
    }

    [Token(Token = "0x6002E4C")]
    [Address(RVA = "0x3A92E08", Offset = "0x3A92E08", VA = "0x3A92E08")]
    public void OnPositiveButton()
    {
    }

    [Token(Token = "0x6002E4D")]
    [Address(RVA = "0x3A92E28", Offset = "0x3A92E28", VA = "0x3A92E28")]
    public CopyTeamConfirmationPopup()
    {
    }
  }
}
