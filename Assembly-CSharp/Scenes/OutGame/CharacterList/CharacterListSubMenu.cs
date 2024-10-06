// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CharacterListSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003735")]
  public class CharacterListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F11B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CharacterListSubMenuView _view;
    [Token(Token = "0x400F11C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F11D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F124")]
    [FieldOffset(Offset = "0x60")]
    private Character _character;
    [Token(Token = "0x400F125")]
    [FieldOffset(Offset = "0x68")]
    private bool _isSubMenuDisplay;

    [Token(Token = "0x170047E9")]
    public Action<Character> OnSupportValue
    {
      [Token(Token = "0x6015BF4"), Address(RVA = "0x1B23D24", Offset = "0x1B23D24", VA = "0x1B23D24")] get
      {
        return (Action<Character>) null;
      }
      [Token(Token = "0x6015BF5"), Address(RVA = "0x1B23D2C", Offset = "0x1B23D2C", VA = "0x1B23D2C")] set
      {
      }
    }

    [Token(Token = "0x170047EA")]
    public Action<Character> OnStyleList
    {
      [Token(Token = "0x6015BF6"), Address(RVA = "0x1B23D34", Offset = "0x1B23D34", VA = "0x1B23D34")] get
      {
        return (Action<Character>) null;
      }
      [Token(Token = "0x6015BF7"), Address(RVA = "0x1B23D3C", Offset = "0x1B23D3C", VA = "0x1B23D3C")] set
      {
      }
    }

    [Token(Token = "0x170047EB")]
    public Action<int> OnPageMove
    {
      [Token(Token = "0x6015BF8"), Address(RVA = "0x1B23D44", Offset = "0x1B23D44", VA = "0x1B23D44")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6015BF9"), Address(RVA = "0x1B23D4C", Offset = "0x1B23D4C", VA = "0x1B23D4C")] set
      {
      }
    }

    [Token(Token = "0x170047EC")]
    public Action OnClose
    {
      [Token(Token = "0x6015BFA"), Address(RVA = "0x1B23D54", Offset = "0x1B23D54", VA = "0x1B23D54")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015BFB"), Address(RVA = "0x1B23D5C", Offset = "0x1B23D5C", VA = "0x1B23D5C")] set
      {
      }
    }

    [Token(Token = "0x170047ED")]
    public Action OnOpen
    {
      [Token(Token = "0x6015BFC"), Address(RVA = "0x1B23D64", Offset = "0x1B23D64", VA = "0x1B23D64")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015BFD"), Address(RVA = "0x1B23D6C", Offset = "0x1B23D6C", VA = "0x1B23D6C")] set
      {
      }
    }

    [Token(Token = "0x170047EE")]
    public Action<ArmouryScreenType, ArmouryChangeScreenParam> ChangeScreenAction
    {
      [Token(Token = "0x6015BFE"), Address(RVA = "0x1B23D74", Offset = "0x1B23D74", VA = "0x1B23D74")] get
      {
        return (Action<ArmouryScreenType, ArmouryChangeScreenParam>) null;
      }
      [Token(Token = "0x6015BFF"), Address(RVA = "0x1B23D7C", Offset = "0x1B23D7C", VA = "0x1B23D7C")] set
      {
      }
    }

    [Token(Token = "0x6015C00")]
    [Address(RVA = "0x1B23D84", Offset = "0x1B23D84", VA = "0x1B23D84")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015C01")]
    [Address(RVA = "0x1B24028", Offset = "0x1B24028", VA = "0x1B24028")]
    public void Open(Character character)
    {
    }

    [Token(Token = "0x6015C02")]
    [Address(RVA = "0x1B246DC", Offset = "0x1B246DC", VA = "0x1B246DC")]
    public void Close()
    {
    }

    [Token(Token = "0x6015C03")]
    [Address(RVA = "0x1B23EF8", Offset = "0x1B23EF8", VA = "0x1B23EF8")]
    public void Disable()
    {
    }

    [Token(Token = "0x6015C04")]
    [Address(RVA = "0x1B247A0", Offset = "0x1B247A0", VA = "0x1B247A0")]
    public IEnumerator InitializeTimeline() => (IEnumerator) null;

    [Token(Token = "0x6015C05")]
    [Address(RVA = "0x1B24830", Offset = "0x1B24830", VA = "0x1B24830")]
    private void OnClickSupportValueButton()
    {
    }

    [Token(Token = "0x6015C06")]
    [Address(RVA = "0x1B24854", Offset = "0x1B24854", VA = "0x1B24854")]
    private void OnClickStyleListButton()
    {
    }

    [Token(Token = "0x6015C07")]
    [Address(RVA = "0x1B24104", Offset = "0x1B24104", VA = "0x1B24104")]
    private void SetSubMenu(Character character)
    {
    }

    [Token(Token = "0x6015C08")]
    [Address(RVA = "0x1B24944", Offset = "0x1B24944", VA = "0x1B24944")]
    public CharacterListSubMenu()
    {
    }
  }
}
