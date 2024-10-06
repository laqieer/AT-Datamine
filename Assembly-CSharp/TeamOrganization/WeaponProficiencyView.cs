// Decompiled with JetBrains decompiler
// Type: TeamOrganization.WeaponProficiencyView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200080F")]
  public class WeaponProficiencyView : MonoBehaviour
  {
    [Token(Token = "0x400262B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipSetProficiencyView[] proficiencyViews;

    [Token(Token = "0x6002E3D")]
    [Address(RVA = "0x3A91ED4", Offset = "0x3A91ED4", VA = "0x3A91ED4")]
    public void UpdateProficiency(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6002E3E")]
    [Address(RVA = "0x3A92588", Offset = "0x3A92588", VA = "0x3A92588")]
    public WeaponProficiencyView()
    {
    }
  }
}
