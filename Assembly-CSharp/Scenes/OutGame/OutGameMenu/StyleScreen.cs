// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Armoury;
using Scenes.OutGame.MasterBonus;
using Scenes.OutGame.OutGameMenu.ConsumableMaterialList;
using Scenes.OutGame.Utility;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AD9")]
  public class StyleScreen : ArmouryScreenBase
  {
    [Token(Token = "0x401031F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x4010320")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject nothing;
    [Token(Token = "0x4010321")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonToggle badgeFilter;
    [Token(Token = "0x4010322")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text toggleOffText;
    [Token(Token = "0x4010323")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text toggleOnText;
    [Token(Token = "0x4010324")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x4010325")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button masterBonusButton;
    [Token(Token = "0x4010326")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Button materialListButton;
    [Token(Token = "0x4010327")]
    [FieldOffset(Offset = "0xD0")]
    private List<Style> possessionList;
    [Token(Token = "0x4010328")]
    [FieldOffset(Offset = "0xD8")]
    private List<Style> notPossessionList;
    [Token(Token = "0x4010329")]
    [FieldOffset(Offset = "0xE0")]
    private List<Style> styleList;
    [Token(Token = "0x401032A")]
    [FieldOffset(Offset = "0xE8")]
    private List<StyleThumbResource> styleResources;
    [Token(Token = "0x401032B")]
    [FieldOffset(Offset = "0xF0")]
    private MaterialListPopupProvider consumableMaterialListPopupProvider;
    [Token(Token = "0x401032C")]
    [FieldOffset(Offset = "0xF8")]
    private MasterBonusProvider masterBonusProvider;
    [Token(Token = "0x401032D")]
    [FieldOffset(Offset = "0x100")]
    private ContainerElementMasterBonusGenerator elementMasterBonusListGenerator;
    [Token(Token = "0x401032E")]
    [FieldOffset(Offset = "0x108")]
    private MasterBonusPopupGenerator masterBonusPopupGenerator;
    [Token(Token = "0x401032F")]
    [FieldOffset(Offset = "0x110")]
    private MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator;
    [Token(Token = "0x4010330")]
    [FieldOffset(Offset = "0x118")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x4010331")]
    [FieldOffset(Offset = "0x120")]
    private StyleScreen.Param styleListParam;

    [Token(Token = "0x6017263")]
    [Address(RVA = "0x300DBD8", Offset = "0x300DBD8", VA = "0x300DBD8", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6017264")]
    [Address(RVA = "0x300E320", Offset = "0x300E320", VA = "0x300E320", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6017265")]
    [Address(RVA = "0x300E3B0", Offset = "0x300E3B0", VA = "0x300E3B0", Slot = "7")]
    public override void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6017266")]
    [Address(RVA = "0x300E3C4", Offset = "0x300E3C4", VA = "0x300E3C4", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6017267")]
    [Address(RVA = "0x300E48C", Offset = "0x300E48C", VA = "0x300E48C", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x6017268")]
    [Address(RVA = "0x300E4AC", Offset = "0x300E4AC", VA = "0x300E4AC", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6017269")]
    [Address(RVA = "0x300E4DC", Offset = "0x300E4DC", VA = "0x300E4DC", Slot = "10")]
    public override void OnClickGridButton()
    {
    }

    [Token(Token = "0x601726A")]
    [Address(RVA = "0x300E538", Offset = "0x300E538", VA = "0x300E538")]
    private void OnSortFilterButton()
    {
    }

    [Token(Token = "0x601726B")]
    [Address(RVA = "0x300E240", Offset = "0x300E240", VA = "0x300E240")]
    private void UpdateStyleList()
    {
    }

    [Token(Token = "0x601726C")]
    [Address(RVA = "0x300E5D0", Offset = "0x300E5D0", VA = "0x300E5D0")]
    private void CreateStyleList()
    {
    }

    [Token(Token = "0x601726D")]
    [Address(RVA = "0x300EFD4", Offset = "0x300EFD4", VA = "0x300EFD4")]
    private void UpdateSortFilterAction(List<Style> sortFilterList)
    {
    }

    [Token(Token = "0x601726E")]
    [Address(RVA = "0x300E304", Offset = "0x300E304", VA = "0x300E304")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x601726F")]
    [Address(RVA = "0x300F000", Offset = "0x300F000", VA = "0x300F000")]
    private void CreateStyleList(List<Style> sortFilterList)
    {
    }

    [Token(Token = "0x6017270")]
    [Address(RVA = "0x300EACC", Offset = "0x300EACC", VA = "0x300EACC")]
    private void SetStyleList()
    {
    }

    [Token(Token = "0x6017271")]
    [Address(RVA = "0x300F390", Offset = "0x300F390", VA = "0x300F390")]
    private void Reset()
    {
    }

    [Token(Token = "0x6017272")]
    [Address(RVA = "0x300F48C", Offset = "0x300F48C", VA = "0x300F48C")]
    private void ThumbnailOnClick(StyleThumbResource resource)
    {
    }

    [Token(Token = "0x6017273")]
    [Address(RVA = "0x300F510", Offset = "0x300F510", VA = "0x300F510")]
    private void ChangeSubSceneStyleStatus(StyleThumbResource resource)
    {
    }

    [Token(Token = "0x6017274")]
    [Address(RVA = "0x300E4A8", Offset = "0x300E4A8", VA = "0x300E4A8")]
    private void CloseHeaderPopups(bool consumableMaterial = true, bool masterBonus = true)
    {
    }

    [Token(Token = "0x6017275")]
    [Address(RVA = "0x300F914", Offset = "0x300F914", VA = "0x300F914")]
    private void OnClickBadgeFilter(bool state)
    {
    }

    [Token(Token = "0x6017276")]
    [Address(RVA = "0x300EDDC", Offset = "0x300EDDC", VA = "0x300EDDC")]
    private List<Style> FilteringBadge(List<Style> list) => (List<Style>) null;

    [Token(Token = "0x6017277")]
    [Address(RVA = "0x300E098", Offset = "0x300E098", VA = "0x300E098")]
    private void CreateScrollSetting()
    {
    }

    [Token(Token = "0x6017278")]
    [Address(RVA = "0x300E164", Offset = "0x300E164", VA = "0x300E164")]
    private void ChangeScrollSetting()
    {
    }

    [Token(Token = "0x6017279")]
    [Address(RVA = "0x300F918", Offset = "0x300F918", VA = "0x300F918")]
    public StyleScreen()
    {
    }

    [Token(Token = "0x2003ADA")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x4010332")]
      [FieldOffset(Offset = "0x10")]
      public int CharacterId;

      [Token(Token = "0x601727F")]
      [Address(RVA = "0x300E218", Offset = "0x300E218", VA = "0x300E218")]
      public Param(int charaId = 0)
      {
      }
    }
  }
}
