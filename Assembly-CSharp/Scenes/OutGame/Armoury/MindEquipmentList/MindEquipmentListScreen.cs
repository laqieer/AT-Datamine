// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.MindEquipmentList.MindEquipmentListScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.ConsumableMaterialList;
using Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted;
using Scenes.OutGame.Utility;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.MindEquipmentList
{
  [Token(Token = "0x2003852")]
  internal class MindEquipmentListScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400F5DF")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    [Header("Nothing時のオブジェクト")]
    private GameObject nothingText;
    [Token(Token = "0x400F5E0")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("画面上部のボタン類")]
    private CommonToggle badgeFilter;
    [Token(Token = "0x400F5E1")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text toggleOffText;
    [Token(Token = "0x400F5E2")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text toggleOnText;
    [Token(Token = "0x400F5E3")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400F5E4")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton materialListButton;
    [Token(Token = "0x400F5E5")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    [Header("重複一括ボタン")]
    private CommonButton batchConversionButton;
    [Token(Token = "0x400F5E6")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    [Header("スクロールビュー")]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400F5E7")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private float scrollSnapDuration;
    [Token(Token = "0x400F5E8")]
    [FieldOffset(Offset = "0xD8")]
    [Space(10f)]
    [SerializeField]
    private Transform subMenuParent;
    [Token(Token = "0x400F5E9")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400F5EA")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F5EB")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400F5EC")]
    [FieldOffset(Offset = "0xF8")]
    private MindEquipmentListScreen.Param mindEquipmentParam;
    [Token(Token = "0x400F5ED")]
    [FieldOffset(Offset = "0x100")]
    private readonly NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400F5EE")]
    [FieldOffset(Offset = "0x108")]
    private readonly List<IArmouryMindEquipmentThumbResource> mindEquipmentResources;
    [Token(Token = "0x400F5EF")]
    [FieldOffset(Offset = "0x110")]
    private readonly List<MindEquipment> notPossessedMindEquipments;
    [Token(Token = "0x400F5F0")]
    [FieldOffset(Offset = "0x118")]
    private List<MindEquipment> mindEquipments;
    [Token(Token = "0x400F5F1")]
    [FieldOffset(Offset = "0x120")]
    private List<MindEquipment> displayMindEquipments;
    [Token(Token = "0x400F5F2")]
    [FieldOffset(Offset = "0x128")]
    private MaterialListPopupProvider consumableMaterialListPopupProvider;
    [Token(Token = "0x400F5F3")]
    [FieldOffset(Offset = "0x130")]
    private ArmouryMindEquipmentListAssetLoader armouryMindEquipmentListAssetLoader;
    [Token(Token = "0x400F5F4")]
    [FieldOffset(Offset = "0x138")]
    private MindEquipmentListSubMenu subMenu;
    [Token(Token = "0x400F5F5")]
    [FieldOffset(Offset = "0x140")]
    private int thumbSelectIndex;
    [Token(Token = "0x400F5F6")]
    [FieldOffset(Offset = "0x144")]
    private bool favoriteConnecting;

    [Token(Token = "0x6016240")]
    [Address(RVA = "0x20FA534", Offset = "0x20FA534", VA = "0x20FA534", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016241")]
    [Address(RVA = "0x20FAD8C", Offset = "0x20FAD8C", VA = "0x20FAD8C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016242")]
    [Address(RVA = "0x20FAE1C", Offset = "0x20FAE1C", VA = "0x20FAE1C", Slot = "10")]
    public override void OnClickGridButton()
    {
    }

    [Token(Token = "0x6016243")]
    [Address(RVA = "0x20FAE74", Offset = "0x20FAE74", VA = "0x20FAE74", Slot = "7")]
    public override void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016244")]
    [Address(RVA = "0x20FAED4", Offset = "0x20FAED4", VA = "0x20FAED4", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016245")]
    [Address(RVA = "0x20FAEDC", Offset = "0x20FAEDC", VA = "0x20FAEDC", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x6016246")]
    [Address(RVA = "0x20FAF78", Offset = "0x20FAF78", VA = "0x20FAF78", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016247")]
    [Address(RVA = "0x20FABB4", Offset = "0x20FABB4", VA = "0x20FABB4")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6016248")]
    [Address(RVA = "0x20FC66C", Offset = "0x20FC66C", VA = "0x20FC66C")]
    private void RefreshView(bool immediateSnap, int newThumbSelectIndex)
    {
    }

    [Token(Token = "0x6016249")]
    [Address(RVA = "0x20FB09C", Offset = "0x20FB09C", VA = "0x20FB09C")]
    private void CreateList()
    {
    }

    [Token(Token = "0x601624A")]
    [Address(RVA = "0x20FBF50", Offset = "0x20FBF50", VA = "0x20FBF50")]
    private void CreateThumbResources()
    {
    }

    [Token(Token = "0x601624B")]
    [Address(RVA = "0x20FC340", Offset = "0x20FC340", VA = "0x20FC340")]
    private void SetupScrollView()
    {
    }

    [Token(Token = "0x601624C")]
    [Address(RVA = "0x20FAFB0", Offset = "0x20FAFB0", VA = "0x20FAFB0")]
    private (int, string) GetPrevSelectedInfo() => ();

    [Token(Token = "0x601624D")]
    [Address(RVA = "0x20FC8F0", Offset = "0x20FC8F0", VA = "0x20FC8F0")]
    private void ChangeSelectThumb(int index)
    {
    }

    [Token(Token = "0x601624E")]
    [Address(RVA = "0x20FBE74", Offset = "0x20FBE74", VA = "0x20FBE74")]
    private void ChangeSelectThumbNone()
    {
    }

    [Token(Token = "0x601624F")]
    [Address(RVA = "0x20FCBE8", Offset = "0x20FCBE8", VA = "0x20FCBE8")]
    private void CloseHeaderPopups()
    {
    }

    [Token(Token = "0x6016250")]
    [Address(RVA = "0x20FAE90", Offset = "0x20FAE90", VA = "0x20FAE90")]
    private void SetInteractable(bool flag)
    {
    }

    [Token(Token = "0x6016251")]
    [Address(RVA = "0x20FCC24", Offset = "0x20FCC24", VA = "0x20FCC24")]
    private void OnClickThumb(int index)
    {
    }

    [Token(Token = "0x6016252")]
    [Address(RVA = "0x20FAF20", Offset = "0x20FAF20", VA = "0x20FAF20")]
    private void OnCloseSubMenuAndHeaderPopup()
    {
    }

    [Token(Token = "0x6016253")]
    [Address(RVA = "0x20FCFA0", Offset = "0x20FCFA0", VA = "0x20FCFA0")]
    private void OnChangeEnhancedDetail()
    {
    }

    [Token(Token = "0x6016254")]
    [Address(RVA = "0x20FD118", Offset = "0x20FD118", VA = "0x20FD118")]
    private void OnClickMaterialListButton()
    {
    }

    [Token(Token = "0x6016255")]
    [Address(RVA = "0x20FD150", Offset = "0x20FD150", VA = "0x20FD150")]
    private IEnumerator OnClickBatchConversion() => (IEnumerator) null;

    [Token(Token = "0x6016256")]
    [Address(RVA = "0x20FD1E0", Offset = "0x20FD1E0", VA = "0x20FD1E0")]
    private void OnSuccessConversion(ConversionContext result)
    {
    }

    [Token(Token = "0x6016257")]
    [Address(RVA = "0x20FD290", Offset = "0x20FD290", VA = "0x20FD290")]
    private IEnumerator OnClickFilterButton() => (IEnumerator) null;

    [Token(Token = "0x6016258")]
    [Address(RVA = "0x20FD320", Offset = "0x20FD320", VA = "0x20FD320")]
    private void UpdateSortFilterAction(List<Equipment> sortFilterList)
    {
    }

    [Token(Token = "0x6016259")]
    [Address(RVA = "0x20FAB98", Offset = "0x20FAB98", VA = "0x20FAB98")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x601625A")]
    [Address(RVA = "0x20FD44C", Offset = "0x20FD44C", VA = "0x20FD44C")]
    private void OnClickFavorite()
    {
    }

    [Token(Token = "0x601625B")]
    [Address(RVA = "0x20FD578", Offset = "0x20FD578", VA = "0x20FD578")]
    private IEnumerator ConnectAPIFavorite(int index, MindEquipment mindEquipment)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601625C")]
    [Address(RVA = "0x20FD61C", Offset = "0x20FD61C", VA = "0x20FD61C")]
    private void OnClickBadgeFilter(bool state)
    {
    }

    [Token(Token = "0x601625D")]
    [Address(RVA = "0x20FCA6C", Offset = "0x20FCA6C", VA = "0x20FCA6C")]
    private List<MindEquipment> FilteringBadge(List<MindEquipment> list)
    {
      return (List<MindEquipment>) null;
    }

    [Token(Token = "0x601625E")]
    [Address(RVA = "0x20FAA2C", Offset = "0x20FAA2C", VA = "0x20FAA2C")]
    private void CreateScrollSetting()
    {
    }

    [Token(Token = "0x601625F")]
    [Address(RVA = "0x20FAAE8", Offset = "0x20FAAE8", VA = "0x20FAAE8")]
    private void ChangeScrollSetting()
    {
    }

    [Token(Token = "0x6016260")]
    [Address(RVA = "0x20FD620", Offset = "0x20FD620", VA = "0x20FD620")]
    private void Update()
    {
    }

    [Token(Token = "0x6016261")]
    [Address(RVA = "0x20FD63C", Offset = "0x20FD63C", VA = "0x20FD63C")]
    public MindEquipmentListScreen()
    {
    }

    [Token(Token = "0x2003853")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x17004918")]
      public int FilterSelect
      {
        [Token(Token = "0x6016269"), Address(RVA = "0x20FD91C", Offset = "0x20FD91C", VA = "0x20FD91C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x601626A")]
      [Address(RVA = "0x20FAA24", Offset = "0x20FAA24", VA = "0x20FAA24")]
      public Param()
      {
      }
    }
  }
}
