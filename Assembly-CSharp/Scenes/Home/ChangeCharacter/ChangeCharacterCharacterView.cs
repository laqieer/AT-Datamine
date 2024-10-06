// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterCharacterView
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
  [Token(Token = "0x2002B3C")]
  public class ChangeCharacterCharacterView : MonoBehaviour
  {
    [Token(Token = "0x400B81A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ChangeCharacterCharacterContentsView contentsView;
    [Token(Token = "0x400B81B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button cancelButton;
    [Token(Token = "0x400B81C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button decideButton;
    [Token(Token = "0x400B81D")]
    [FieldOffset(Offset = "0x30")]
    private UITimelineController _uiTimelineController;
    [Token(Token = "0x400B81E")]
    [FieldOffset(Offset = "0x38")]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x400B81F")]
    [FieldOffset(Offset = "0x40")]
    private CanvasGroup _canvasGroup;
    [Token(Token = "0x400B820")]
    [FieldOffset(Offset = "0x48")]
    public Action<ChangeCharacterSubScene.CharacterSettings> OnDecideCharacter;
    [Token(Token = "0x400B821")]
    [FieldOffset(Offset = "0x50")]
    private ChangeCharacterSubScene.CharacterSettings _temporarySaveData;
    [Token(Token = "0x400B822")]
    [FieldOffset(Offset = "0x58")]
    private ChangeCharacterSubScene.CharacterSettings _temporaryOriginalSaveData;

    [Token(Token = "0x6010E4F")]
    [Address(RVA = "0x1C3E928", Offset = "0x1C3E928", VA = "0x1C3E928")]
    public IEnumerator InitializeAsync(
      ChangeCharacterSubScene.CharacterSettings saveData,
      int index)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010E50")]
    [Address(RVA = "0x1C3E9CC", Offset = "0x1C3E9CC", VA = "0x1C3E9CC")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x6010E51")]
    [Address(RVA = "0x1C3EA5C", Offset = "0x1C3EA5C", VA = "0x1C3EA5C")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x6010E52")]
    [Address(RVA = "0x1C3EAEC", Offset = "0x1C3EAEC", VA = "0x1C3EAEC")]
    private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

    [Token(Token = "0x6010E53")]
    [Address(RVA = "0x1C3EB7C", Offset = "0x1C3EB7C", VA = "0x1C3EB7C")]
    public void AddEventToOnClickBack(UnityAction action)
    {
    }

    [Token(Token = "0x6010E54")]
    [Address(RVA = "0x1C3EBE0", Offset = "0x1C3EBE0", VA = "0x1C3EBE0")]
    public void AddEventToOnClickDecide()
    {
    }

    [Token(Token = "0x6010E55")]
    [Address(RVA = "0x1C3ECA0", Offset = "0x1C3ECA0", VA = "0x1C3ECA0")]
    private void OnClickDecideCallback()
    {
    }

    [Token(Token = "0x6010E56")]
    [Address(RVA = "0x1C3ECC0", Offset = "0x1C3ECC0", VA = "0x1C3ECC0")]
    private void SetOnSelectCharacter()
    {
    }

    [Token(Token = "0x6010E57")]
    [Address(RVA = "0x1C3ED44", Offset = "0x1C3ED44", VA = "0x1C3ED44")]
    private void OnChangeCharacter(int characterId, int numIndex)
    {
    }

    [Token(Token = "0x6010E58")]
    [Address(RVA = "0x1C3F188", Offset = "0x1C3F188", VA = "0x1C3F188")]
    private bool GetStyleId(out int styleId, int characterId) => new bool();

    [Token(Token = "0x6010E59")]
    [Address(RVA = "0x1C3F2F8", Offset = "0x1C3F2F8", VA = "0x1C3F2F8")]
    public void SetOnDecideCharacter(
      Action<ChangeCharacterSubScene.CharacterSettings> action)
    {
    }

    [Token(Token = "0x6010E5A")]
    [Address(RVA = "0x1C3F300", Offset = "0x1C3F300", VA = "0x1C3F300")]
    public ChangeCharacterCharacterView()
    {
    }
  }
}
