// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Viewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.Info.Style;
using Scenes.OutGame.Info.Style.UI;
using Scenes.OutGame.Info.Unit;
using Scenes.OutGame.Info.Unit.UI;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info
{
  [Token(Token = "0x2003538")]
  public static class Viewer
  {
    [Token(Token = "0x6014DD4")]
    [Address(RVA = "0x1B41A40", Offset = "0x1B41A40", VA = "0x1B41A40")]
    public static UnitPopup ShowUnit(
      UniqueID style,
      UniqueID mainWeapon,
      UniqueID subWeapon1,
      UniqueID subWeapon2,
      UniqueID accessory,
      UniqueID unitTrust,
      UniqueID mindEquipment,
      List<UniqueID> customSkillIds,
      bool isNeedLp)
    {
      return (UnitPopup) null;
    }

    [Token(Token = "0x6014DD5")]
    [Address(RVA = "0x1B42378", Offset = "0x1B42378", VA = "0x1B42378")]
    public static UnitPopup ShowUnitForExpedition(UniqueID style, bool isNeedLp = false)
    {
      return (UnitPopup) null;
    }

    [Token(Token = "0x6014DD6")]
    [Address(RVA = "0x1B41C7C", Offset = "0x1B41C7C", VA = "0x1B41C7C")]
    private static UnitPopup ShowUnit(out UnitModel model, bool isNeedLp) => (UnitPopup) null;

    [Token(Token = "0x6014DD7")]
    [Address(RVA = "0x1B42E78", Offset = "0x1B42E78", VA = "0x1B42E78")]
    public static StylePopup ShowStyle(UniqueID uniqueID) => (StylePopup) null;

    [Token(Token = "0x6014DD8")]
    [Address(RVA = "0x1B43218", Offset = "0x1B43218", VA = "0x1B43218")]
    public static StylePopup ShowStyleGachaPickup(
      StaqData.Style[] styles,
      List<CommunicationSkill>[] commuSkills)
    {
      return (StylePopup) null;
    }

    [Token(Token = "0x6014DD9")]
    [Address(RVA = "0x1B42ED8", Offset = "0x1B42ED8", VA = "0x1B42ED8")]
    private static StylePopup ShowStyle(bool isDisplayEnhance, out StyleModel model)
    {
      return (StylePopup) null;
    }

    [Token(Token = "0x6014DDA")]
    [Address(RVA = "0x1B44840", Offset = "0x1B44840", VA = "0x1B44840")]
    public static EquipmentPopup ShowWeapon(UniqueID weaponID) => (EquipmentPopup) null;

    [Token(Token = "0x6014DDB")]
    [Address(RVA = "0x1B44D90", Offset = "0x1B44D90", VA = "0x1B44D90")]
    public static EquipmentPopup ShowWeapon(Weapon weapon, bool isForExpedition = false)
    {
      return (EquipmentPopup) null;
    }

    [Token(Token = "0x6014DDC")]
    [Address(RVA = "0x1B448A4", Offset = "0x1B448A4", VA = "0x1B448A4")]
    private static EquipmentPopup ShowWeaponInfo(
      out EquipmentWeaponModel model,
      bool isForExpedition = false)
    {
      return (EquipmentPopup) null;
    }

    [Token(Token = "0x6014DDD")]
    [Address(RVA = "0x1B44DFC", Offset = "0x1B44DFC", VA = "0x1B44DFC")]
    public static EquipmentPopup ShowAccessory(UniqueID uniqueID) => (EquipmentPopup) null;

    [Token(Token = "0x6014DDE")]
    [Address(RVA = "0x1B44E58", Offset = "0x1B44E58", VA = "0x1B44E58")]
    private static EquipmentPopup ShowAccessory(out EquipmentAccessoryModel model)
    {
      return (EquipmentPopup) null;
    }

    [Token(Token = "0x6014DDF")]
    [Address(RVA = "0x1B45344", Offset = "0x1B45344", VA = "0x1B45344")]
    public static EquipmentPopup ShowUnitTrust(UniqueID uniqueID) => (EquipmentPopup) null;

    [Token(Token = "0x6014DE0")]
    [Address(RVA = "0x1B458C0", Offset = "0x1B458C0", VA = "0x1B458C0")]
    public static EquipmentPopup ShowUnitTrust(int masterDataId) => (EquipmentPopup) null;

    [Token(Token = "0x6014DE1")]
    [Address(RVA = "0x1B4591C", Offset = "0x1B4591C", VA = "0x1B4591C")]
    public static EquipmentPopup ShowUnitTrustByMasterData(int trustId) => (EquipmentPopup) null;

    [Token(Token = "0x6014DE2")]
    [Address(RVA = "0x1B453A0", Offset = "0x1B453A0", VA = "0x1B453A0")]
    private static EquipmentPopup ShowUnitTrust(out EquipmentTrustModel model)
    {
      return (EquipmentPopup) null;
    }

    [Token(Token = "0x6014DE3")]
    [Address(RVA = "0x1B45994", Offset = "0x1B45994", VA = "0x1B45994")]
    public static EquipmentPopup ShowMindEquipment(UniqueID uniqueID) => (EquipmentPopup) null;

    [Token(Token = "0x6014DE4")]
    [Address(RVA = "0x1B45FEC", Offset = "0x1B45FEC", VA = "0x1B45FEC")]
    public static EquipmentPopup ShowMindEquipmentGachaPickup(int[] ids) => (EquipmentPopup) null;

    [Token(Token = "0x6014DE5")]
    [Address(RVA = "0x1B459F0", Offset = "0x1B459F0", VA = "0x1B459F0")]
    private static EquipmentPopup ShowMindEquipment(out EquipmentMindEquipmentModel model)
    {
      return (EquipmentPopup) null;
    }

    [Token(Token = "0x6014DE6")]
    [Address(RVA = "0x1B46078", Offset = "0x1B46078", VA = "0x1B46078")]
    public static EquipmentPopup ShowSkillPopup(CustomSkill customSkill) => (EquipmentPopup) null;

    [Token(Token = "0x6014DE7")]
    [Address(RVA = "0x1B4631C", Offset = "0x1B4631C", VA = "0x1B4631C")]
    public static SkillInfoPopup ShowSkillDetailPopup(int skillBaseID) => (SkillInfoPopup) null;

    [Token(Token = "0x6014DE8")]
    [Address(RVA = "0x1B4653C", Offset = "0x1B4653C", VA = "0x1B4653C")]
    public static SkillInfoPopup ShowSkillDetailPopup(EquipmentSkill skill)
    {
      return (SkillInfoPopup) null;
    }

    [Token(Token = "0x6014DE9")]
    [Address(RVA = "0x1B4659C", Offset = "0x1B4659C", VA = "0x1B4659C")]
    public static SkillInfoPopup ShowSkillDetailPopup(SkillModelBase src) => (SkillInfoPopup) null;

    [Token(Token = "0x6014DEA")]
    [Address(RVA = "0x1B460F8", Offset = "0x1B460F8", VA = "0x1B460F8")]
    private static EquipmentPopup ShowSkillPopup(
      out EquipmentCommonModel common,
      out SkillModel skill)
    {
      return (EquipmentPopup) null;
    }

    [Token(Token = "0x6014DEB")]
    [Address(RVA = "0x1B4637C", Offset = "0x1B4637C", VA = "0x1B4637C")]
    private static SkillInfoPopup ShowSkillDetailPopup(out SkillModel model)
    {
      return (SkillInfoPopup) null;
    }

    [Token(Token = "0x6014DEC")]
    [Address(RVA = "0x1B46600", Offset = "0x1B46600", VA = "0x1B46600")]
    public static EquipmentAdditionalParameterPopup ShowAdditionalParameterPopup(StaqData.Equipment equipment)
    {
      return (EquipmentAdditionalParameterPopup) null;
    }

    [Token(Token = "0x6014DED")]
    [Address(RVA = "0x1B4665C", Offset = "0x1B4665C", VA = "0x1B4665C")]
    private static EquipmentAdditionalParameterPopup ShowAdditionalParameterPopup(
      out AdditionalParameterModel model)
    {
      return (EquipmentAdditionalParameterPopup) null;
    }
  }
}
