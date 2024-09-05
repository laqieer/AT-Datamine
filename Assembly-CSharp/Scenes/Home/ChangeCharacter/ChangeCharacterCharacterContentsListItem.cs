// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterCharacterContentsListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B36")]
  public class ChangeCharacterCharacterContentsListItem : MonoBehaviour
  {
    [Token(Token = "0x400B7F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image characterFullImage;
    [Token(Token = "0x400B7F1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image emblemImage;
    [Token(Token = "0x400B7F2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400B7F3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject numRoot;
    [Token(Token = "0x400B7F4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI numText;
    [Token(Token = "0x400B7F5")]
    [FieldOffset(Offset = "0x40")]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x400B7F6")]
    [FieldOffset(Offset = "0x48")]
    private int _characterId;
    [Token(Token = "0x400B7F7")]
    [FieldOffset(Offset = "0x4C")]
    private int _numIndex;
    [Token(Token = "0x400B7F9")]
    [FieldOffset(Offset = "0x58")]
    public Action<int> OnClickButton;
    [Token(Token = "0x400B7FA")]
    [FieldOffset(Offset = "0x60")]
    public Action OnClickUnselect;

    [Token(Token = "0x17003A4B")]
    public int CharacterId
    {
      [Token(Token = "0x6010E2C"), Address(RVA = "0x1C3CD24", Offset = "0x1C3CD24", VA = "0x1C3CD24")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003A4C")]
    public int NumIndex
    {
      [Token(Token = "0x6010E2D"), Address(RVA = "0x1C3CD2C", Offset = "0x1C3CD2C", VA = "0x1C3CD2C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003A4D")]
    public int SelectingIndex
    {
      [Token(Token = "0x6010E2E"), Address(RVA = "0x1C3CD34", Offset = "0x1C3CD34", VA = "0x1C3CD34")] get
      {
        return new int();
      }
      [Token(Token = "0x6010E2F"), Address(RVA = "0x1C3CD3C", Offset = "0x1C3CD3C", VA = "0x1C3CD3C")] private set
      {
      }
    }

    [Token(Token = "0x6010E30")]
    [Address(RVA = "0x1C3CD44", Offset = "0x1C3CD44", VA = "0x1C3CD44")]
    public IEnumerator InitializeAsync(
      int characterId,
      int defaultStyleId,
      int numIndex,
      int selectingIndex)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010E31")]
    [Address(RVA = "0x1C3CDFC", Offset = "0x1C3CDFC", VA = "0x1C3CDFC")]
    public void SetNumIndex(int numIndex)
    {
    }

    [Token(Token = "0x6010E32")]
    [Address(RVA = "0x1C3CE8C", Offset = "0x1C3CE8C", VA = "0x1C3CE8C")]
    private void OnClick()
    {
    }

    [Token(Token = "0x6010E33")]
    [Address(RVA = "0x1C3CEDC", Offset = "0x1C3CEDC", VA = "0x1C3CEDC")]
    public ChangeCharacterCharacterContentsListItem()
    {
    }
  }
}
