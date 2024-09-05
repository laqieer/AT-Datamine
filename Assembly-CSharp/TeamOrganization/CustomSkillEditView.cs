// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007A4")]
  public class CustomSkillEditView : MonoBehaviour
  {
    [Token(Token = "0x4002398")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillEditThumbSetView customSkillEditThumbSetView;
    [Token(Token = "0x4002399")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button prevButton;
    [Token(Token = "0x400239A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button nextButton;
    [Token(Token = "0x400239B")]
    private const string CustomSkillEditAssetBundleName = "ui_page_partylist_customskilledit";
    [Token(Token = "0x400239C")]
    private const string CustomSkillListPopupPrefabName = "Container_Popup_Bottom_Edit_CustomSkill";
    [Token(Token = "0x400239D")]
    [FieldOffset(Offset = "0x30")]
    private int unlockSlotNum;
    [Token(Token = "0x400239E")]
    [FieldOffset(Offset = "0x38")]
    private CustomSkillEditListPopup customSkillEditPrefab;
    [Token(Token = "0x400239F")]
    [FieldOffset(Offset = "0x40")]
    private CustomSkillEditListPopup customSkillEditPopup;
    [Token(Token = "0x40023A0")]
    [FieldOffset(Offset = "0x48")]
    private OrganizationTeam team;
    [Token(Token = "0x40023A1")]
    [FieldOffset(Offset = "0x50")]
    private OrganizationPartySlot slot;
    [Token(Token = "0x40023A2")]
    [FieldOffset(Offset = "0x58")]
    private int selectUnitIndex;
    [Token(Token = "0x40023A3")]
    [FieldOffset(Offset = "0x60")]
    private Action addLoadRequest;
    [Token(Token = "0x40023A4")]
    [FieldOffset(Offset = "0x68")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40023A5")]
    private const int CUSTOMSKILLCATEGORYDATA_ID = 1;
    [Token(Token = "0x40023A6")]
    [FieldOffset(Offset = "0x70")]
    private int selectItemIndex;

    [Token(Token = "0x6002B1D")]
    [Address(RVA = "0x350AFCC", Offset = "0x350AFCC", VA = "0x350AFCC")]
    public void InitCustomSkillEditView(
      OrganizationTeam team,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner,
      int selectUnitIndex)
    {
    }

    [Token(Token = "0x6002B1E")]
    [Address(RVA = "0x350B110", Offset = "0x350B110", VA = "0x350B110")]
    public void InitCustomSkillEditView(
      OrganizationPartySlot slot,
      Action addLoadRequest,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002B1F")]
    [Address(RVA = "0x350B244", Offset = "0x350B244", VA = "0x350B244")]
    public void UpdateView(Action closeAction)
    {
    }

    [Token(Token = "0x6002B20")]
    [Address(RVA = "0x350B65C", Offset = "0x350B65C", VA = "0x350B65C")]
    public void UpdateCustomSkillView()
    {
    }

    [Token(Token = "0x6002B21")]
    [Address(RVA = "0x350BA88", Offset = "0x350BA88", VA = "0x350BA88")]
    public void DestroyPopup()
    {
    }

    [Token(Token = "0x6002B22")]
    [Address(RVA = "0x350B910", Offset = "0x350B910", VA = "0x350B910")]
    private void UpdatePrevNextButton()
    {
    }

    [Token(Token = "0x6002B23")]
    [Address(RVA = "0x350BB30", Offset = "0x350BB30", VA = "0x350BB30")]
    public void OnClickLeftArrow()
    {
    }

    [Token(Token = "0x6002B24")]
    [Address(RVA = "0x350BBAC", Offset = "0x350BBAC", VA = "0x350BBAC")]
    public void OnClickRightArrow()
    {
    }

    [Token(Token = "0x6002B25")]
    [Address(RVA = "0x350B820", Offset = "0x350B820", VA = "0x350B820")]
    private CustomSkill[] GetSlotSetCustomSkills() => (CustomSkill[]) null;

    [Token(Token = "0x6002B26")]
    [Address(RVA = "0x350BC90", Offset = "0x350BC90", VA = "0x350BC90")]
    public void SkillUpdate()
    {
    }

    [Token(Token = "0x6002B27")]
    [Address(RVA = "0x350BB90", Offset = "0x350BB90", VA = "0x350BB90")]
    public void SlotRefresh()
    {
    }

    [Token(Token = "0x6002B28")]
    [Address(RVA = "0x350AEA4", Offset = "0x350AEA4", VA = "0x350AEA4")]
    public void ThumbnailOnClickSelect(int index)
    {
    }

    [Token(Token = "0x6002B29")]
    [Address(RVA = "0x350BCC4", Offset = "0x350BCC4", VA = "0x350BCC4")]
    public void OnPopupThumbChangeButton(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002B2A")]
    [Address(RVA = "0x350C924", Offset = "0x350C924", VA = "0x350C924")]
    public void OnPopupThumbRemoveButton()
    {
    }

    [Token(Token = "0x6002B2B")]
    [Address(RVA = "0x350A59C", Offset = "0x350A59C", VA = "0x350A59C")]
    public List<UniqueID> GetSetUniqueIds() => (List<UniqueID>) null;

    [Token(Token = "0x6002B2C")]
    [Address(RVA = "0x350C9C0", Offset = "0x350C9C0", VA = "0x350C9C0")]
    public CustomSkillEditView()
    {
    }
  }
}
