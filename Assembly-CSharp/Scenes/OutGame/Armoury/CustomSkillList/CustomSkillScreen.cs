// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.CustomSkillList.CustomSkillScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.OutGameMenu.ConsumableMaterialList;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.CustomSkillList
{
  [Token(Token = "0x2003886")]
  public class CustomSkillScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400F6F3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400F6F4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400F6F5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Transform battleskillThumbParent;
    [Token(Token = "0x400F6F6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Transform grantThumbParent;
    [Token(Token = "0x400F6F7")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Transform strategyThumbParent;
    [Token(Token = "0x400F6F8")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Transform charaThumbParent;
    [Token(Token = "0x400F6F9")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject srcBattleskillThumbGroup;
    [Token(Token = "0x400F6FA")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject srcGrantThumbGroup;
    [Token(Token = "0x400F6FB")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject srcStrategyThumbGroup;
    [Token(Token = "0x400F6FC")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject srcCharaThumbGroup;
    [Token(Token = "0x400F6FD")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject battleskillNothing;
    [Token(Token = "0x400F6FE")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject grantNothing;
    [Token(Token = "0x400F6FF")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject strategyNothing;
    [Token(Token = "0x400F700")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject charaNothing;
    [Token(Token = "0x400F701")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private RectTransform battleskillBadge;
    [Token(Token = "0x400F702")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private RectTransform grantBadge;
    [Token(Token = "0x400F703")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private RectTransform strategyBadge;
    [Token(Token = "0x400F704")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private RectTransform charaBadge;
    [Token(Token = "0x400F705")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private RectTransform battleskillLabelTransfer;
    [Token(Token = "0x400F706")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private RectTransform grantLabelTransfer;
    [Token(Token = "0x400F707")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private RectTransform strategyLabelTransfer;
    [Token(Token = "0x400F708")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private RectTransform charaLabelTransfer;
    [Token(Token = "0x400F709")]
    public const int BaseEntryMax = 4;
    [Token(Token = "0x400F70A")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400F70B")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private Button materialButton;
    [Token(Token = "0x400F70C")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private Button battleskillButton;
    [Token(Token = "0x400F70D")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Button grantButton;
    [Token(Token = "0x400F70E")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private Button strategyButton;
    [Token(Token = "0x400F70F")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Button charaButton;
    [Token(Token = "0x400F710")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400F711")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private Transform subMenuParent;
    [Token(Token = "0x400F712")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F713")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400F714")]
    [FieldOffset(Offset = "0x190")]
    private Coroutine instantiateCustomSkillThumbCoroutine;
    [Token(Token = "0x400F715")]
    [FieldOffset(Offset = "0x198")]
    private CustomSkillListSubMenu subMenu;
    [Token(Token = "0x400F716")]
    [FieldOffset(Offset = "0x1A0")]
    private CustomSkillScreen.Param customSkillListParam;
    [Token(Token = "0x400F717")]
    [FieldOffset(Offset = "0x1A8")]
    private List<CustomSkillScreen.CustomSkillList> battleSkillList;
    [Token(Token = "0x400F718")]
    [FieldOffset(Offset = "0x1B0")]
    private List<CustomSkillScreen.CustomSkillList> grantList;
    [Token(Token = "0x400F719")]
    [FieldOffset(Offset = "0x1B8")]
    private List<CustomSkillScreen.CustomSkillList> strategyList;
    [Token(Token = "0x400F71A")]
    [FieldOffset(Offset = "0x1C0")]
    private List<CustomSkillScreen.CustomSkillList> charaList;
    [Token(Token = "0x400F71B")]
    [FieldOffset(Offset = "0x1C8")]
    private readonly List<CustomSkillScreen.CustomSkillListKind> kindList;
    [Token(Token = "0x400F71C")]
    [FieldOffset(Offset = "0x1D0")]
    private List<CustomSkillListThumbElement> battleSkillBaseList;
    [Token(Token = "0x400F71D")]
    [FieldOffset(Offset = "0x1D8")]
    private List<CustomSkillListThumbElement> grantBaseList;
    [Token(Token = "0x400F71E")]
    [FieldOffset(Offset = "0x1E0")]
    private List<CustomSkillListThumbElement> strategyBaseList;
    [Token(Token = "0x400F71F")]
    [FieldOffset(Offset = "0x1E8")]
    private List<CustomSkillListThumbElement> charaBaseList;
    [Token(Token = "0x400F720")]
    [FieldOffset(Offset = "0x1F0")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x400F721")]
    [FieldOffset(Offset = "0x1F4")]
    private float jumpMoveLen;
    [Token(Token = "0x400F722")]
    [FieldOffset(Offset = "0x1F8")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x400F723")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x400F724")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x400F725")]
    [FieldOffset(Offset = "0x210")]
    private readonly NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400F726")]
    [FieldOffset(Offset = "0x218")]
    private int selectedSubMenuIndex;
    [Token(Token = "0x400F727")]
    [FieldOffset(Offset = "0x21C")]
    private CustomSkillScreen.CustomSkillListKind selectedSubMenuCustomSkillKind;
    [Token(Token = "0x400F728")]
    [FieldOffset(Offset = "0x220")]
    private MaterialListPopupProvider consumableMaterialListPopupProvider;

    [Token(Token = "0x6016383")]
    [Address(RVA = "0x1DF854C", Offset = "0x1DF854C", VA = "0x1DF854C", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016384")]
    [Address(RVA = "0x1DF8BC0", Offset = "0x1DF8BC0", VA = "0x1DF8BC0")]
    private IEnumerator OnClickSortFilterButton() => (IEnumerator) null;

    [Token(Token = "0x6016385")]
    [Address(RVA = "0x1DF8C50", Offset = "0x1DF8C50", VA = "0x1DF8C50", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016386")]
    [Address(RVA = "0x1DF8CE0", Offset = "0x1DF8CE0", VA = "0x1DF8CE0", Slot = "7")]
    public override void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016387")]
    [Address(RVA = "0x1DF8EA0", Offset = "0x1DF8EA0", VA = "0x1DF8EA0", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016388")]
    [Address(RVA = "0x1DF8EBC", Offset = "0x1DF8EBC", VA = "0x1DF8EBC", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x6016389")]
    [Address(RVA = "0x1DF8F00", Offset = "0x1DF8F00", VA = "0x1DF8F00", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601638A")]
    [Address(RVA = "0x1DF7FA0", Offset = "0x1DF7FA0", VA = "0x1DF7FA0")]
    public void SetInteractable(bool flg)
    {
    }

    [Token(Token = "0x601638B")]
    [Address(RVA = "0x1DF8FEC", Offset = "0x1DF8FEC", VA = "0x1DF8FEC")]
    private List<CustomSkill> SortFilteredPlayerCustomSkills() => (List<CustomSkill>) null;

    [Token(Token = "0x601638C")]
    [Address(RVA = "0x1DF908C", Offset = "0x1DF908C", VA = "0x1DF908C")]
    public void UpdateCustomSkillList(IEnumerable<CustomSkill> customSkills)
    {
    }

    [Token(Token = "0x601638D")]
    [Address(RVA = "0x1DF8CFC", Offset = "0x1DF8CFC", VA = "0x1DF8CFC")]
    private void RefreshView()
    {
    }

    [Token(Token = "0x601638E")]
    [Address(RVA = "0x1DF9150", Offset = "0x1DF9150", VA = "0x1DF9150")]
    private void WithRefreshedThumbIndex(Action listUpdater)
    {
    }

    [Token(Token = "0x601638F")]
    [Address(RVA = "0x1DF976C", Offset = "0x1DF976C", VA = "0x1DF976C")]
    private IEnumerator BackSceneScrollPosition(
      int index,
      CustomSkillScreen.CustomSkillListKind kind)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016390")]
    [Address(RVA = "0x1DF9358", Offset = "0x1DF9358", VA = "0x1DF9358")]
    private void CreateCustomSkillList()
    {
    }

    [Token(Token = "0x6016391")]
    [Address(RVA = "0x1DF9810", Offset = "0x1DF9810", VA = "0x1DF9810")]
    private void CreateCustomSkillList(IEnumerable<CustomSkill> customSkills)
    {
    }

    [Token(Token = "0x6016392")]
    [Address(RVA = "0x1DF9374", Offset = "0x1DF9374", VA = "0x1DF9374")]
    private void UpdateThumbElement(
      int listCount,
      List<CustomSkillListThumbElement> thumbElements,
      Transform thumbParent,
      CustomSkillScreen.CustomSkillListKind customSkillListKind,
      GameObject srcThumbGroup,
      GameObject nothingObj)
    {
    }

    [Token(Token = "0x6016393")]
    [Address(RVA = "0x1DFA1A8", Offset = "0x1DFA1A8", VA = "0x1DFA1A8")]
    private IEnumerator CreateBaseList(
      int listCount,
      List<CustomSkillListThumbElement> baseList,
      Transform thumbParent,
      CustomSkillScreen.CustomSkillListKind customSkillListKind,
      GameObject srcThumbGroup,
      GameObject nothingObj)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016394")]
    [Address(RVA = "0x1DFA27C", Offset = "0x1DFA27C", VA = "0x1DFA27C")]
    private IEnumerator CreateCustomSkillThumbList() => (IEnumerator) null;

    [Token(Token = "0x6016395")]
    [Address(RVA = "0x1DFA184", Offset = "0x1DFA184", VA = "0x1DFA184")]
    private int CalcNumColumnsForCustomSkill(int listCount) => new int();

    [Token(Token = "0x6016396")]
    [Address(RVA = "0x1DFA30C", Offset = "0x1DFA30C", VA = "0x1DFA30C")]
    private void UpdateSortFilterAction(List<CustomSkill> skills)
    {
    }

    [Token(Token = "0x6016397")]
    [Address(RVA = "0x1DF8BA4", Offset = "0x1DF8BA4", VA = "0x1DF8BA4")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x6016398")]
    [Address(RVA = "0x1DF95FC", Offset = "0x1DF95FC", VA = "0x1DF95FC")]
    public CustomSkillScreen.CustomSkillList GetSkillListEntryData(
      int idx,
      CustomSkillScreen.CustomSkillListKind kind)
    {
      return (CustomSkillScreen.CustomSkillList) null;
    }

    [Token(Token = "0x6016399")]
    [Address(RVA = "0x1DF96D4", Offset = "0x1DF96D4", VA = "0x1DF96D4")]
    public int GetSkillListEntryDataCount(CustomSkillScreen.CustomSkillListKind kind) => new int();

    [Token(Token = "0x601639A")]
    [Address(RVA = "0x1DFA330", Offset = "0x1DFA330", VA = "0x1DFA330")]
    public Sprite GetRarityBaseImage(RarityTypeEnum rarity) => (Sprite) null;

    [Token(Token = "0x601639B")]
    [Address(RVA = "0x1DFA40C", Offset = "0x1DFA40C", VA = "0x1DFA40C")]
    public string GetThumbAssetName(int index, CustomSkillScreen.CustomSkillListKind kind)
    {
      return (string) null;
    }

    [Token(Token = "0x601639C")]
    [Address(RVA = "0x1DFA5B0", Offset = "0x1DFA5B0", VA = "0x1DFA5B0")]
    public bool isView(CustomSkillListThumbElement thumb) => new bool();

    [Token(Token = "0x601639D")]
    [Address(RVA = "0x1DFA750", Offset = "0x1DFA750", VA = "0x1DFA750")]
    public void ThumbnailOnClick(int index, CustomSkillScreen.CustomSkillListKind kind)
    {
    }

    [Token(Token = "0x601639E")]
    [Address(RVA = "0x1DFA874", Offset = "0x1DFA874", VA = "0x1DFA874")]
    private void SetSelected(int index, CustomSkillScreen.CustomSkillListKind kind)
    {
    }

    [Token(Token = "0x601639F")]
    [Address(RVA = "0x1DFAB90", Offset = "0x1DFAB90", VA = "0x1DFAB90")]
    private void ChangeSelectThumbNone()
    {
    }

    [Token(Token = "0x60163A0")]
    [Address(RVA = "0x1DFA910", Offset = "0x1DFA910", VA = "0x1DFA910")]
    private void ScrollToThumb(
      int index,
      CustomSkillScreen.CustomSkillListKind kind,
      bool immidiate = false)
    {
    }

    [Token(Token = "0x60163A1")]
    [Address(RVA = "0x1DFAC30", Offset = "0x1DFAC30", VA = "0x1DFAC30")]
    private void OnClickSubMenuAndHeaderPopups()
    {
    }

    [Token(Token = "0x60163A2")]
    [Address(RVA = "0x1DFAC70", Offset = "0x1DFAC70", VA = "0x1DFAC70")]
    public void OnChangeSubMenu(int addValue)
    {
    }

    [Token(Token = "0x60163A3")]
    [Address(RVA = "0x1DFAEB8", Offset = "0x1DFAEB8", VA = "0x1DFAEB8")]
    public void OnMoveEnhanced()
    {
    }

    [Token(Token = "0x60163A4")]
    [Address(RVA = "0x1DFB03C", Offset = "0x1DFB03C", VA = "0x1DFB03C")]
    private void Update()
    {
    }

    [Token(Token = "0x60163A5")]
    [Address(RVA = "0x1DFABD8", Offset = "0x1DFABD8", VA = "0x1DFABD8")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x60163A6")]
    [Address(RVA = "0x1DFB12C", Offset = "0x1DFB12C", VA = "0x1DFB12C")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x60163A7")]
    [Address(RVA = "0x1DFB330", Offset = "0x1DFB330", VA = "0x1DFB330")]
    private void OnCloseSubMenuAndHeaderPopup()
    {
    }

    [Token(Token = "0x60163A8")]
    [Address(RVA = "0x1DFA838", Offset = "0x1DFA838", VA = "0x1DFA838")]
    private void CloseHeaderPopups()
    {
    }

    [Token(Token = "0x60163A9")]
    [Address(RVA = "0x1DFB368", Offset = "0x1DFB368", VA = "0x1DFB368")]
    public CustomSkillScreen()
    {
    }

    [Token(Token = "0x2003887")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x17004943")]
      public int FilterSelect
      {
        [Token(Token = "0x60163B3"), Address(RVA = "0x1DFB760", Offset = "0x1DFB760", VA = "0x1DFB760")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60163B4")]
      [Address(RVA = "0x1DF8B9C", Offset = "0x1DF8B9C", VA = "0x1DF8B9C")]
      public Param()
      {
      }
    }

    [Token(Token = "0x2003888")]
    public class CustomSkillList
    {
      [Token(Token = "0x400F72A")]
      [FieldOffset(Offset = "0x10")]
      public UniqueID uId;
      [Token(Token = "0x400F72B")]
      [FieldOffset(Offset = "0x18")]
      public int Id;
      [Token(Token = "0x400F72C")]
      [FieldOffset(Offset = "0x1C")]
      public SkillTypeEnum SkillType;
      [Token(Token = "0x400F72D")]
      [FieldOffset(Offset = "0x20")]
      public SkillCategoryTypeEnum Category;
      [Token(Token = "0x400F72E")]
      [FieldOffset(Offset = "0x28")]
      public string Name;
      [Token(Token = "0x400F72F")]
      [FieldOffset(Offset = "0x30")]
      public string IconName;
      [Token(Token = "0x400F730")]
      [FieldOffset(Offset = "0x38")]
      public RarityTypeEnum Rarity;
      [Token(Token = "0x400F731")]
      [FieldOffset(Offset = "0x3C")]
      public int Level;
      [Token(Token = "0x400F732")]
      [FieldOffset(Offset = "0x40")]
      public int EnhanceEnergy;
      [Token(Token = "0x400F733")]
      [FieldOffset(Offset = "0x44")]
      public bool Favorite;
      [Token(Token = "0x400F734")]
      [FieldOffset(Offset = "0x45")]
      public bool IsEquipped;
      [Token(Token = "0x400F735")]
      [FieldOffset(Offset = "0x46")]
      public bool IsNew;
      [Token(Token = "0x400F736")]
      [FieldOffset(Offset = "0x47")]
      public bool IsSelected;
      [Token(Token = "0x400F737")]
      [FieldOffset(Offset = "0x48")]
      public int Tag1;
      [Token(Token = "0x400F738")]
      [FieldOffset(Offset = "0x4C")]
      public int Tag2;
      [Token(Token = "0x400F739")]
      [FieldOffset(Offset = "0x50")]
      public CustomSkill StaqData;
      [Token(Token = "0x400F73A")]
      [FieldOffset(Offset = "0x58")]
      public Action<CustomSkillScreen.CustomSkillList> onChange;

      [Token(Token = "0x60163B5")]
      [Address(RVA = "0x1DFA0F0", Offset = "0x1DFA0F0", VA = "0x1DFA0F0")]
      public CustomSkillList()
      {
      }

      [Token(Token = "0x60163B6")]
      [Address(RVA = "0x1DFA0F8", Offset = "0x1DFA0F8", VA = "0x1DFA0F8")]
      public CustomSkillList(CustomSkillScreen.CustomSkillList dat)
      {
      }

      [Token(Token = "0x60163B7")]
      [Address(RVA = "0x1DFAB70", Offset = "0x1DFAB70", VA = "0x1DFAB70")]
      public void OnChange()
      {
      }
    }

    [Token(Token = "0x2003889")]
    public enum CustomSkillListKind
    {
      [Token(Token = "0x400F73C")] BattleSkill,
      [Token(Token = "0x400F73D")] Grant,
      [Token(Token = "0x400F73E")] Strategy,
      [Token(Token = "0x400F73F")] Chara,
    }
  }
}
