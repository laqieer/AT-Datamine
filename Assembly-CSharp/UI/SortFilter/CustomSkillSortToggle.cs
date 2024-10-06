// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.CustomSkillSortToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x200092E")]
  public class CustomSkillSortToggle : MonoBehaviour
  {
    [Token(Token = "0x4002AA9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x4002AAA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CustomSkillSortCondition condition;
    [Token(Token = "0x4002AAB")]
    [FieldOffset(Offset = "0x28")]
    private Action<CustomSkillSortCondition> OnToggleAction;

    [Token(Token = "0x60033AE")]
    [Address(RVA = "0x3629A2C", Offset = "0x3629A2C", VA = "0x3629A2C")]
    public void Initialized(
      CustomSkillSortCondition sortCondition,
      Action<CustomSkillSortCondition> action)
    {
    }

    [Token(Token = "0x60033AF")]
    [Address(RVA = "0x362A798", Offset = "0x362A798", VA = "0x362A798")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x60033B0")]
    [Address(RVA = "0x362A568", Offset = "0x362A568", VA = "0x362A568")]
    public void UpdateToggleStatus(CustomSkillSortCondition sortCondition)
    {
    }

    [Token(Token = "0x60033B1")]
    [Address(RVA = "0x362A7BC", Offset = "0x362A7BC", VA = "0x362A7BC")]
    public CustomSkillSortToggle()
    {
    }
  }
}
