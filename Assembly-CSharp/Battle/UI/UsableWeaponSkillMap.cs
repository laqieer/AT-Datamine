// Decompiled with JetBrains decompiler
// Type: Battle.UI.UsableWeaponSkillMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023D4")]
  public sealed class UsableWeaponSkillMap
  {
    [Token(Token = "0x40098D9")]
    [FieldOffset(Offset = "0x10")]
    public BoardData board;
    [Token(Token = "0x40098DA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SkillParameterData>> weaponSkillMap;

    [Token(Token = "0x600DB8B")]
    [Address(RVA = "0x214A6EC", Offset = "0x214A6EC", VA = "0x214A6EC")]
    public void Map(BoardData board, UnitParameterData owner)
    {
    }

    [Token(Token = "0x600DB8C")]
    [Address(RVA = "0x2148300", Offset = "0x2148300", VA = "0x2148300")]
    public List<SkillParameterData> GetUsableSkillsByWeaponIndex(int weaponIdx)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600DB8D")]
    [Address(RVA = "0x21494B4", Offset = "0x21494B4", VA = "0x21494B4")]
    public bool IsCanUse(
      UnitParameterData owner,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam)
    {
      return new bool();
    }

    [Token(Token = "0x600DB8E")]
    [Address(RVA = "0x214E8C4", Offset = "0x214E8C4", VA = "0x214E8C4")]
    private bool IsUsableSkillWith(
      UnitParameterData owner,
      WeaponParameterData weaponParam,
      SkillParameterData skillParam)
    {
      return new bool();
    }

    [Token(Token = "0x600DB8F")]
    [Address(RVA = "0x214E928", Offset = "0x214E928", VA = "0x214E928")]
    private bool IsUsableSkill(UnitParameterData unit, SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600DB90")]
    [Address(RVA = "0x214EA08", Offset = "0x214EA08", VA = "0x214EA08")]
    private bool IsActivatableSkill(SkillParameterData skill, WeaponParameterData weapon)
    {
      return new bool();
    }

    [Token(Token = "0x600DB91")]
    [Address(RVA = "0x214EA7C", Offset = "0x214EA7C", VA = "0x214EA7C")]
    public UsableWeaponSkillMap()
    {
    }
  }
}
