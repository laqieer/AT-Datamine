// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.StyleFilterToggleGroup
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
  [Token(Token = "0x2000946")]
  public class StyleFilterToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x4002B01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggleAll;
    [Token(Token = "0x4002B02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle[] toggles;
    [Token(Token = "0x4002B03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleFilterCondition filterCondition;
    [Token(Token = "0x4002B04")]
    [FieldOffset(Offset = "0x2C")]
    private bool isParentChange;
    [Token(Token = "0x4002B05")]
    [FieldOffset(Offset = "0x2D")]
    private bool isChildrenChange;

    [Token(Token = "0x6003439")]
    [Address(RVA = "0x362FD3C", Offset = "0x362FD3C", VA = "0x362FD3C")]
    public void Initialized(bool[] flags)
    {
    }

    [Token(Token = "0x600343A")]
    [Address(RVA = "0x362FEE8", Offset = "0x362FEE8", VA = "0x362FEE8")]
    public void ChangeToggleAll(bool isOn)
    {
    }

    [Token(Token = "0x600343B")]
    [Address(RVA = "0x362FF7C", Offset = "0x362FF7C", VA = "0x362FF7C")]
    public void OnValueChangedAllToggle(bool isOn)
    {
    }

    [Token(Token = "0x600343C")]
    [Address(RVA = "0x363006C", Offset = "0x363006C", VA = "0x363006C")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x600343D")]
    [Address(RVA = "0x362FDE4", Offset = "0x362FDE4", VA = "0x362FDE4")]
    private void CheckAllOnOff()
    {
    }

    [Token(Token = "0x600343E")]
    [Address(RVA = "0x3630094", Offset = "0x3630094", VA = "0x3630094")]
    public bool GetIsAllOn() => new bool();

    [Token(Token = "0x600343F")]
    [Address(RVA = "0x3630154", Offset = "0x3630154", VA = "0x3630154")]
    public bool[] GetIsOns() => (bool[]) null;

    [Token(Token = "0x6003440")]
    [Address(RVA = "0x3630208", Offset = "0x3630208", VA = "0x3630208")]
    public StyleFilterCondition GetFilterCondition() => new StyleFilterCondition();

    [Token(Token = "0x6003441")]
    [Address(RVA = "0x3630210", Offset = "0x3630210", VA = "0x3630210")]
    public StyleFilterToggleGroup()
    {
    }
  }
}
