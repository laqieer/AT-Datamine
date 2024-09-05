// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CharacterListSubMenuView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003737")]
  public class CharacterListSubMenuView : MonoBehaviour
  {
    [Token(Token = "0x400F129")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _characterNameText;
    [Token(Token = "0x400F12A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _supportValueButton;
    [Token(Token = "0x400F12B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton _styleListButton;
    [Token(Token = "0x400F12C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI _styleNumText;
    [Token(Token = "0x400F12D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI _styleTotalText;
    [Token(Token = "0x400F12E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("パララ値")]
    private CharacterListSubMenuViewParara parara;
    [Token(Token = "0x400F12F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("熟練度")]
    private CharacterListSubMenuViewTrainings trainings;
    [Token(Token = "0x400F130")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton _closeButton;
    [Token(Token = "0x400F131")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController _timelineController;

    [Token(Token = "0x6015C0F")]
    [Address(RVA = "0x1B24088", Offset = "0x1B24088", VA = "0x1B24088")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x6015C10")]
    [Address(RVA = "0x1B24724", Offset = "0x1B24724", VA = "0x1B24724")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x6015C11")]
    [Address(RVA = "0x1B24878", Offset = "0x1B24878", VA = "0x1B24878")]
    public void SetCharacterName(string name)
    {
    }

    [Token(Token = "0x6015C12")]
    [Address(RVA = "0x1B2489C", Offset = "0x1B2489C", VA = "0x1B2489C")]
    public void SetParara(Character character)
    {
    }

    [Token(Token = "0x6015C13")]
    [Address(RVA = "0x1B248B4", Offset = "0x1B248B4", VA = "0x1B248B4")]
    public void SetTraining(Character character)
    {
    }

    [Token(Token = "0x6015C14")]
    [Address(RVA = "0x1B249AC", Offset = "0x1B249AC", VA = "0x1B249AC")]
    public IEnumerator InitializeTimeline() => (IEnumerator) null;

    [Token(Token = "0x6015C15")]
    [Address(RVA = "0x1B23F38", Offset = "0x1B23F38", VA = "0x1B23F38")]
    public void SetSupportValueButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015C16")]
    [Address(RVA = "0x1B23F88", Offset = "0x1B23F88", VA = "0x1B23F88")]
    public void SetStyleListButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015C17")]
    [Address(RVA = "0x1B248CC", Offset = "0x1B248CC", VA = "0x1B248CC")]
    public void SetStyleNum(int pass, int total)
    {
    }

    [Token(Token = "0x6015C18")]
    [Address(RVA = "0x1B23FD8", Offset = "0x1B23FD8", VA = "0x1B23FD8")]
    public void SetCloseButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015C19")]
    [Address(RVA = "0x1B250A0", Offset = "0x1B250A0", VA = "0x1B250A0")]
    public void OperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6015C1A")]
    [Address(RVA = "0x1B250FC", Offset = "0x1B250FC", VA = "0x1B250FC")]
    public CharacterListSubMenuView()
    {
    }
  }
}
