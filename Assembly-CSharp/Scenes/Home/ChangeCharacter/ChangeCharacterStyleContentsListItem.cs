// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterStyleContentsListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B4C")]
  public class ChangeCharacterStyleContentsListItem : MonoBehaviour
  {
    [Token(Token = "0x400B856")]
    [FieldOffset(Offset = "0x18")]
    private StyleThumb _styleThumb;
    [Token(Token = "0x400B857")]
    [FieldOffset(Offset = "0x20")]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x400B859")]
    [FieldOffset(Offset = "0x30")]
    private int _styleId;

    [Token(Token = "0x17003A64")]
    public Action<int> OnClick
    {
      [Token(Token = "0x6010EAA"), Address(RVA = "0x1C40670", Offset = "0x1C40670", VA = "0x1C40670")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6010EAB"), Address(RVA = "0x1C40678", Offset = "0x1C40678", VA = "0x1C40678")] set
      {
      }
    }

    [Token(Token = "0x17003A65")]
    public int StyleId
    {
      [Token(Token = "0x6010EAC"), Address(RVA = "0x1C40680", Offset = "0x1C40680", VA = "0x1C40680")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003A66")]
    public bool Equipping
    {
      [Token(Token = "0x6010EAD"), Address(RVA = "0x1C40688", Offset = "0x1C40688", VA = "0x1C40688")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010EAE"), Address(RVA = "0x1C40690", Offset = "0x1C40690", VA = "0x1C40690")] set
      {
      }
    }

    [Token(Token = "0x17003A67")]
    public bool Disabled
    {
      [Token(Token = "0x6010EAF"), Address(RVA = "0x1C4069C", Offset = "0x1C4069C", VA = "0x1C4069C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010EB0"), Address(RVA = "0x1C406A4", Offset = "0x1C406A4", VA = "0x1C406A4")] set
      {
      }
    }

    [Token(Token = "0x6010EB1")]
    [Address(RVA = "0x1C406B0", Offset = "0x1C406B0", VA = "0x1C406B0")]
    public IEnumerator InitializeAsync(
      int styleId,
      bool isEquipping,
      bool duplicate,
      RarityTypeEnum rarityTypeEnum,
      ElementTypeEnum elementTypeEnum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010EB2")]
    [Address(RVA = "0x1C40784", Offset = "0x1C40784", VA = "0x1C40784")]
    public void PlayDisable()
    {
    }

    [Token(Token = "0x6010EB3")]
    [Address(RVA = "0x1C407E4", Offset = "0x1C407E4", VA = "0x1C407E4")]
    public void PlayUnequip()
    {
    }

    [Token(Token = "0x6010EB4")]
    [Address(RVA = "0x1C40840", Offset = "0x1C40840", VA = "0x1C40840")]
    public void PlayEquip()
    {
    }

    [Token(Token = "0x6010EB5")]
    [Address(RVA = "0x1C408A0", Offset = "0x1C408A0", VA = "0x1C408A0")]
    private void OnClickCallback(int _)
    {
    }

    [Token(Token = "0x6010EB6")]
    [Address(RVA = "0x1C408C8", Offset = "0x1C408C8", VA = "0x1C408C8")]
    public ChangeCharacterStyleContentsListItem()
    {
    }
  }
}
