// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemToggleGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034B1")]
  public class PersonalEmblemToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x400E547")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggleAll;
    [Token(Token = "0x400E548")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle[] toggles;
    [Token(Token = "0x400E549")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PersonalEmblemFilterUtility.PersonalEmblemFilterCondition filterCondition;
    [Token(Token = "0x400E54A")]
    [FieldOffset(Offset = "0x2C")]
    private bool isParentChange;
    [Token(Token = "0x400E54B")]
    [FieldOffset(Offset = "0x2D")]
    private bool isChildrenChange;

    [Token(Token = "0x6014AB0")]
    [Address(RVA = "0x1D682FC", Offset = "0x1D682FC", VA = "0x1D682FC")]
    public void Initialized(bool[] flags)
    {
    }

    [Token(Token = "0x6014AB1")]
    [Address(RVA = "0x1D684A8", Offset = "0x1D684A8", VA = "0x1D684A8")]
    public void ChangeToggleAll(bool isOn)
    {
    }

    [Token(Token = "0x6014AB2")]
    [Address(RVA = "0x1D6853C", Offset = "0x1D6853C", VA = "0x1D6853C")]
    public void OnValueChangedAllToggle(bool isOn)
    {
    }

    [Token(Token = "0x6014AB3")]
    [Address(RVA = "0x1D6862C", Offset = "0x1D6862C", VA = "0x1D6862C")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x6014AB4")]
    [Address(RVA = "0x1D683A4", Offset = "0x1D683A4", VA = "0x1D683A4")]
    private void CheckAllOnOff()
    {
    }

    [Token(Token = "0x6014AB5")]
    [Address(RVA = "0x1D68654", Offset = "0x1D68654", VA = "0x1D68654")]
    public bool GetIsAllOn() => new bool();

    [Token(Token = "0x6014AB6")]
    [Address(RVA = "0x1D68714", Offset = "0x1D68714", VA = "0x1D68714")]
    public bool[] GetIsOns() => (bool[]) null;

    [Token(Token = "0x6014AB7")]
    [Address(RVA = "0x1D687C8", Offset = "0x1D687C8", VA = "0x1D687C8")]
    public PersonalEmblemFilterUtility.PersonalEmblemFilterCondition GetFilterCondition()
    {
      return new PersonalEmblemFilterUtility.PersonalEmblemFilterCondition();
    }

    [Token(Token = "0x6014AB8")]
    [Address(RVA = "0x1D687D0", Offset = "0x1D687D0", VA = "0x1D687D0")]
    public PersonalEmblemToggleGroup()
    {
    }
  }
}
