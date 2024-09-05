// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemSortToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034B0")]
  public class PersonalEmblemSortToggle : MonoBehaviour
  {
    [Token(Token = "0x400E544")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x400E545")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PersonalEmblemSortUtility.PersonalEmblemSortCondition condition;
    [Token(Token = "0x400E546")]
    [FieldOffset(Offset = "0x28")]
    private Action<PersonalEmblemSortUtility.PersonalEmblemSortCondition> OnToggleAction;

    [Token(Token = "0x6014AAC")]
    [Address(RVA = "0x1D67490", Offset = "0x1D67490", VA = "0x1D67490")]
    public void Initialized(
      PersonalEmblemSortUtility.PersonalEmblemSortCondition sortCondition,
      Action<PersonalEmblemSortUtility.PersonalEmblemSortCondition> action)
    {
    }

    [Token(Token = "0x6014AAD")]
    [Address(RVA = "0x1D682D0", Offset = "0x1D682D0", VA = "0x1D682D0")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x6014AAE")]
    [Address(RVA = "0x1D67BEC", Offset = "0x1D67BEC", VA = "0x1D67BEC")]
    public void UpdateToggleStatus(
      PersonalEmblemSortUtility.PersonalEmblemSortCondition sortCondition)
    {
    }

    [Token(Token = "0x6014AAF")]
    [Address(RVA = "0x1D682F4", Offset = "0x1D682F4", VA = "0x1D682F4")]
    public PersonalEmblemSortToggle()
    {
    }
  }
}
