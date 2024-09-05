// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.ItemFilterToggleGroup
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
  [Token(Token = "0x2000935")]
  public class ItemFilterToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x4002AD4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggleAll;
    [Token(Token = "0x4002AD5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle[] toggles;
    [Token(Token = "0x4002AD6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemFilterCondition filterCondition;
    [Token(Token = "0x4002AD7")]
    [FieldOffset(Offset = "0x2C")]
    private bool isParentChange;
    [Token(Token = "0x4002AD8")]
    [FieldOffset(Offset = "0x2D")]
    private bool isChildrenChange;

    [Token(Token = "0x60033E7")]
    [Address(RVA = "0x362C1DC", Offset = "0x362C1DC", VA = "0x362C1DC")]
    public void Initialized(bool[] flags)
    {
    }

    [Token(Token = "0x60033E8")]
    [Address(RVA = "0x362C0E8", Offset = "0x362C0E8", VA = "0x362C0E8")]
    public void ChangeToggleAll(bool isOn)
    {
    }

    [Token(Token = "0x60033E9")]
    [Address(RVA = "0x362C390", Offset = "0x362C390", VA = "0x362C390")]
    public void OnValueChangedAllToggle(bool isOn)
    {
    }

    [Token(Token = "0x60033EA")]
    [Address(RVA = "0x362C480", Offset = "0x362C480", VA = "0x362C480")]
    public void OnValueChangedToggle(bool isOn)
    {
    }

    [Token(Token = "0x60033EB")]
    [Address(RVA = "0x362C28C", Offset = "0x362C28C", VA = "0x362C28C")]
    private void CheckAllOnOff()
    {
    }

    [Token(Token = "0x60033EC")]
    [Address(RVA = "0x362BD58", Offset = "0x362BD58", VA = "0x362BD58")]
    public bool GetIsAllOn() => new bool();

    [Token(Token = "0x60033ED")]
    [Address(RVA = "0x362BE18", Offset = "0x362BE18", VA = "0x362BE18")]
    public bool[] GetIsOns() => (bool[]) null;

    [Token(Token = "0x60033EE")]
    [Address(RVA = "0x362C4A8", Offset = "0x362C4A8", VA = "0x362C4A8")]
    public ItemFilterCondition GetFilterCondition() => new ItemFilterCondition();

    [Token(Token = "0x60033EF")]
    [Address(RVA = "0x362C4B0", Offset = "0x362C4B0", VA = "0x362C4B0")]
    public ItemFilterToggleGroup()
    {
    }
  }
}
