// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemFilterToggleGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034A6")]
  public class PersonalEmblemFilterToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x400E50B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggleAll;
    [Token(Token = "0x400E50C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Toggle> toggles;
    [Token(Token = "0x400E50D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PersonalEmblemFilterUtility.PersonalEmblemFilterCondition filterCondition;
    [Token(Token = "0x400E50E")]
    [FieldOffset(Offset = "0x2C")]
    private bool isParentChange;
    [Token(Token = "0x400E50F")]
    [FieldOffset(Offset = "0x2D")]
    private bool isChildrenChange;

    [Token(Token = "0x6014A77")]
    [Address(RVA = "0x1D65B5C", Offset = "0x1D65B5C", VA = "0x1D65B5C")]
    public void Add(Toggle toggle)
    {
    }

    [Token(Token = "0x6014A78")]
    [Address(RVA = "0x1D65C30", Offset = "0x1D65C30", VA = "0x1D65C30")]
    public void Initialized(bool[] flags)
    {
    }

    [Token(Token = "0x6014A79")]
    [Address(RVA = "0x1D65EDC", Offset = "0x1D65EDC", VA = "0x1D65EDC")]
    public void ChangeToggleAll(bool isOn)
    {
    }

    [Token(Token = "0x6014A7A")]
    [Address(RVA = "0x1D65F70", Offset = "0x1D65F70", VA = "0x1D65F70")]
    public void OnValueChangedAllToggle(bool isOn)
    {
    }

    [Token(Token = "0x6014A7B")]
    [Address(RVA = "0x1D66134", Offset = "0x1D66134", VA = "0x1D66134")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x6014A7C")]
    [Address(RVA = "0x1D65D08", Offset = "0x1D65D08", VA = "0x1D65D08")]
    private void CheckAllOnOff()
    {
    }

    [Token(Token = "0x6014A7D")]
    [Address(RVA = "0x1D6615C", Offset = "0x1D6615C", VA = "0x1D6615C")]
    public bool GetIsAllOn() => new bool();

    [Token(Token = "0x6014A7E")]
    [Address(RVA = "0x1D66310", Offset = "0x1D66310", VA = "0x1D66310")]
    public bool[] GetIsOns() => (bool[]) null;

    [Token(Token = "0x6014A7F")]
    [Address(RVA = "0x1D663F0", Offset = "0x1D663F0", VA = "0x1D663F0")]
    public PersonalEmblemFilterUtility.PersonalEmblemFilterCondition GetFilterCondition()
    {
      return new PersonalEmblemFilterUtility.PersonalEmblemFilterCondition();
    }

    [Token(Token = "0x6014A80")]
    [Address(RVA = "0x1D663F8", Offset = "0x1D663F8", VA = "0x1D663F8")]
    public PersonalEmblemFilterToggleGroup()
    {
    }
  }
}
