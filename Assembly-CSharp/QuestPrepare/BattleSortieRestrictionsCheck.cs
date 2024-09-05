// Decompiled with JetBrains decompiler
// Type: QuestPrepare.BattleSortieRestrictionsCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace QuestPrepare
{
  [Token(Token = "0x200096D")]
  public class BattleSortieRestrictionsCheck
  {
    [Token(Token = "0x4002BAE")]
    [FieldOffset(Offset = "0x10")]
    public IReadOnlyList<BattleSortieRestrictionsData> SortieRestrictionsDatas;
    [Token(Token = "0x4002BAF")]
    [FieldOffset(Offset = "0x18")]
    public bool IsAllowSameCharacter;

    [Token(Token = "0x1700077D")]
    public int MasterDataCount
    {
      [Token(Token = "0x600353C"), Address(RVA = "0x3525E08", Offset = "0x3525E08", VA = "0x3525E08")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600353D")]
    [Address(RVA = "0x3525F20", Offset = "0x3525F20", VA = "0x3525F20")]
    public BattleSortieRestrictionsCheck(int sortieRestrictionsGroupId, bool isAllowSameCharacter)
    {
    }

    [Token(Token = "0x600353E")]
    [Address(RVA = "0x3525FD4", Offset = "0x3525FD4", VA = "0x3525FD4")]
    public bool CheckCanOrganization(OrganizationPartySlot slot, bool checkSub = false)
    {
      return new bool();
    }

    [Token(Token = "0x600353F")]
    [Address(RVA = "0x3526520", Offset = "0x3526520", VA = "0x3526520")]
    public bool CheckCanOrganization(
      OrganizationPartySlot slot,
      BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003540")]
    [Address(RVA = "0x352749C", Offset = "0x352749C", VA = "0x352749C")]
    private bool CheckWeaponType(string weaponId, BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003541")]
    [Address(RVA = "0x35276F8", Offset = "0x35276F8", VA = "0x35276F8")]
    private bool CheckClassificationType(string weaponId, BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003542")]
    [Address(RVA = "0x35277FC", Offset = "0x35277FC", VA = "0x35277FC")]
    private bool CheckEquipmentSkill(
      OrganizationPartySlot slot,
      BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003543")]
    [Address(RVA = "0x35275EC", Offset = "0x35275EC", VA = "0x35275EC")]
    private bool CheckWeaponSkill(string weaponId, BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003544")]
    [Address(RVA = "0x3527B70", Offset = "0x3527B70", VA = "0x3527B70")]
    private bool CheckAccessorySkill(string accessoryId, BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003545")]
    [Address(RVA = "0x3527C7C", Offset = "0x3527C7C", VA = "0x3527C7C")]
    private bool CheckMindEquipmentSkill(
      string mindEquipmentId,
      BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003546")]
    [Address(RVA = "0x3527D88", Offset = "0x3527D88", VA = "0x3527D88")]
    private bool CheckUnitTrustSkill(string unitTrustId, BattleSortieRestrictionsData sortieData)
    {
      return new bool();
    }

    [Token(Token = "0x6003547")]
    [Address(RVA = "0x3526DCC", Offset = "0x3526DCC", VA = "0x3526DCC")]
    private bool CheckUnitTagGroup(int checkTagGroupId, int styleGroupId) => new bool();

    [Token(Token = "0x6003548")]
    [Address(RVA = "0x3527130", Offset = "0x3527130", VA = "0x3527130")]
    private bool CheckUnitTag(StyleGroupTypeEnum checkTagType, int styleGroupId) => new bool();

    [Token(Token = "0x6003549")]
    [Address(RVA = "0x35277D8", Offset = "0x35277D8", VA = "0x35277D8")]
    private bool CheckMainComparisonTypeInOut(
      bool valueCheck,
      BattleSortieRestrictionsMainComparisonTypeEnum mainComparisonType)
    {
      return new bool();
    }

    [Token(Token = "0x600354A")]
    [Address(RVA = "0x3527E68", Offset = "0x3527E68", VA = "0x3527E68")]
    public bool CheckSortieRestrictions(OrganizationTeam team, int memberNum) => new bool();

    [Token(Token = "0x600354B")]
    [Address(RVA = "0x3527B08", Offset = "0x3527B08", VA = "0x3527B08")]
    private bool CheckComparisonValue(
      int comparisonValue,
      int value,
      BattleSortieRestrictionsMainComparisonTypeEnum comparisonType)
    {
      return new bool();
    }

    [Token(Token = "0x600354C")]
    [Address(RVA = "0x35284F4", Offset = "0x35284F4", VA = "0x35284F4")]
    private bool CheckSubComparison(
      int comparisonValue,
      int value,
      BattleSortieRestrictionsSubComparisonTypeEnum subComparisonType)
    {
      return new bool();
    }

    [Token(Token = "0x600354D")]
    [Address(RVA = "0x3528538", Offset = "0x3528538", VA = "0x3528538")]
    public List<int> GetSortieRestrictionCharacterID(
      BattleSortieRestrictionsMainComparisonTypeEnum inOutType)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x600354E")]
    [Address(RVA = "0x35288EC", Offset = "0x35288EC", VA = "0x35288EC")]
    public List<int> GetSortieRestrictionStyleID(
      BattleSortieRestrictionsMainComparisonTypeEnum inOutType)
    {
      return (List<int>) null;
    }
  }
}
