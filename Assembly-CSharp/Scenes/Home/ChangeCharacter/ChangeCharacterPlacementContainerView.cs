// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterPlacementContainerView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B44")]
  public class ChangeCharacterPlacementContainerView : MonoBehaviour
  {
    [Token(Token = "0x400B835")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text characterName;
    [Token(Token = "0x400B836")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x400B837")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button styleChangeButton;
    [Token(Token = "0x400B838")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button changeButton;
    [Token(Token = "0x400B839")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ChangeCharacterPlacementStyleThumb _thumb;
    [Token(Token = "0x400B83A")]
    [FieldOffset(Offset = "0x40")]
    private int _index;
    [Token(Token = "0x400B83B")]
    [FieldOffset(Offset = "0x44")]
    private int _styleId;
    [Token(Token = "0x400B83C")]
    [FieldOffset(Offset = "0x48")]
    private Action<int> onClickChangeButton;
    [Token(Token = "0x400B83D")]
    [FieldOffset(Offset = "0x50")]
    private Action<int> onClickStyleChangeButton;

    [Token(Token = "0x6010E7A")]
    [Address(RVA = "0x1C3F8DC", Offset = "0x1C3F8DC", VA = "0x1C3F8DC")]
    public IEnumerator InitializeAsync(int styleId, int index) => (IEnumerator) null;

    [Token(Token = "0x6010E7B")]
    [Address(RVA = "0x1C3F980", Offset = "0x1C3F980", VA = "0x1C3F980")]
    public void OnClickCharacterChange()
    {
    }

    [Token(Token = "0x6010E7C")]
    [Address(RVA = "0x1C3F9A0", Offset = "0x1C3F9A0", VA = "0x1C3F9A0")]
    public void SetOnClickCharacterChangeEvent(Action<int> action)
    {
    }

    [Token(Token = "0x6010E7D")]
    [Address(RVA = "0x1C3F9A8", Offset = "0x1C3F9A8", VA = "0x1C3F9A8")]
    public void OnClickStyleChange()
    {
    }

    [Token(Token = "0x6010E7E")]
    [Address(RVA = "0x1C3F9C8", Offset = "0x1C3F9C8", VA = "0x1C3F9C8")]
    public void SetOnClickStyleChangeEvent(Action<int> action)
    {
    }

    [Token(Token = "0x6010E7F")]
    [Address(RVA = "0x1C3F9D0", Offset = "0x1C3F9D0", VA = "0x1C3F9D0")]
    public ChangeCharacterPlacementContainerView()
    {
    }
  }
}
