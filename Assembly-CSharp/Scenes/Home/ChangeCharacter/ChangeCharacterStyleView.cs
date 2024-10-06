// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterStyleView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B52")]
  public class ChangeCharacterStyleView : MonoBehaviour
  {
    [Token(Token = "0x400B879")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ChangeCharacterStyleContentsView _contentsView;
    [Token(Token = "0x400B87A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button cancelButton;
    [Token(Token = "0x400B87B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button confirmButton;
    [Token(Token = "0x400B87C")]
    [FieldOffset(Offset = "0x30")]
    private UITimelineController _uiTimelineController;
    [Token(Token = "0x400B87D")]
    [FieldOffset(Offset = "0x38")]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x400B87E")]
    [FieldOffset(Offset = "0x40")]
    private CanvasGroup _canvasGroup;
    [Token(Token = "0x400B87F")]
    [FieldOffset(Offset = "0x48")]
    private Action<int> OnClickConfirm;
    [Token(Token = "0x400B880")]
    [FieldOffset(Offset = "0x50")]
    private Action OnClickBack;

    [Token(Token = "0x6010ECE")]
    [Address(RVA = "0x1C41F44", Offset = "0x1C41F44", VA = "0x1C41F44")]
    public IEnumerator InitializeAsync(
      int characterId,
      int equippingStyleId,
      ChangeCharacterSubScene.CharacterSettings saveData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010ECF")]
    [Address(RVA = "0x1C41FF8", Offset = "0x1C41FF8", VA = "0x1C41FF8")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x6010ED0")]
    [Address(RVA = "0x1C42060", Offset = "0x1C42060", VA = "0x1C42060")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x6010ED1")]
    [Address(RVA = "0x1C420C8", Offset = "0x1C420C8", VA = "0x1C420C8")]
    private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

    [Token(Token = "0x6010ED2")]
    [Address(RVA = "0x1C42130", Offset = "0x1C42130", VA = "0x1C42130")]
    public void SetEventOnConfirm(Action<int> action)
    {
    }

    [Token(Token = "0x6010ED3")]
    [Address(RVA = "0x1C42138", Offset = "0x1C42138", VA = "0x1C42138")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x6010ED4")]
    [Address(RVA = "0x1C42170", Offset = "0x1C42170", VA = "0x1C42170")]
    public void SetEventOnBack(Action action)
    {
    }

    [Token(Token = "0x6010ED5")]
    [Address(RVA = "0x1C42178", Offset = "0x1C42178", VA = "0x1C42178")]
    private void OnBack()
    {
    }

    [Token(Token = "0x6010ED6")]
    [Address(RVA = "0x1C42194", Offset = "0x1C42194", VA = "0x1C42194")]
    public ChangeCharacterStyleView()
    {
    }
  }
}
