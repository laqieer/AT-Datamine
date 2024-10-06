// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Header.HeaderManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.Story.Header
{
  [Token(Token = "0x2002EBE")]
  public class HeaderManager : SingletonMonoBehaviour<HeaderManager>
  {
    [Token(Token = "0x400C86E")]
    private const string TWEEN_KEY_WEATHER_SUNNY = "Weather_Sunny";
    [Token(Token = "0x400C86F")]
    private const string TWEEN_KEY_WEATHER_CLOUDY = "Weather_Cloudy";
    [Token(Token = "0x400C870")]
    private const string TWEEN_KEY_WEATHER_RAINY = "Weather_Rainy";
    [Token(Token = "0x400C871")]
    private const string TWEEN_KEY_WEATHER_SNOWY = "Weather_Snowy";
    [Token(Token = "0x400C872")]
    [FieldOffset(Offset = "0x20")]
    public readonly string WEATHER_ICON_NAME;
    [Token(Token = "0x400C873")]
    [FieldOffset(Offset = "0x28")]
    public readonly string TIMESLOT_NAME;
    [Token(Token = "0x400C874")]
    [FieldOffset(Offset = "0x30")]
    public readonly Dictionary<int, string> WeatherAnimMap;
    [Token(Token = "0x400C875")]
    private const string PREFAB_ASSET_BUNDLE_LABEL = "ui_common_prefabs";
    [Token(Token = "0x400C876")]
    private const string LOAD_MANAGER_NAME = "HeaderContainer";
    [Token(Token = "0x400C877")]
    private const string TIMELIME_AB_LABEL = "ui_page_areaui_timeline";
    [Token(Token = "0x400C878")]
    private const string EFFECT_AB_LABEL = "ui_page_areaui";
    [Token(Token = "0x400C879")]
    [FieldOffset(Offset = "0x38")]
    private List<string> addloadedList;
    [Token(Token = "0x400C87A")]
    [FieldOffset(Offset = "0x40")]
    private HeaderContainer headerContainer;
    [Token(Token = "0x400C87B")]
    [FieldOffset(Offset = "0x48")]
    private bool canAddCallback;

    [Token(Token = "0x17003DF1")]
    public bool IsShow
    {
      [Token(Token = "0x60123F1"), Address(RVA = "0x459A6DC", Offset = "0x459A6DC", VA = "0x459A6DC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003DF2")]
    public RectTransform TrackerParent
    {
      [Token(Token = "0x60123F2"), Address(RVA = "0x459A764", Offset = "0x459A764", VA = "0x459A764")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x60123F3")]
    [Address(RVA = "0x459A788", Offset = "0x459A788", VA = "0x459A788")]
    public void ObservedPlayerPosition(Vector3 position, Quaternion rotation)
    {
    }

    [Token(Token = "0x60123F4")]
    [Address(RVA = "0x459A87C", Offset = "0x459A87C", VA = "0x459A87C")]
    public bool IsAvailable() => new bool();

    [Token(Token = "0x17003DF3")]
    public IAvoidRectTransfromAccessor AvoidRectTransfromAccessor
    {
      [Token(Token = "0x60123F5"), Address(RVA = "0x459A8DC", Offset = "0x459A8DC", VA = "0x459A8DC")] get
      {
        return (IAvoidRectTransfromAccessor) null;
      }
    }

    [Token(Token = "0x60123F6")]
    [Address(RVA = "0x459A8F8", Offset = "0x459A8F8", VA = "0x459A8F8")]
    public IEnumerator InitializeAsync(Transform parent = null) => (IEnumerator) null;

    [Token(Token = "0x60123F7")]
    [Address(RVA = "0x459A988", Offset = "0x459A988", VA = "0x459A988")]
    public void UseHeaderCamera()
    {
    }

    [Token(Token = "0x60123F8")]
    [Address(RVA = "0x459A9A0", Offset = "0x459A9A0", VA = "0x459A9A0")]
    public void UseUIMainCamera()
    {
    }

    [Token(Token = "0x60123F9")]
    [Address(RVA = "0x459A9B8", Offset = "0x459A9B8", VA = "0x459A9B8")]
    private void AddCallBack()
    {
    }

    [Token(Token = "0x60123FA")]
    [Address(RVA = "0x459AA74", Offset = "0x459AA74", VA = "0x459AA74")]
    private void RemoveCallback()
    {
    }

    [Token(Token = "0x60123FB")]
    [Address(RVA = "0x459AB24", Offset = "0x459AB24", VA = "0x459AB24")]
    public void SetDate(int sequenceId = 0)
    {
    }

    [Token(Token = "0x60123FC")]
    [Address(RVA = "0x459ABB8", Offset = "0x459ABB8", VA = "0x459ABB8")]
    public void DateIn()
    {
    }

    [Token(Token = "0x60123FD")]
    [Address(RVA = "0x459AC38", Offset = "0x459AC38", VA = "0x459AC38")]
    public void DateOut()
    {
    }

    [Token(Token = "0x60123FE")]
    [Address(RVA = "0x459ACB8", Offset = "0x459ACB8", VA = "0x459ACB8")]
    public void SetMinimap(int backgroundID, int minimapID, Action callback)
    {
    }

    [Token(Token = "0x60123FF")]
    [Address(RVA = "0x459AD74", Offset = "0x459AD74", VA = "0x459AD74")]
    public bool GetIsPlayToInAnim() => new bool();

    [Token(Token = "0x6012400")]
    [Address(RVA = "0x459ADFC", Offset = "0x459ADFC", VA = "0x459ADFC")]
    public void SetActiveSubButtons(
      bool map,
      bool home,
      bool pocketBook,
      bool globalMenu,
      bool kizunaList)
    {
    }

    [Token(Token = "0x6012401")]
    [Address(RVA = "0x459AEC8", Offset = "0x459AEC8", VA = "0x459AEC8")]
    public void ShowSubButtons()
    {
    }

    [Token(Token = "0x6012402")]
    [Address(RVA = "0x459AF48", Offset = "0x459AF48", VA = "0x459AF48")]
    public void HideSubButtons()
    {
    }

    [Token(Token = "0x6012403")]
    [Address(RVA = "0x459AFC8", Offset = "0x459AFC8", VA = "0x459AFC8")]
    public void InteractEnableSubButtons()
    {
    }

    [Token(Token = "0x6012404")]
    [Address(RVA = "0x459B048", Offset = "0x459B048", VA = "0x459B048")]
    public void InteractDisableSubButtons()
    {
    }

    [Token(Token = "0x6012405")]
    [Address(RVA = "0x459B0C8", Offset = "0x459B0C8", VA = "0x459B0C8")]
    public void ActivatePlaceName()
    {
    }

    [Token(Token = "0x6012406")]
    [Address(RVA = "0x459B14C", Offset = "0x459B14C", VA = "0x459B14C")]
    public void DeactivatePlaceName()
    {
    }

    [Token(Token = "0x6012407")]
    [Address(RVA = "0x4598DAC", Offset = "0x4598DAC", VA = "0x4598DAC")]
    public void PlayToFrameIn()
    {
    }

    [Token(Token = "0x6012408")]
    [Address(RVA = "0x459B1D0", Offset = "0x459B1D0", VA = "0x459B1D0")]
    public void PlayToPlaceIn(string name = "", bool stopCurrent = false)
    {
    }

    [Token(Token = "0x6012409")]
    [Address(RVA = "0x459B26C", Offset = "0x459B26C", VA = "0x459B26C")]
    public void PlayToPlaceIn(int areaId)
    {
    }

    [Token(Token = "0x601240A")]
    [Address(RVA = "0x459B340", Offset = "0x459B340", VA = "0x459B340")]
    public void PlayToFrameOut()
    {
    }

    [Token(Token = "0x601240B")]
    [Address(RVA = "0x459B3C0", Offset = "0x459B3C0", VA = "0x459B3C0")]
    public void PlayToPlaceOut(bool stopCurrent = true)
    {
    }

    [Token(Token = "0x601240C")]
    [Address(RVA = "0x459B454", Offset = "0x459B454", VA = "0x459B454")]
    public void AddAnimationFinishCallback(UnityAction finishAction)
    {
    }

    [Token(Token = "0x601240D")]
    [Address(RVA = "0x459B4E8", Offset = "0x459B4E8", VA = "0x459B4E8")]
    public void RemoveAnimationFinishCallback(UnityAction finishAction)
    {
    }

    [Token(Token = "0x601240E")]
    [Address(RVA = "0x459B57C", Offset = "0x459B57C", VA = "0x459B57C")]
    public void Front()
    {
    }

    [Token(Token = "0x601240F")]
    [Address(RVA = "0x459B598", Offset = "0x459B598", VA = "0x459B598")]
    public void Behaind()
    {
    }

    [Token(Token = "0x6012410")]
    [Address(RVA = "0x459B5B4", Offset = "0x459B5B4", VA = "0x459B5B4")]
    public void SetupTimeElapsed(
      int prevSequenceId,
      int nextSequenceId,
      Action<PlayableDirector> stoppedAction)
    {
    }

    [Token(Token = "0x6012411")]
    [Address(RVA = "0x459B670", Offset = "0x459B670", VA = "0x459B670")]
    public IEnumerator LoadEyeCatchImage(int id) => (IEnumerator) null;

    [Token(Token = "0x6012412")]
    [Address(RVA = "0x459B710", Offset = "0x459B710", VA = "0x459B710")]
    public void ChangeNextTimeSlotAndWeather()
    {
    }

    [Token(Token = "0x6012413")]
    [Address(RVA = "0x459B790", Offset = "0x459B790", VA = "0x459B790")]
    public void PlayTimeElapsed()
    {
    }

    [Token(Token = "0x6012414")]
    [Address(RVA = "0x459B810", Offset = "0x459B810", VA = "0x459B810")]
    public void TimeElapsedClear()
    {
    }

    [Token(Token = "0x6012415")]
    [Address(RVA = "0x459B890", Offset = "0x459B890", VA = "0x459B890")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012416")]
    [Address(RVA = "0x459BAE0", Offset = "0x459BAE0", VA = "0x459BAE0")]
    public void SetCallbackToMinimap(Action minimapAction)
    {
    }

    [Token(Token = "0x6012417")]
    [Address(RVA = "0x459BB74", Offset = "0x459BB74", VA = "0x459BB74")]
    public void SetPocketBookOpenButton(Action action)
    {
    }

    [Token(Token = "0x6012418")]
    [Address(RVA = "0x459BC08", Offset = "0x459BC08", VA = "0x459BC08")]
    public void SetGlobalMenuOpenButton(Action action)
    {
    }

    [Token(Token = "0x6012419")]
    [Address(RVA = "0x459BC9C", Offset = "0x459BC9C", VA = "0x459BC9C")]
    public void SetKizunaListOpenButton(Action action)
    {
    }

    [Token(Token = "0x601241A")]
    [Address(RVA = "0x459BD30", Offset = "0x459BD30", VA = "0x459BD30")]
    public void SetHeaderContainerActive(bool active)
    {
    }

    [Token(Token = "0x601241B")]
    [Address(RVA = "0x459BDD4", Offset = "0x459BDD4", VA = "0x459BDD4")]
    public HeaderManager()
    {
    }
  }
}
