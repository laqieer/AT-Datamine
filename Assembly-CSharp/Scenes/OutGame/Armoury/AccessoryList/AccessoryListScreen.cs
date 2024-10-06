// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.AccessoryList.AccessoryListScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.ConsumableMaterialList;
using Scenes.OutGame.Utility;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.AccessoryList
{
  [Token(Token = "0x2003892")]
  internal class AccessoryListScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400F761")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    [Header("Nothing時　表示オブジェクト")]
    private GameObject nothingText;
    [Token(Token = "0x400F762")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("画面上部ボタン類")]
    private CommonToggle badgeFilter;
    [Token(Token = "0x400F763")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text toggleOffText;
    [Token(Token = "0x400F764")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text toggleOnText;
    [Token(Token = "0x400F765")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400F766")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton materialListButton;
    [Token(Token = "0x400F767")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    [Header("スクロールビュー")]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400F768")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private float scrollSnapDuration;
    [Token(Token = "0x400F769")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    [Header("サブメニュー")]
    private Transform subMenuParent;
    [Token(Token = "0x400F76A")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    [Space(10f)]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F76B")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400F76C")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400F76D")]
    [FieldOffset(Offset = "0xF0")]
    private AccessoryListScreen.Param accessoryParam;
    [Token(Token = "0x400F76E")]
    [FieldOffset(Offset = "0xF8")]
    private readonly NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400F76F")]
    [FieldOffset(Offset = "0x100")]
    private readonly List<IArmouryAccessoryThumbResource> accessoryResources;
    [Token(Token = "0x400F770")]
    [FieldOffset(Offset = "0x108")]
    private List<Accessory> accessoryList;
    [Token(Token = "0x400F771")]
    [FieldOffset(Offset = "0x110")]
    private AccessoryListSubMenu subMenu;
    [Token(Token = "0x400F772")]
    [FieldOffset(Offset = "0x118")]
    private MaterialListPopupProvider consumableMaterialListPopupProvider;
    [Token(Token = "0x400F773")]
    [FieldOffset(Offset = "0x120")]
    private ArmouryAccessoryListAssetLoader accessoryListAssetLoader;
    [Token(Token = "0x400F774")]
    [FieldOffset(Offset = "0x128")]
    private int thumbSelectIndex;
    [Token(Token = "0x400F775")]
    [FieldOffset(Offset = "0x12C")]
    private bool favoriteConnecting;

    [Token(Token = "0x60163DD")]
    [Address(RVA = "0x1DFC548", Offset = "0x1DFC548", VA = "0x1DFC548", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60163DE")]
    [Address(RVA = "0x1DFCBD4", Offset = "0x1DFCBD4", VA = "0x1DFCBD4", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60163DF")]
    [Address(RVA = "0x1DFCC64", Offset = "0x1DFCC64", VA = "0x1DFCC64", Slot = "7")]
    public override void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60163E0")]
    [Address(RVA = "0x1DFCCC4", Offset = "0x1DFCCC4", VA = "0x1DFCCC4", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60163E1")]
    [Address(RVA = "0x1DFCCCC", Offset = "0x1DFCCCC", VA = "0x1DFCCCC", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x60163E2")]
    [Address(RVA = "0x1DFCE68", Offset = "0x1DFCE68", VA = "0x1DFCE68", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60163E3")]
    [Address(RVA = "0x1DFCA08", Offset = "0x1DFCA08", VA = "0x1DFCA08")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60163E4")]
    [Address(RVA = "0x1DFDA14", Offset = "0x1DFDA14", VA = "0x1DFDA14")]
    private void RefreshView(bool immediateSnap, int newThumbSelectIndex)
    {
    }

    [Token(Token = "0x60163E5")]
    [Address(RVA = "0x1DFCF84", Offset = "0x1DFCF84", VA = "0x1DFCF84")]
    private void CreateList()
    {
    }

    [Token(Token = "0x60163E6")]
    [Address(RVA = "0x1DFD420", Offset = "0x1DFD420", VA = "0x1DFD420")]
    private void CreateResources(int dataCount)
    {
    }

    [Token(Token = "0x60163E7")]
    [Address(RVA = "0x1DFD6F4", Offset = "0x1DFD6F4", VA = "0x1DFD6F4")]
    private void SetupScrollView()
    {
    }

    [Token(Token = "0x60163E8")]
    [Address(RVA = "0x1DFCEA0", Offset = "0x1DFCEA0", VA = "0x1DFCEA0")]
    private (int, string) GetPrevSelectedInfo() => ();

    [Token(Token = "0x60163E9")]
    [Address(RVA = "0x1DFDBB0", Offset = "0x1DFDBB0", VA = "0x1DFDBB0")]
    private void ChangeSelectThumb(int index)
    {
    }

    [Token(Token = "0x60163EA")]
    [Address(RVA = "0x1DFCD14", Offset = "0x1DFCD14", VA = "0x1DFCD14")]
    private void ChangeSelectThumbNone()
    {
    }

    [Token(Token = "0x60163EB")]
    [Address(RVA = "0x1DFCC80", Offset = "0x1DFCC80", VA = "0x1DFCC80")]
    private void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x60163EC")]
    [Address(RVA = "0x1DFE4D0", Offset = "0x1DFE4D0", VA = "0x1DFE4D0")]
    private void OnClickThumb(int index)
    {
    }

    [Token(Token = "0x60163ED")]
    [Address(RVA = "0x1DFCDF0", Offset = "0x1DFCDF0", VA = "0x1DFCDF0")]
    private void OnCloseSubMenuAndHeaderPopup()
    {
    }

    [Token(Token = "0x60163EE")]
    [Address(RVA = "0x1DFE768", Offset = "0x1DFE768", VA = "0x1DFE768")]
    private void CloseHeaderPopups()
    {
    }

    [Token(Token = "0x60163EF")]
    [Address(RVA = "0x1DFE820", Offset = "0x1DFE820", VA = "0x1DFE820")]
    private void OnChangeEnhancedDetail()
    {
    }

    [Token(Token = "0x60163F0")]
    [Address(RVA = "0x1DFE990", Offset = "0x1DFE990", VA = "0x1DFE990")]
    private void OnClickMaterialListButton()
    {
    }

    [Token(Token = "0x60163F1")]
    [Address(RVA = "0x1DFEA2C", Offset = "0x1DFEA2C", VA = "0x1DFEA2C")]
    private IEnumerator OnClickFilterButton() => (IEnumerator) null;

    [Token(Token = "0x60163F2")]
    [Address(RVA = "0x1DFEABC", Offset = "0x1DFEABC", VA = "0x1DFEABC")]
    private void UpdateSortFilterAction(List<Equipment> sortFilterList)
    {
    }

    [Token(Token = "0x60163F3")]
    [Address(RVA = "0x1DFC9EC", Offset = "0x1DFC9EC", VA = "0x1DFC9EC")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x60163F4")]
    [Address(RVA = "0x1DFEECC", Offset = "0x1DFEECC", VA = "0x1DFEECC")]
    private void OnClickFavorite()
    {
    }

    [Token(Token = "0x60163F5")]
    [Address(RVA = "0x1DFEF58", Offset = "0x1DFEF58", VA = "0x1DFEF58")]
    private IEnumerator ConnectAPIFavorite(int index, Accessory accessory) => (IEnumerator) null;

    [Token(Token = "0x60163F6")]
    [Address(RVA = "0x1DFEFFC", Offset = "0x1DFEFFC", VA = "0x1DFEFFC")]
    private void OnClickBadgeFilter(bool state)
    {
    }

    [Token(Token = "0x60163F7")]
    [Address(RVA = "0x1DFE28C", Offset = "0x1DFE28C", VA = "0x1DFE28C")]
    private List<Accessory> FilteringBadge(List<Accessory> accessories) => (List<Accessory>) null;

    [Token(Token = "0x60163F8")]
    [Address(RVA = "0x1DFF000", Offset = "0x1DFF000", VA = "0x1DFF000")]
    private void Update()
    {
    }

    [Token(Token = "0x60163F9")]
    [Address(RVA = "0x1DFF01C", Offset = "0x1DFF01C", VA = "0x1DFF01C")]
    public AccessoryListScreen()
    {
    }

    [Token(Token = "0x2003893")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x1700494E")]
      public int FilterSelect
      {
        [Token(Token = "0x6016400"), Address(RVA = "0x1DFF248", Offset = "0x1DFF248", VA = "0x1DFF248")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6016401")]
      [Address(RVA = "0x1DFC9BC", Offset = "0x1DFC9BC", VA = "0x1DFC9BC")]
      public Param()
      {
      }
    }
  }
}
