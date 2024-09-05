// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Header.HeaderContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.Story.Date;
using staq.Camera;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.Story.Header
{
  [Token(Token = "0x2002EB7")]
  public class HeaderContainer : MonoBehaviour
  {
    [Token(Token = "0x400C842")]
    private const string TWEEN_KEY_DATE_IN = "Date_In";
    [Token(Token = "0x400C843")]
    private const string TWEEN_KEY_DATE_OUT = "Date_Out";
    [Token(Token = "0x400C844")]
    private const string PREFAB_ASSET_BUNDLE_LABEL = "ui_common_prefabs";
    [Token(Token = "0x400C845")]
    private const string SPRITE_ATLAS_LABEL = "ui_page_areaui_sprite_spriteatlas";
    [Token(Token = "0x400C846")]
    private const string LOAD_OBJECT_NAME = "Container_Header";
    [Token(Token = "0x400C847")]
    private const string LOAD_SPRITE_ATLAS_NAME = "calendar";
    [Token(Token = "0x400C848")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C849")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private OverlayCameraRegister overlayCameraRegister;
    [Token(Token = "0x400C84A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UISafeAreaInsets uISafeArea;
    [Token(Token = "0x400C84B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x400C84C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject parent;
    [Token(Token = "0x400C84D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SpriteAtlas calendarAtlas;
    [Token(Token = "0x400C84E")]
    [FieldOffset(Offset = "0x48")]
    private SpriteAtlas loadCalendarAtlas;
    [Token(Token = "0x400C84F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnityEngine.Camera headerCamera;
    [Token(Token = "0x400C850")]
    [FieldOffset(Offset = "0x58")]
    private bool isPlayToInAnim;
    [Token(Token = "0x400C851")]
    [FieldOffset(Offset = "0x60")]
    private DateItem dateItem;
    [Token(Token = "0x400C852")]
    [FieldOffset(Offset = "0x68")]
    private SummaryItem summaryItem;
    [Token(Token = "0x400C853")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TimeElapsedContainer timeElapsedContainer;
    [Token(Token = "0x400C854")]
    [FieldOffset(Offset = "0x78")]
    private (StoryTimeSlotTypeEnum timeslot, int weather, bool weekday) next;
    [Token(Token = "0x400C855")]
    [FieldOffset(Offset = "0x88")]
    private PlaceItem placeItem;
    [Token(Token = "0x400C856")]
    [FieldOffset(Offset = "0x90")]
    private MinimapItem minimapItem;
    [Token(Token = "0x400C857")]
    [FieldOffset(Offset = "0x98")]
    private HashSet<string> isLoadedAssetBundleMap;

    [Token(Token = "0x17003DE7")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x60123B2"), Address(RVA = "0x45986F8", Offset = "0x45986F8", VA = "0x45986F8")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003DE8")]
    public bool IsShow
    {
      [Token(Token = "0x60123B3"), Address(RVA = "0x4598700", Offset = "0x4598700", VA = "0x4598700")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003DE9")]
    public RectTransform TrackerParent
    {
      [Token(Token = "0x60123B4"), Address(RVA = "0x4598708", Offset = "0x4598708", VA = "0x4598708")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003DEA")]
    public IAvoidRectTransfromAccessor TransformAvoidAccessor
    {
      [Token(Token = "0x60123B5"), Address(RVA = "0x4598724", Offset = "0x4598724", VA = "0x4598724")] get
      {
        return (IAvoidRectTransfromAccessor) null;
      }
      [Token(Token = "0x60123B6"), Address(RVA = "0x459872C", Offset = "0x459872C", VA = "0x459872C")] private set
      {
      }
    }

    [Token(Token = "0x60123B7")]
    [Address(RVA = "0x4598734", Offset = "0x4598734", VA = "0x4598734")]
    public void UseHeaderCamera()
    {
    }

    [Token(Token = "0x60123B8")]
    [Address(RVA = "0x4598758", Offset = "0x4598758", VA = "0x4598758")]
    public void UseUIMainCamera()
    {
    }

    [Token(Token = "0x60123B9")]
    [Address(RVA = "0x4598824", Offset = "0x4598824", VA = "0x4598824")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60123BA")]
    [Address(RVA = "0x45988B4", Offset = "0x45988B4", VA = "0x45988B4")]
    public void SetDate(int sequenceId = 0)
    {
    }

    [Token(Token = "0x60123BB")]
    [Address(RVA = "0x45988F4", Offset = "0x45988F4", VA = "0x45988F4")]
    public void SetMinimap(int backgroundID, int minimapID, Action callback)
    {
    }

    [Token(Token = "0x60123BC")]
    [Address(RVA = "0x4598910", Offset = "0x4598910", VA = "0x4598910")]
    public void SetupTimeElapsed(
      int prevSequenceId,
      int nextSequenceId,
      Action<PlayableDirector> stoppedAction)
    {
    }

    [Token(Token = "0x60123BD")]
    [Address(RVA = "0x4598AF0", Offset = "0x4598AF0", VA = "0x4598AF0")]
    public IEnumerator LoadEyeCatchImage(int id) => (IEnumerator) null;

    [Token(Token = "0x60123BE")]
    [Address(RVA = "0x4598B90", Offset = "0x4598B90", VA = "0x4598B90")]
    public void ChangeCameraStack(HeaderContainer.CameraStackPriority priorityType)
    {
    }

    [Token(Token = "0x60123BF")]
    [Address(RVA = "0x4598C0C", Offset = "0x4598C0C", VA = "0x4598C0C")]
    public void ChangeNextTimeSlotAndWeather()
    {
    }

    [Token(Token = "0x60123C0")]
    [Address(RVA = "0x4598CAC", Offset = "0x4598CAC", VA = "0x4598CAC")]
    public void PlayTimeElapsed()
    {
    }

    [Token(Token = "0x60123C1")]
    [Address(RVA = "0x4598E2C", Offset = "0x4598E2C", VA = "0x4598E2C")]
    public void TimeElapsedClear()
    {
    }

    [Token(Token = "0x60123C2")]
    [Address(RVA = "0x4598F14", Offset = "0x4598F14", VA = "0x4598F14")]
    public bool GetIsPlayToInAnim() => new bool();

    [Token(Token = "0x60123C3")]
    [Address(RVA = "0x4598F1C", Offset = "0x4598F1C", VA = "0x4598F1C")]
    public void SetActiveSubButtons(
      bool map,
      bool home,
      bool pocketBook,
      bool globalMenu,
      bool kizunaList)
    {
    }

    [Token(Token = "0x60123C4")]
    [Address(RVA = "0x4598F80", Offset = "0x4598F80", VA = "0x4598F80")]
    public void ShowSubButtons()
    {
    }

    [Token(Token = "0x60123C5")]
    [Address(RVA = "0x4598FC0", Offset = "0x4598FC0", VA = "0x4598FC0")]
    public void HideSubButtons()
    {
    }

    [Token(Token = "0x60123C6")]
    [Address(RVA = "0x4599000", Offset = "0x4599000", VA = "0x4599000")]
    public void InteractEnableSubButtons()
    {
    }

    [Token(Token = "0x60123C7")]
    [Address(RVA = "0x4599030", Offset = "0x4599030", VA = "0x4599030")]
    public void InteractDisableSubButtons()
    {
    }

    [Token(Token = "0x60123C8")]
    [Address(RVA = "0x4599060", Offset = "0x4599060", VA = "0x4599060")]
    public void SetActivatableSubButton(bool isActive)
    {
    }

    [Token(Token = "0x60123C9")]
    [Address(RVA = "0x4599080", Offset = "0x4599080", VA = "0x4599080")]
    public void SetActivePlaceName(bool isActive)
    {
    }

    [Token(Token = "0x60123CA")]
    [Address(RVA = "0x4599108", Offset = "0x4599108", VA = "0x4599108")]
    public void PlayToFrameIn()
    {
    }

    [Token(Token = "0x60123CB")]
    [Address(RVA = "0x45991B8", Offset = "0x45991B8", VA = "0x45991B8")]
    public void PlayToPlaceIn(string name = "", bool stopCurrent = true)
    {
    }

    [Token(Token = "0x60123CC")]
    [Address(RVA = "0x4599278", Offset = "0x4599278", VA = "0x4599278")]
    public void PlayToFrameOut()
    {
    }

    [Token(Token = "0x60123CD")]
    [Address(RVA = "0x4599338", Offset = "0x4599338", VA = "0x4599338")]
    public void PlayToPlaceOut(bool stopCurrent = true)
    {
    }

    [Token(Token = "0x60123CE")]
    [Address(RVA = "0x45993D0", Offset = "0x45993D0", VA = "0x45993D0")]
    public void AddAnimationFinishCallback(UnityAction finishAction)
    {
    }

    [Token(Token = "0x60123CF")]
    [Address(RVA = "0x4599468", Offset = "0x4599468", VA = "0x4599468")]
    public void RemoveAnimationFinishCallback(UnityAction finishAction)
    {
    }

    [Token(Token = "0x60123D0")]
    [Address(RVA = "0x4599500", Offset = "0x4599500", VA = "0x4599500")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60123D1")]
    [Address(RVA = "0x45995A4", Offset = "0x45995A4", VA = "0x45995A4")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60123D2")]
    [Address(RVA = "0x4599644", Offset = "0x4599644", VA = "0x4599644")]
    public void ObservedPlayerPosition(Vector3 position, Quaternion rotation)
    {
    }

    [Token(Token = "0x60123D3")]
    [Address(RVA = "0x4599660", Offset = "0x4599660", VA = "0x4599660")]
    public void SetCallbackToMinimap(Action minimapAction)
    {
    }

    [Token(Token = "0x60123D4")]
    [Address(RVA = "0x45996F8", Offset = "0x45996F8", VA = "0x45996F8")]
    public void SetPocketBookOpenButton(Action action)
    {
    }

    [Token(Token = "0x60123D5")]
    [Address(RVA = "0x4599790", Offset = "0x4599790", VA = "0x4599790")]
    public void SetGlobalMenuOpenButton(Action action)
    {
    }

    [Token(Token = "0x60123D6")]
    [Address(RVA = "0x4599828", Offset = "0x4599828", VA = "0x4599828")]
    public void SetKizunaListOpenButton(Action action)
    {
    }

    [Token(Token = "0x60123D7")]
    [Address(RVA = "0x45998C0", Offset = "0x45998C0", VA = "0x45998C0")]
    public HeaderContainer()
    {
    }

    [Token(Token = "0x2002EB8")]
    public enum CameraStackPriority
    {
      [Token(Token = "0x400C85A")] Behaind = -1, // 0xFFFFFFFF
      [Token(Token = "0x400C85B")] Front = 1,
    }
  }
}
