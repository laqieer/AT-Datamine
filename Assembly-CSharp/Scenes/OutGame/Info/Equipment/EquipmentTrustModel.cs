// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentTrustModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x20035A0")]
  public class EquipmentTrustModel : EquipmentTrustModelBase
  {
    [Token(Token = "0x400E93D")]
    [FieldOffset(Offset = "0x90")]
    private SkillModel skill;
    [Token(Token = "0x400E93E")]
    [FieldOffset(Offset = "0x98")]
    private ParameterModel parameter;
    [Token(Token = "0x400E93F")]
    [FieldOffset(Offset = "0xA0")]
    private EquipmentCommonModel common;

    [Token(Token = "0x17004613")]
    public override SkillModelBase Skill
    {
      [Token(Token = "0x6015157"), Address(RVA = "0x4AAB4A0", Offset = "0x4AAB4A0", VA = "0x4AAB4A0", Slot = "4")] get
      {
        return (SkillModelBase) null;
      }
    }

    [Token(Token = "0x17004614")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x6015158"), Address(RVA = "0x4AAB4A8", Offset = "0x4AAB4A8", VA = "0x4AAB4A8", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17004615")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x6015159"), Address(RVA = "0x4AAB4B0", Offset = "0x4AAB4B0", VA = "0x4AAB4B0", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x17004616")]
    public StaqData.Equipment Equipment
    {
      [Token(Token = "0x601515A"), Address(RVA = "0x4AAB4B8", Offset = "0x4AAB4B8", VA = "0x4AAB4B8")] get
      {
        return (StaqData.Equipment) null;
      }
      [Token(Token = "0x601515B"), Address(RVA = "0x4AAB4C0", Offset = "0x4AAB4C0", VA = "0x4AAB4C0")] private set
      {
      }
    }

    [Token(Token = "0x601515C")]
    [Address(RVA = "0x4AAB4C8", Offset = "0x4AAB4C8", VA = "0x4AAB4C8")]
    public void Set(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x601515D")]
    [Address(RVA = "0x4AAB630", Offset = "0x4AAB630", VA = "0x4AAB630")]
    public void Set(int masterId)
    {
    }

    [Token(Token = "0x601515E")]
    [Address(RVA = "0x4AAB594", Offset = "0x4AAB594", VA = "0x4AAB594")]
    public void Set(UnitTrust trust)
    {
    }

    [Token(Token = "0x601515F")]
    [Address(RVA = "0x4AAB654", Offset = "0x4AAB654", VA = "0x4AAB654")]
    public EquipmentTrustModel()
    {
    }
  }
}
