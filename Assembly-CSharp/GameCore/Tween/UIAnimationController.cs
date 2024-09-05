// Decompiled with JetBrains decompiler
// Type: GameCore.Tween.UIAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace GameCore.Tween
{
  [Token(Token = "0x2000C22")]
  public class UIAnimationController
  {
    [Token(Token = "0x4003713")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, List<UITweener>> tweenerDictionary;
    [Token(Token = "0x4003714")]
    [FieldOffset(Offset = "0x18")]
    private List<UITweener> currentTwenners;
    [Token(Token = "0x4003716")]
    [FieldOffset(Offset = "0x28")]
    private bool calledPlayBeforeFinishedCallback;

    [Token(Token = "0x140000F4")]
    private event UnityAction finishedCallback
    {
      [Token(Token = "0x6004585"), Address(RVA = "0x35119BC", Offset = "0x35119BC", VA = "0x35119BC")] add
      {
      }
      [Token(Token = "0x6004586"), Address(RVA = "0x3511A58", Offset = "0x3511A58", VA = "0x3511A58")] remove
      {
      }
    }

    [Token(Token = "0x17000A0F")]
    public bool IsPlayingOnceTweens
    {
      [Token(Token = "0x6004587"), Address(RVA = "0x3511AF4", Offset = "0x3511AF4", VA = "0x3511AF4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004588"), Address(RVA = "0x3511AFC", Offset = "0x3511AFC", VA = "0x3511AFC")] private set
      {
      }
    }

    [Token(Token = "0x6004589")]
    private void RegisterComponentsToDictionary<T>(
      ref Dictionary<string, List<T>> dic,
      GameObject root,
      UIAnimationController.GetDictionaryKey method)
      where T : Component
    {
    }

    [Token(Token = "0x600458A")]
    private void RegisterComponentsToDictionary<T>(
      ref Dictionary<string, List<T>> dic,
      T[] components,
      UIAnimationController.GetDictionaryKey method)
      where T : Component
    {
    }

    [Token(Token = "0x600458B")]
    [Address(RVA = "0x3511B08", Offset = "0x3511B08", VA = "0x3511B08")]
    private void RunTweeners(List<UITweener> list, int headIndex, UnityAction<UITweener> method)
    {
    }

    [Token(Token = "0x600458C")]
    [Address(RVA = "0x3511CDC", Offset = "0x3511CDC", VA = "0x3511CDC")]
    private bool CheckTweeners(List<UITweener> list, Func<UITweener, bool> method) => new bool();

    [Token(Token = "0x600458D")]
    [Address(RVA = "0x3511E60", Offset = "0x3511E60", VA = "0x3511E60")]
    public UIAnimationController()
    {
    }

    [Token(Token = "0x600458E")]
    [Address(RVA = "0x3511F24", Offset = "0x3511F24", VA = "0x3511F24")]
    public UIAnimationController(UITweenGroup group)
    {
    }

    [Token(Token = "0x600458F")]
    [Address(RVA = "0x3512084", Offset = "0x3512084", VA = "0x3512084")]
    public UIAnimationController(GameObject target)
    {
    }

    [Token(Token = "0x6004590")]
    [Address(RVA = "0x35121E0", Offset = "0x35121E0", VA = "0x35121E0")]
    public UIAnimationController(GameObject target, string[] groupIDs)
    {
    }

    [Token(Token = "0x6004591")]
    [Address(RVA = "0x3511F4C", Offset = "0x3511F4C", VA = "0x3511F4C")]
    public void InitializeFromTweenGrup(UITweenGroup group)
    {
    }

    [Token(Token = "0x6004592")]
    [Address(RVA = "0x3512328", Offset = "0x3512328", VA = "0x3512328")]
    public void InitializeFromTweenContainer(UITweenContainer container)
    {
    }

    [Token(Token = "0x6004593")]
    [Address(RVA = "0x3512450", Offset = "0x3512450", VA = "0x3512450")]
    public void UnRegisterAnimations()
    {
    }

    [Token(Token = "0x6004594")]
    [Address(RVA = "0x35120AC", Offset = "0x35120AC", VA = "0x35120AC")]
    public bool RegisterAnimations(GameObject target) => new bool();

    [Token(Token = "0x6004595")]
    [Address(RVA = "0x3512210", Offset = "0x3512210", VA = "0x3512210")]
    public bool RegisterAnimations(GameObject target, string[] groupIDs) => new bool();

    [Token(Token = "0x6004596")]
    [Address(RVA = "0x35125DC", Offset = "0x35125DC", VA = "0x35125DC")]
    public bool RegisterAnimations(UITweener[] tweeners) => new bool();

    [Token(Token = "0x6004597")]
    [Address(RVA = "0x3512710", Offset = "0x3512710", VA = "0x3512710")]
    public void ResetBiginning(string groupID)
    {
    }

    [Token(Token = "0x6004598")]
    [Address(RVA = "0x3512830", Offset = "0x3512830", VA = "0x3512830")]
    public void ResetEnding(string groupID)
    {
    }

    [Token(Token = "0x6004599")]
    [Address(RVA = "0x3512950", Offset = "0x3512950", VA = "0x3512950")]
    public void Play(string groupID, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x600459A")]
    [Address(RVA = "0x351296C", Offset = "0x351296C", VA = "0x351296C")]
    private void PlayInternal(string groupID, bool stopCurrent)
    {
    }

    [Token(Token = "0x600459B")]
    [Address(RVA = "0x3512D7C", Offset = "0x3512D7C", VA = "0x3512D7C")]
    public void Play(string groupID, UnityAction callback, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x600459C")]
    [Address(RVA = "0x3512DB4", Offset = "0x3512DB4", VA = "0x3512DB4")]
    public void PlayMultiGroup(string[] groupID, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x600459D")]
    [Address(RVA = "0x3512E38", Offset = "0x3512E38", VA = "0x3512E38")]
    public void PlayMultiGroup(params object[] param)
    {
    }

    [Token(Token = "0x600459E")]
    [Address(RVA = "0x3512BD0", Offset = "0x3512BD0", VA = "0x3512BD0")]
    public void StopCurrentTweeners(bool enable = false)
    {
    }

    [Token(Token = "0x600459F")]
    [Address(RVA = "0x3512EFC", Offset = "0x3512EFC", VA = "0x3512EFC")]
    public void SetEnable(string groupID, bool enable = false)
    {
    }

    [Token(Token = "0x60045A0")]
    [Address(RVA = "0x3513010", Offset = "0x3513010", VA = "0x3513010")]
    public void SkipCurrentTweeners()
    {
    }

    [Token(Token = "0x60045A1")]
    [Address(RVA = "0x35130F8", Offset = "0x35130F8", VA = "0x35130F8")]
    public void UpdateCurrentTweeners()
    {
    }

    [Token(Token = "0x60045A2")]
    [Address(RVA = "0x35131E0", Offset = "0x35131E0", VA = "0x35131E0")]
    public void InitEditorTweeners(bool editMode, float speed)
    {
    }

    [Token(Token = "0x60045A3")]
    [Address(RVA = "0x35132C0", Offset = "0x35132C0", VA = "0x35132C0")]
    public bool IsRunTweeners() => new bool();

    [Token(Token = "0x60045A4")]
    [Address(RVA = "0x3513314", Offset = "0x3513314", VA = "0x3513314")]
    public void Update()
    {
    }

    [Token(Token = "0x60045A5")]
    [Address(RVA = "0x3512AE0", Offset = "0x3512AE0", VA = "0x3512AE0")]
    private bool CheckIsPlayingOnceTweens() => new bool();

    [Token(Token = "0x60045A6")]
    [Address(RVA = "0x351346C", Offset = "0x351346C", VA = "0x351346C")]
    public bool CheckIsPlayingTween(string key) => new bool();

    [Token(Token = "0x60045A7")]
    [Address(RVA = "0x3512DB0", Offset = "0x3512DB0", VA = "0x3512DB0")]
    public void AddFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x60045A8")]
    [Address(RVA = "0x3513534", Offset = "0x3513534", VA = "0x3513534")]
    public void RemoveFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x60045A9")]
    [Address(RVA = "0x3513538", Offset = "0x3513538", VA = "0x3513538")]
    public void ClearFinishedCallback()
    {
    }

    [Token(Token = "0x60045AA")]
    [Address(RVA = "0x3513540", Offset = "0x3513540", VA = "0x3513540")]
    public void Hide()
    {
    }

    [Token(Token = "0x60045AB")]
    [Address(RVA = "0x3512CE0", Offset = "0x3512CE0", VA = "0x3512CE0")]
    private void TryGetTweeners(string groupName, ref List<UITweener> list)
    {
    }

    [Token(Token = "0x2000C23")]
    private delegate string GetDictionaryKey(Component c);
  }
}
