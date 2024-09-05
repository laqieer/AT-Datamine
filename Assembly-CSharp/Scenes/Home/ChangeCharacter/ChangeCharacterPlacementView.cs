// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterPlacementView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B46")]
  public class ChangeCharacterPlacementView : MonoBehaviour
  {
    [Token(Token = "0x400B843")]
    [FieldOffset(Offset = "0x18")]
    private UITimelineController _uiTimelineController;
    [Token(Token = "0x400B844")]
    [FieldOffset(Offset = "0x20")]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x400B845")]
    [FieldOffset(Offset = "0x28")]
    private CanvasGroup _canvasGroup;
    [Token(Token = "0x400B846")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ChangeCharacterPlacementContentsView _contentsView;
    [Token(Token = "0x400B847")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button backButton;
    [Token(Token = "0x400B848")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button confirmButton;

    [Token(Token = "0x6010E86")]
    [Address(RVA = "0x1C3FE24", Offset = "0x1C3FE24", VA = "0x1C3FE24")]
    public IEnumerator InitializeAsync(ChangeCharacterSubScene.CharacterSettings saveData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010E87")]
    [Address(RVA = "0x1C3FEC0", Offset = "0x1C3FEC0", VA = "0x1C3FEC0")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x6010E88")]
    [Address(RVA = "0x1C3FF50", Offset = "0x1C3FF50", VA = "0x1C3FF50")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x6010E89")]
    [Address(RVA = "0x1C3FFE0", Offset = "0x1C3FFE0", VA = "0x1C3FFE0")]
    public void AddEventToOnClickBack(UnityAction action)
    {
    }

    [Token(Token = "0x6010E8A")]
    [Address(RVA = "0x1C40004", Offset = "0x1C40004", VA = "0x1C40004")]
    public void AddEventToOnClickConfirm(UnityAction action)
    {
    }

    [Token(Token = "0x6010E8B")]
    [Address(RVA = "0x1C40028", Offset = "0x1C40028", VA = "0x1C40028")]
    private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

    [Token(Token = "0x6010E8C")]
    [Address(RVA = "0x1C400B8", Offset = "0x1C400B8", VA = "0x1C400B8")]
    public void SetOnClickCharacterChangeEvent(Action<int> action)
    {
    }

    [Token(Token = "0x6010E8D")]
    [Address(RVA = "0x1C400D4", Offset = "0x1C400D4", VA = "0x1C400D4")]
    public void SetOnClickStyleChangeEvent(Action<int> action)
    {
    }

    [Token(Token = "0x6010E8E")]
    [Address(RVA = "0x1C400F0", Offset = "0x1C400F0", VA = "0x1C400F0")]
    public void SetInteractableConfirmButton(bool value)
    {
    }

    [Token(Token = "0x6010E8F")]
    [Address(RVA = "0x1C40110", Offset = "0x1C40110", VA = "0x1C40110")]
    public void SetInteractableCancelButton(bool value)
    {
    }

    [Token(Token = "0x6010E90")]
    [Address(RVA = "0x1C40130", Offset = "0x1C40130", VA = "0x1C40130")]
    public ChangeCharacterPlacementView()
    {
    }
  }
}
