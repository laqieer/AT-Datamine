// Decompiled with JetBrains decompiler
// Type: TeamOrganization.WeaponTypeIconWithText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000811")]
  public class WeaponTypeIconWithText : WeaponTypeIcon
  {
    [Token(Token = "0x400262D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400262E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI attackTypeText;
    [Token(Token = "0x400262F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private WeaponTypeIcon weaponTypeIcon;

    [Token(Token = "0x6002E41")]
    [Address(RVA = "0x3A9262C", Offset = "0x3A9262C", VA = "0x3A9262C")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6002E42")]
    [Address(RVA = "0x3A92648", Offset = "0x3A92648", VA = "0x3A92648", Slot = "4")]
    public override void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6002E43")]
    [Address(RVA = "0x3A9270C", Offset = "0x3A9270C", VA = "0x3A9270C")]
    public void SetAttackTypeText(AttackTypeEnum attackType)
    {
    }

    [Token(Token = "0x6002E44")]
    [Address(RVA = "0x3A927E0", Offset = "0x3A927E0", VA = "0x3A927E0")]
    public WeaponTypeIconWithText()
    {
    }
  }
}
