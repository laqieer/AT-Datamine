// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2UI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E3D")]
  public class Adv2UI : MonoBehaviour
  {
    [Token(Token = "0x4011160")]
    [FieldOffset(Offset = "0x18")]
    protected Transform hierarchyRoot;
    [Token(Token = "0x4011161")]
    protected const string MessageTagPage = "<p>";
    [Token(Token = "0x4011162")]
    [FieldOffset(Offset = "0x20")]
    protected Adv2UiLinker linker;
    [Token(Token = "0x4011163")]
    [FieldOffset(Offset = "0x28")]
    protected UITweenGroup tweenRoot;
    [Token(Token = "0x4011164")]
    [FieldOffset(Offset = "0x30")]
    protected Adv2Manager.OnProccessSignal playingSignal;
    [Token(Token = "0x4011165")]
    [FieldOffset(Offset = "0x38")]
    protected Adv2Manager.OnProccessSignal inputSignal;
    [Token(Token = "0x4011166")]
    [FieldOffset(Offset = "0x40")]
    protected Dictionary<string, Adv2UI.PlayTween> playingTween;
    [Token(Token = "0x4011167")]
    [FieldOffset(Offset = "0x48")]
    protected bool playingLastActive;
    [Token(Token = "0x4011168")]
    [FieldOffset(Offset = "0x50")]
    protected List<Button> waitingButtons;
    [Token(Token = "0x4011169")]
    [FieldOffset(Offset = "0x58")]
    public string SelectTag;
    [Token(Token = "0x401116A")]
    [FieldOffset(Offset = "0x60")]
    protected Dictionary<string, Dictionary<Adv2UiLinker.LinkMessageParam, List<string>>> playingMessagePage;

    [Token(Token = "0x6019128")]
    [Address(RVA = "0x296F1EC", Offset = "0x296F1EC", VA = "0x296F1EC")]
    private void LocalUpdate()
    {
    }

    [Token(Token = "0x6019129")]
    [Address(RVA = "0x296F7B8", Offset = "0x296F7B8", VA = "0x296F7B8")]
    public void Update()
    {
    }

    [Token(Token = "0x601912A")]
    [Address(RVA = "0x296F7E0", Offset = "0x296F7E0", VA = "0x296F7E0")]
    public void Empty(bool isRemoveObject)
    {
    }

    [Token(Token = "0x601912B")]
    [Address(RVA = "0x296F8A0", Offset = "0x296F8A0", VA = "0x296F8A0")]
    public string GetMessage(string messageTag) => (string) null;

    [Token(Token = "0x601912C")]
    [Address(RVA = "0x296F9B4", Offset = "0x296F9B4", VA = "0x296F9B4")]
    public void SetMessageAll(string partsTag, string messageText)
    {
    }

    [Token(Token = "0x601912D")]
    [Address(RVA = "0x296F9D4", Offset = "0x296F9D4", VA = "0x296F9D4")]
    public void SetMessagePage(string partsTag, string messageText, string inputKey)
    {
    }

    [Token(Token = "0x601912E")]
    [Address(RVA = "0x296FDA8", Offset = "0x296FDA8", VA = "0x296FDA8")]
    public bool IsValidTextTag(string tag) => new bool();

    [Token(Token = "0x601912F")]
    [Address(RVA = "0x296FEA8", Offset = "0x296FEA8", VA = "0x296FEA8")]
    public bool IsOneCharacterProcess(string partsTag) => new bool();

    [Token(Token = "0x6019130")]
    [Address(RVA = "0x2970060", Offset = "0x2970060", VA = "0x2970060")]
    public void DrawMessageAll(string partsTag)
    {
    }

    [Token(Token = "0x6019131")]
    [Address(RVA = "0x29701E8", Offset = "0x29701E8", VA = "0x29701E8")]
    public void SetText(string partsTag, string text)
    {
    }

    [Token(Token = "0x6019132")]
    [Address(RVA = "0x296E1C8", Offset = "0x296E1C8", VA = "0x296E1C8")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6019133")]
    [Address(RVA = "0x2970284", Offset = "0x2970284", VA = "0x2970284")]
    public bool GetActive() => new bool();

    [Token(Token = "0x6019134")]
    [Address(RVA = "0x297033C", Offset = "0x297033C", VA = "0x297033C")]
    public GameObject GetLinkObject(string objectLinkTag) => (GameObject) null;

    [Token(Token = "0x6019135")]
    [Address(RVA = "0x2970354", Offset = "0x2970354", VA = "0x2970354")]
    public Button GetLinkButtonUI(string objectLinkTag) => (Button) null;

    [Token(Token = "0x6019136")]
    [Address(RVA = "0x297036C", Offset = "0x297036C", VA = "0x297036C")]
    public Adv2Manager.OnProccessSignal GetPlayingSignal() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x6019137")]
    [Address(RVA = "0x2970374", Offset = "0x2970374", VA = "0x2970374")]
    private void Play(string tweenGroupID)
    {
    }

    [Token(Token = "0x6019138")]
    [Address(RVA = "0x29705A0", Offset = "0x29705A0", VA = "0x29705A0")]
    public Adv2Manager.OnProccessSignal Play(string tweenGroupID, bool lastActive)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019139")]
    [Address(RVA = "0x2970614", Offset = "0x2970614", VA = "0x2970614")]
    public Adv2Manager.OnProccessSignal Play(bool lastActive, List<string> tweenGroupIDs)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601913A")]
    [Address(RVA = "0x2970798", Offset = "0x2970798", VA = "0x2970798")]
    public void PlayStop()
    {
    }

    [Token(Token = "0x601913B")]
    [Address(RVA = "0x2970800", Offset = "0x2970800", VA = "0x2970800")]
    public void Skip()
    {
    }

    [Token(Token = "0x601913C")]
    [Address(RVA = "0x297081C", Offset = "0x297081C", VA = "0x297081C")]
    public void CancelInput(List<string> keys)
    {
    }

    [Token(Token = "0x601913D")]
    [Address(RVA = "0x2970A34", Offset = "0x2970A34", VA = "0x2970A34")]
    public Adv2Manager.OnProccessSignal Input(Dictionary<Adv2UI, string> buttonList)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601913E")]
    [Address(RVA = "0x2970DC4", Offset = "0x2970DC4", VA = "0x2970DC4")]
    public Adv2Manager.OnProccessSignal Input(List<string> keys, bool isOptionSelect = false)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x601913F")]
    [Address(RVA = "0x2971134", Offset = "0x2971134", VA = "0x2971134")]
    public void SetButtonFunction(string key, UnityAction callbackFunction, bool clear)
    {
    }

    [Token(Token = "0x6019140")]
    [Address(RVA = "0x2971208", Offset = "0x2971208", VA = "0x2971208")]
    public void SetEventFunction(
      string key,
      EventTriggerType eventType,
      EventTrigger.TriggerEvent callbackFunction,
      bool clear)
    {
    }

    [Token(Token = "0x6019141")]
    [Address(RVA = "0x29713FC", Offset = "0x29713FC", VA = "0x29713FC")]
    public void SetButtonColor(string key, Color overColor)
    {
    }

    [Token(Token = "0x6019142")]
    [Address(RVA = "0x297151C", Offset = "0x297151C", VA = "0x297151C")]
    public void SetImageColor(string key, Color overColor)
    {
    }

    [Token(Token = "0x6019143")]
    [Address(RVA = "0x2971618", Offset = "0x2971618", VA = "0x2971618")]
    public void SetButtonEnable(string key, bool active)
    {
    }

    [Token(Token = "0x6019144")]
    [Address(RVA = "0x29716C8", Offset = "0x29716C8", VA = "0x29716C8")]
    public void SetButtonInteractable(string key, bool interactable)
    {
    }

    [Token(Token = "0x6019145")]
    [Address(RVA = "0x2971778", Offset = "0x2971778", VA = "0x2971778")]
    public void SetButtonsInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6019146")]
    [Address(RVA = "0x2971AE8", Offset = "0x2971AE8", VA = "0x2971AE8")]
    public void SetButtonActive(string key, bool active)
    {
    }

    [Token(Token = "0x6019147")]
    [Address(RVA = "0x2971BA4", Offset = "0x2971BA4", VA = "0x2971BA4")]
    public void SetAsLastSibling()
    {
    }

    [Token(Token = "0x6019148")]
    [Address(RVA = "0x2971C6C", Offset = "0x2971C6C", VA = "0x2971C6C")]
    public void SetAsFirstSibling()
    {
    }

    [Token(Token = "0x6019149")]
    [Address(RVA = "0x2971D34", Offset = "0x2971D34", VA = "0x2971D34")]
    public void ChangeParent2dRoot()
    {
    }

    [Token(Token = "0x601914A")]
    [Address(RVA = "0x2971E98", Offset = "0x2971E98", VA = "0x2971E98")]
    public void ChangeParentBack2dRoot()
    {
    }

    [Token(Token = "0x601914B")]
    [Address(RVA = "0x2971FFC", Offset = "0x2971FFC", VA = "0x2971FFC")]
    protected void OnClickButton(string tag, bool isOptionSelect)
    {
    }

    [Token(Token = "0x601914C")]
    [Address(RVA = "0x296E564", Offset = "0x296E564", VA = "0x296E564")]
    public void SetBindObject(GameObject prefab, bool isActive, int siblingIndex)
    {
    }

    [Token(Token = "0x601914D")]
    [Address(RVA = "0x297294C", Offset = "0x297294C", VA = "0x297294C")]
    public GameObject GetBindObject() => (GameObject) null;

    [Token(Token = "0x601914E")]
    [Address(RVA = "0x29729FC", Offset = "0x29729FC", VA = "0x29729FC")]
    public void SetChildObject(Adv2UI top)
    {
    }

    [Token(Token = "0x601914F")]
    [Address(RVA = "0x2972A6C", Offset = "0x2972A6C", VA = "0x2972A6C")]
    public static Adv2UI Create(
      string objectName,
      GameObject addComponent,
      Transform parentHierarchy)
    {
      return (Adv2UI) null;
    }

    [Token(Token = "0x6019150")]
    [Address(RVA = "0x2972AEC", Offset = "0x2972AEC", VA = "0x2972AEC")]
    public static Adv2UI Create(Adv2UI original) => (Adv2UI) null;

    [Token(Token = "0x6019151")]
    [Address(RVA = "0x2972CD8", Offset = "0x2972CD8", VA = "0x2972CD8")]
    public void SetSliderValue(string tweenGroupID, float fromValue, float toValue)
    {
    }

    [Token(Token = "0x6019152")]
    [Address(RVA = "0x2972FC4", Offset = "0x2972FC4", VA = "0x2972FC4")]
    public void SetSliderValues(string tweenGroupID, float[] fromValues, float[] toValues)
    {
    }

    [Token(Token = "0x6019153")]
    [Address(RVA = "0x2973310", Offset = "0x2973310", VA = "0x2973310")]
    public void SetRadarChartLevel(string tweenGroupID, int[] fromLevels, int[] toLevels)
    {
    }

    [Token(Token = "0x6019154")]
    [Address(RVA = "0x29736E4", Offset = "0x29736E4", VA = "0x29736E4")]
    public void SetChaperItemIcon(string key, int itemId, int num)
    {
    }

    [Token(Token = "0x6019155")]
    [Address(RVA = "0x296E2A0", Offset = "0x296E2A0", VA = "0x296E2A0")]
    public Adv2UI()
    {
    }

    [Token(Token = "0x2003E3E")]
    protected struct PlayTween
    {
      [Token(Token = "0x401116B")]
      [FieldOffset(Offset = "0x0")]
      public bool isCheckSignal;
      [Token(Token = "0x401116C")]
      [FieldOffset(Offset = "0x4")]
      public float time;
    }
  }
}
