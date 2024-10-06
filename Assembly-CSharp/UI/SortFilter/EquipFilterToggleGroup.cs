// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.EquipFilterToggleGroup
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
  [Token(Token = "0x200092F")]
  public class EquipFilterToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x4002AAC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggleAll;
    [Token(Token = "0x4002AAD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle[] toggles;
    [Token(Token = "0x4002AAE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipmentFilterCondition filterCondition;
    [Token(Token = "0x4002AAF")]
    [FieldOffset(Offset = "0x2C")]
    private bool isParentChange;
    [Token(Token = "0x4002AB0")]
    [FieldOffset(Offset = "0x2D")]
    private bool isChildrenChange;

    [Token(Token = "0x17000766")]
    public EquipmentFilterCondition Condition
    {
      [Token(Token = "0x60033B2"), Address(RVA = "0x362A7C4", Offset = "0x362A7C4", VA = "0x362A7C4")] get
      {
        return new EquipmentFilterCondition();
      }
    }

    [Token(Token = "0x60033B3")]
    [Address(RVA = "0x36282D0", Offset = "0x36282D0", VA = "0x36282D0")]
    public void Initialized(bool[] flags)
    {
    }

    [Token(Token = "0x60033B4")]
    [Address(RVA = "0x362A880", Offset = "0x362A880", VA = "0x362A880")]
    public void ChangeToggleAll(bool isOn)
    {
    }

    [Token(Token = "0x60033B5")]
    [Address(RVA = "0x362A8B0", Offset = "0x362A8B0", VA = "0x362A8B0")]
    public void OnValueChangedAllToggle(bool isOn)
    {
    }

    [Token(Token = "0x60033B6")]
    [Address(RVA = "0x362A934", Offset = "0x362A934", VA = "0x362A934")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x60033B7")]
    [Address(RVA = "0x362A7CC", Offset = "0x362A7CC", VA = "0x362A7CC")]
    private void CheckAllOnOff()
    {
    }

    [Token(Token = "0x60033B8")]
    [Address(RVA = "0x3628778", Offset = "0x3628778", VA = "0x3628778")]
    public bool GetIsAllOn() => new bool();

    [Token(Token = "0x60033B9")]
    [Address(RVA = "0x36287E0", Offset = "0x36287E0", VA = "0x36287E0")]
    public bool[] GetIsOns() => (bool[]) null;

    [Token(Token = "0x60033BA")]
    [Address(RVA = "0x362A95C", Offset = "0x362A95C", VA = "0x362A95C")]
    public EquipmentFilterCondition GetFilterCondition() => new EquipmentFilterCondition();

    [Token(Token = "0x60033BB")]
    [Address(RVA = "0x362A964", Offset = "0x362A964", VA = "0x362A964")]
    public EquipFilterToggleGroup()
    {
    }
  }
}
