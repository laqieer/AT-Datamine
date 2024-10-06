// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetParameterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007C2")]
  public class EquipSetParameterView : MonoBehaviour
  {
    [Token(Token = "0x4002438")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI hp;
    [Token(Token = "0x4002439")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI physicalAtk;
    [Token(Token = "0x400243A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI magicalAtk;
    [Token(Token = "0x400243B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI physicalDef;
    [Token(Token = "0x400243C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI magicalDef;
    [Token(Token = "0x400243D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI hit;
    [Token(Token = "0x400243E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI avoid;
    [Token(Token = "0x400243F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI critical;
    [Token(Token = "0x4002440")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI criticalAvoid;
    [Token(Token = "0x4002441")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI move;
    [Token(Token = "0x4002442")]
    [FieldOffset(Offset = "0x68")]
    private Color NomalTextColor;
    [Token(Token = "0x4002443")]
    [FieldOffset(Offset = "0x78")]
    private Color DownTextColor;
    [Token(Token = "0x4002444")]
    [FieldOffset(Offset = "0x88")]
    private Color UpTextColor;

    [Token(Token = "0x6002BED")]
    [Address(RVA = "0x3874D48", Offset = "0x3874D48", VA = "0x3874D48")]
    public void ResetParameter()
    {
    }

    [Token(Token = "0x6002BEE")]
    [Address(RVA = "0x3874FE0", Offset = "0x3874FE0", VA = "0x3874FE0")]
    public void UpdateParameter(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6002BEF")]
    [Address(RVA = "0x3875428", Offset = "0x3875428", VA = "0x3875428")]
    public void UpdateParameter(OrganizationPartySlot baseSlot, OrganizationPartySlot checkSlot)
    {
    }

    [Token(Token = "0x6002BF0")]
    [Address(RVA = "0x3875C9C", Offset = "0x3875C9C", VA = "0x3875C9C")]
    private Color GetParameterColor(int baseValue, int selectValue) => new Color();

    [Token(Token = "0x6002BF1")]
    [Address(RVA = "0x3875CF4", Offset = "0x3875CF4", VA = "0x3875CF4")]
    public EquipSetParameterView()
    {
    }
  }
}
