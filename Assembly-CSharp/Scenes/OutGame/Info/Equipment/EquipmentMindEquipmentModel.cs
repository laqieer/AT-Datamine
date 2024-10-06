// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentMindEquipmentModel
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
  [Token(Token = "0x200359E")]
  public class EquipmentMindEquipmentModel : EquipmentMindEquipmentModelBase
  {
    [Token(Token = "0x400E929")]
    [FieldOffset(Offset = "0xB0")]
    private Scenes.OutGame.Info.Skill.SkillModelList skillModelList;
    [Token(Token = "0x400E92A")]
    [FieldOffset(Offset = "0xB8")]
    private ParameterModel parameterModel;
    [Token(Token = "0x400E92B")]
    [FieldOffset(Offset = "0xC0")]
    private EquipmentCommonModel commonModel;

    [Token(Token = "0x170045FC")]
    public override SkillModelListBase SkillModelList
    {
      [Token(Token = "0x601512B"), Address(RVA = "0x4AAAF08", Offset = "0x4AAAF08", VA = "0x4AAAF08", Slot = "4")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x170045FD")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x601512C"), Address(RVA = "0x4AAAF10", Offset = "0x4AAAF10", VA = "0x4AAAF10", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x170045FE")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x601512D"), Address(RVA = "0x4AAAF18", Offset = "0x4AAAF18", VA = "0x4AAAF18", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x170045FF")]
    public StaqData.Equipment Equipment
    {
      [Token(Token = "0x601512E"), Address(RVA = "0x4AAAF20", Offset = "0x4AAAF20", VA = "0x4AAAF20")] get
      {
        return (StaqData.Equipment) null;
      }
      [Token(Token = "0x601512F"), Address(RVA = "0x4AAAF28", Offset = "0x4AAAF28", VA = "0x4AAAF28")] private set
      {
      }
    }

    [Token(Token = "0x6015130")]
    [Address(RVA = "0x4AAAF30", Offset = "0x4AAAF30", VA = "0x4AAAF30")]
    public void Set(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x6015131")]
    [Address(RVA = "0x4AAB198", Offset = "0x4AAB198", VA = "0x4AAB198")]
    public void Set(int id)
    {
    }

    [Token(Token = "0x6015132")]
    [Address(RVA = "0x4AAAFFC", Offset = "0x4AAAFFC", VA = "0x4AAAFFC")]
    public void Set(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6015133")]
    [Address(RVA = "0x4AAB1BC", Offset = "0x4AAB1BC", VA = "0x4AAB1BC")]
    public EquipmentMindEquipmentModel()
    {
    }
  }
}
