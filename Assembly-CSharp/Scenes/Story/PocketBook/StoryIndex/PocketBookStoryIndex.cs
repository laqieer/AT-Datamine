// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.PocketBookStoryIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.AreaEvent;
using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.State;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.AreaEvent;
using Scenes.Story.PocketBook.StoryIndex.Map.UI;
using Scenes.Story.PocketBook.StoryIndex.MapList;
using Scenes.Story.PocketBook.StoryIndex.MapList.UI;
using Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI;
using Scenes.Story.PocketBook.SubQuest;
using Story.Facility;
using Story.KizunaQuest;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex
{
  [Token(Token = "0x2002DD0")]
  public class PocketBookStoryIndex : MonoBehaviour
  {
    [Token(Token = "0x400C4F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C4F4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MapUI mapUI;
    [Token(Token = "0x400C4F5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MapListUI mapListUI;
    [Token(Token = "0x400C4F6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScheduleListUI scheduleListUI;
    [Token(Token = "0x400C4F7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroupStoryIndexMap;
    [Token(Token = "0x400C4F8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton kizunaListButton;
    [Token(Token = "0x400C4F9")]
    [FieldOffset(Offset = "0x48")]
    private bool isInitialized;
    [Token(Token = "0x400C4FA")]
    [FieldOffset(Offset = "0x50")]
    private CurrentFreeActionParam currentFreeactionParam;
    [Token(Token = "0x400C4FB")]
    [FieldOffset(Offset = "0x58")]
    private Scenes.Story.PocketBook.StoryIndex.ActionList.Model actionListModel;
    [Token(Token = "0x400C4FC")]
    [FieldOffset(Offset = "0x60")]
    private MapListModel mapListModel;
    [Token(Token = "0x400C4FD")]
    [FieldOffset(Offset = "0x68")]
    private Scenes.Story.PocketBook.StoryIndex.MapViewer.Model mapViewerModel;
    [Token(Token = "0x400C4FE")]
    [FieldOffset(Offset = "0x70")]
    private Scenes.Story.PocketBook.StoryIndex.ScheduleList.Model scheduleModel;
    [Token(Token = "0x400C4FF")]
    [FieldOffset(Offset = "0x78")]
    private PocketBookStoryIndex.Tab tab;
    [Token(Token = "0x400C500")]
    [FieldOffset(Offset = "0x80")]
    private SpriteAtlas iconAtlas;
    [Token(Token = "0x400C501")]
    [FieldOffset(Offset = "0x88")]
    private SpriteAtlas charaIconAtlas;
    [Token(Token = "0x400C503")]
    [FieldOffset(Offset = "0x98")]
    private KizunaQuestPopupHandler kizunaQuestPopupHandler;
    [Token(Token = "0x400C504")]
    [FieldOffset(Offset = "0xA0")]
    private FacilityInfoPopupHandler facilityInfoPopupHandler;
    [Token(Token = "0x400C506")]
    [FieldOffset(Offset = "0xB0")]
    public Action OnClickKizunaListWithMap;
    [Token(Token = "0x400C507")]
    [FieldOffset(Offset = "0xB8")]
    public Action OnClickKizunaListWithScheduleList;
    [Token(Token = "0x400C508")]
    [FieldOffset(Offset = "0xC0")]
    private bool isKizunaQuestShowPopup;
    [Token(Token = "0x400C509")]
    [FieldOffset(Offset = "0xC1")]
    private bool isSubQuestshowPopup;
    [Token(Token = "0x400C50A")]
    [FieldOffset(Offset = "0xC2")]
    private bool isFacilityShowPopup;
    [Token(Token = "0x400C50B")]
    [FieldOffset(Offset = "0xC3")]
    private bool isAreaEventShowPopup;
    [Token(Token = "0x400C50C")]
    [FieldOffset(Offset = "0xC8")]
    private FreeMapStateManager freeMapStateManager;
    [Token(Token = "0x400C50D")]
    [FieldOffset(Offset = "0xD0")]
    private PocketBookSubQuestPopupHander showPopupSubQuest;
    [Token(Token = "0x400C50E")]
    [FieldOffset(Offset = "0xD8")]
    private PocketBookAreaEventPopupHander areaEventPopupHander;

    [Token(Token = "0x17003D2D")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011EA3"), Address(RVA = "0x3FAC758", Offset = "0x3FAC758", VA = "0x3FAC758")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003D2E")]
    public PocketBookCommonPopupHandler CommonPopupHandler
    {
      [Token(Token = "0x6011EA4"), Address(RVA = "0x3FAC760", Offset = "0x3FAC760", VA = "0x3FAC760")] private get
      {
        return (PocketBookCommonPopupHandler) null;
      }
      [Token(Token = "0x6011EA5"), Address(RVA = "0x3FAC768", Offset = "0x3FAC768", VA = "0x3FAC768")] set
      {
      }
    }

    [Token(Token = "0x1400015B")]
    public event Action<FreeMapUIParamBase> DelegateGoto
    {
      [Token(Token = "0x6011EA6"), Address(RVA = "0x3FAA144", Offset = "0x3FAA144", VA = "0x3FAA144")] add
      {
      }
      [Token(Token = "0x6011EA7"), Address(RVA = "0x3FAC770", Offset = "0x3FAC770", VA = "0x3FAC770")] remove
      {
      }
    }

    [Token(Token = "0x6011EA8")]
    [Address(RVA = "0x3FAC820", Offset = "0x3FAC820", VA = "0x3FAC820")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6011EA9")]
    [Address(RVA = "0x3FA44A8", Offset = "0x3FA44A8", VA = "0x3FA44A8")]
    public IEnumerator Initialize(
      PocketBookLoader loader,
      FreeMapStateManager entity,
      CurrentFreeActionParam currentFreeactionParam)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011EAA")]
    [Address(RVA = "0x3FAC87C", Offset = "0x3FAC87C", VA = "0x3FAC87C")]
    private void MapViewIconHighlight(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6011EAB")]
    [Address(RVA = "0x3FAA018", Offset = "0x3FAA018", VA = "0x3FAA018")]
    public void SetTab(PocketBookStoryIndex.Tab.Type type)
    {
    }

    [Token(Token = "0x6011EAC")]
    [Address(RVA = "0x3FAC9A4", Offset = "0x3FAC9A4", VA = "0x3FAC9A4")]
    private IEnumerator LoadSpriteAtlas(PocketBookLoader loader) => (IEnumerator) null;

    [Token(Token = "0x6011EAD")]
    [Address(RVA = "0x3FACA0C", Offset = "0x3FACA0C", VA = "0x3FACA0C")]
    private IEnumerator InitializeMap(PocketBookLoader loader) => (IEnumerator) null;

    [Token(Token = "0x6011EAE")]
    [Address(RVA = "0x3FACA80", Offset = "0x3FACA80", VA = "0x3FACA80")]
    private IEnumerator InitializeMapList(PocketBookLoader loader) => (IEnumerator) null;

    [Token(Token = "0x6011EAF")]
    [Address(RVA = "0x3FACAE8", Offset = "0x3FACAE8", VA = "0x3FACAE8")]
    private IEnumerator InitializeScheduleList(PocketBookLoader loader) => (IEnumerator) null;

    [Token(Token = "0x6011EB0")]
    [Address(RVA = "0x3FA25A4", Offset = "0x3FA25A4", VA = "0x3FA25A4")]
    public void PageDisplay(PocketBookAnimation player, PocketBookLoader loader)
    {
    }

    [Token(Token = "0x6011EB1")]
    [Address(RVA = "0x3FA2800", Offset = "0x3FA2800", VA = "0x3FA2800")]
    public void PageHide(PocketBookAnimation player, PocketBookLoader loader)
    {
    }

    [Token(Token = "0x6011EB2")]
    [Address(RVA = "0x3FACB5C", Offset = "0x3FACB5C", VA = "0x3FACB5C")]
    private void Update()
    {
    }

    [Token(Token = "0x6011EB3")]
    [Address(RVA = "0x3FACB70", Offset = "0x3FACB70", VA = "0x3FACB70")]
    private void SetTimezone(CurrentFreeActionParam freeActionParam)
    {
    }

    [Token(Token = "0x6011EB4")]
    [Address(RVA = "0x3FACC00", Offset = "0x3FACC00", VA = "0x3FACC00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6011EB5")]
    [Address(RVA = "0x3FACC40", Offset = "0x3FACC40", VA = "0x3FACC40")]
    private void ShowDialog(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6011EB6")]
    [Address(RVA = "0x3FACE4C", Offset = "0x3FACE4C", VA = "0x3FACE4C")]
    private void ShowDialog(FreeMapSubQuestEventUIParam param)
    {
    }

    [Token(Token = "0x6011EB7")]
    [Address(RVA = "0x3FAD000", Offset = "0x3FAD000", VA = "0x3FAD000")]
    private void ShowDialog(FreeMapCommunicationEventUIParam param)
    {
    }

    [Token(Token = "0x6011EB8")]
    [Address(RVA = "0x3FADA38", Offset = "0x3FADA38", VA = "0x3FADA38")]
    private IEnumerator ShowDialogByKizunaQuest(FreeMapCommunicationEventUIParam param)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011EB9")]
    [Address(RVA = "0x3FAD038", Offset = "0x3FAD038", VA = "0x3FAD038")]
    private void ShowDialog(FreeMapFacilityEventUIParam param)
    {
    }

    [Token(Token = "0x6011EBA")]
    [Address(RVA = "0x3FADAB4", Offset = "0x3FADAB4", VA = "0x3FADAB4")]
    private IEnumerator ShowDialogByFacilityInfo(FreeMapFacilityEventUIParam param)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011EBB")]
    [Address(RVA = "0x3FAD508", Offset = "0x3FAD508", VA = "0x3FAD508")]
    private void ShowDialog(FreeMapAreaEventQuestTaskEventUIParam param)
    {
    }

    [Token(Token = "0x6011EBC")]
    [Address(RVA = "0x3FAD2C4", Offset = "0x3FAD2C4", VA = "0x3FAD2C4")]
    private void ShowDialog(FreeMapStoryShopEventUIParam param)
    {
    }

    [Token(Token = "0x6011EBD")]
    [Address(RVA = "0x3FAD688", Offset = "0x3FAD688", VA = "0x3FAD688")]
    private void AutoMoveObliviaeDialog(FreeMapObliviaeEnterUIParam param)
    {
    }

    [Token(Token = "0x6011EBE")]
    [Address(RVA = "0x3FAD85C", Offset = "0x3FAD85C", VA = "0x3FAD85C")]
    private void AutoMoveDialog(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6011EBF")]
    [Address(RVA = "0x3FADB48", Offset = "0x3FADB48", VA = "0x3FADB48")]
    private void ActivateMapList()
    {
    }

    [Token(Token = "0x6011EC0")]
    [Address(RVA = "0x3FADBF0", Offset = "0x3FADBF0", VA = "0x3FADBF0")]
    private void ActivateScheduleList()
    {
    }

    [Token(Token = "0x6011EC1")]
    [Address(RVA = "0x3FADCD0", Offset = "0x3FADCD0", VA = "0x3FADCD0")]
    public void OnToggleMapList(bool value)
    {
    }

    [Token(Token = "0x6011EC2")]
    [Address(RVA = "0x3FADCFC", Offset = "0x3FADCFC", VA = "0x3FADCFC")]
    public void OnToggleScheduleList(bool value)
    {
    }

    [Token(Token = "0x6011EC3")]
    [Address(RVA = "0x3FADD28", Offset = "0x3FADD28", VA = "0x3FADD28")]
    public PocketBookStoryIndex()
    {
    }

    [Token(Token = "0x2002DD1")]
    public class Tab
    {
      [Token(Token = "0x400C511")]
      [FieldOffset(Offset = "0x20")]
      private readonly PocketBookStoryIndex.Tab.MapListTab mapListTab;
      [Token(Token = "0x400C512")]
      [FieldOffset(Offset = "0x28")]
      private readonly PocketBookStoryIndex.Tab.ScheduleListTab scheduleListTab;

      [Token(Token = "0x17003D2F")]
      public bool Activate
      {
        [Token(Token = "0x6011ECD"), Address(RVA = "0x3FAE100", Offset = "0x3FAE100", VA = "0x3FAE100")] get
        {
          return new bool();
        }
        [Token(Token = "0x6011ECE"), Address(RVA = "0x3FAE108", Offset = "0x3FAE108", VA = "0x3FAE108")] set
        {
        }
      }

      [Token(Token = "0x6011ECF")]
      public bool Is<T>() where T : PocketBookStoryIndex.Tab.IType => new bool();

      [Token(Token = "0x17003D30")]
      public PocketBookStoryIndex.Tab.IType Current
      {
        [Token(Token = "0x6011ED0"), Address(RVA = "0x3FAE114", Offset = "0x3FAE114", VA = "0x3FAE114")] get
        {
          return (PocketBookStoryIndex.Tab.IType) null;
        }
        [Token(Token = "0x6011ED1"), Address(RVA = "0x3FAE11C", Offset = "0x3FAE11C", VA = "0x3FAE11C")] private set
        {
        }
      }

      [Token(Token = "0x6011ED2")]
      [Address(RVA = "0x3FAC98C", Offset = "0x3FAC98C", VA = "0x3FAC98C")]
      public void OnMapList()
      {
      }

      [Token(Token = "0x6011ED3")]
      [Address(RVA = "0x3FAC998", Offset = "0x3FAC998", VA = "0x3FAC998")]
      public void OnScheduleList()
      {
      }

      [Token(Token = "0x6011ED4")]
      [Address(RVA = "0x3FADE4C", Offset = "0x3FADE4C", VA = "0x3FADE4C")]
      public Tab()
      {
      }

      [Token(Token = "0x2002DD2")]
      public enum Type
      {
        [Token(Token = "0x400C514")] MapList,
        [Token(Token = "0x400C515")] ScheduleList,
      }

      [Token(Token = "0x2002DD3")]
      public interface IType
      {
        [Token(Token = "0x6011ED5")]
        void Switch(PocketBookStoryIndex index);
      }

      [Token(Token = "0x2002DD4")]
      public class MapListTab : PocketBookStoryIndex.Tab.IType
      {
        [Token(Token = "0x6011ED6")]
        [Address(RVA = "0x3FAE134", Offset = "0x3FAE134", VA = "0x3FAE134", Slot = "4")]
        private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EPocketBookStoryIndex\u002ETab\u002EIType\u002ESwitch(
          PocketBookStoryIndex index)
        {
        }

        [Token(Token = "0x6011ED7")]
        [Address(RVA = "0x3FAE124", Offset = "0x3FAE124", VA = "0x3FAE124")]
        public MapListTab()
        {
        }
      }

      [Token(Token = "0x2002DD5")]
      public class ScheduleListTab : PocketBookStoryIndex.Tab.IType
      {
        [Token(Token = "0x6011ED8")]
        [Address(RVA = "0x3FAE188", Offset = "0x3FAE188", VA = "0x3FAE188", Slot = "4")]
        private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EPocketBookStoryIndex\u002ETab\u002EIType\u002ESwitch(
          PocketBookStoryIndex index)
        {
        }

        [Token(Token = "0x6011ED9")]
        [Address(RVA = "0x3FAE12C", Offset = "0x3FAE12C", VA = "0x3FAE12C")]
        public ScheduleListTab()
        {
        }
      }
    }
  }
}
