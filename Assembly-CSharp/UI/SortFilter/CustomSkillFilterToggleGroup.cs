// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.CustomSkillFilterToggleGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Sort;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x2000928")]
  public class CustomSkillFilterToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x4002A8E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggleAll;
    [Token(Token = "0x4002A8F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle[] toggles;
    [Token(Token = "0x4002A90")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CustomSkillFilterCondition filterCondition;
    [Token(Token = "0x4002A91")]
    [FieldOffset(Offset = "0x2C")]
    private bool isParentChange;
    [Token(Token = "0x4002A92")]
    [FieldOffset(Offset = "0x2D")]
    private bool isChildrenChange;

    [Token(Token = "0x6003386")]
    [Address(RVA = "0x3629078", Offset = "0x3629078", VA = "0x3629078")]
    public void Initialized(bool[] flags)
    {
    }

    [Token(Token = "0x6003387")]
    [Address(RVA = "0x3629218", Offset = "0x3629218", VA = "0x3629218")]
    public void ChangeToggleAll(bool isOn)
    {
    }

    [Token(Token = "0x6003388")]
    [Address(RVA = "0x3629248", Offset = "0x3629248", VA = "0x3629248")]
    public void OnValueChangedAllToggle(bool isOn)
    {
    }

    [Token(Token = "0x6003389")]
    [Address(RVA = "0x36292CC", Offset = "0x36292CC", VA = "0x36292CC")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x600338A")]
    [Address(RVA = "0x3629120", Offset = "0x3629120", VA = "0x3629120")]
    private void CheckAllOnOff()
    {
    }

    [Token(Token = "0x600338B")]
    [Address(RVA = "0x36292F4", Offset = "0x36292F4", VA = "0x36292F4")]
    public bool GetIsAllOn() => new bool();

    [Token(Token = "0x600338C")]
    [Address(RVA = "0x362935C", Offset = "0x362935C", VA = "0x362935C")]
    public bool[] GetIsOns() => (bool[]) null;

    [Token(Token = "0x600338D")]
    [Address(RVA = "0x3629410", Offset = "0x3629410", VA = "0x3629410")]
    public CustomSkillFilterCondition GetFilterCondition() => new CustomSkillFilterCondition();

    [Token(Token = "0x600338E")]
    [Address(RVA = "0x3629418", Offset = "0x3629418", VA = "0x3629418")]
    public CustomSkillFilterToggleGroup()
    {
    }
  }
}
