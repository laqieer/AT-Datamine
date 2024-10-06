// Decompiled with JetBrains decompiler
// Type: Battle.UI.TrustModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Skill;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200239D")]
  public class TrustModel : EquipmentTrustModelBase, IEquipmentModel
  {
    [Token(Token = "0x4009791")]
    [FieldOffset(Offset = "0x90")]
    private SkillModel skill;
    [Token(Token = "0x4009792")]
    [FieldOffset(Offset = "0x98")]
    private ParameterModel parameter;
    [Token(Token = "0x4009793")]
    [FieldOffset(Offset = "0xA0")]
    private AdditionalParameterModel additionalParameter;
    [Token(Token = "0x4009794")]
    [FieldOffset(Offset = "0xA8")]
    private EquipmentCommonModel common;
    [Token(Token = "0x4009795")]
    [FieldOffset(Offset = "0xB0")]
    private Battle.UI.SkillModelList skillModelList;

    [Token(Token = "0x17002EDD")]
    public override SkillModelBase Skill
    {
      [Token(Token = "0x600D9A9"), Address(RVA = "0x22D0B48", Offset = "0x22D0B48", VA = "0x22D0B48", Slot = "4")] get
      {
        return (SkillModelBase) null;
      }
    }

    [Token(Token = "0x17002EDE")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x600D9AA"), Address(RVA = "0x22D0B50", Offset = "0x22D0B50", VA = "0x22D0B50", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EDF")]
    public AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x600D9AB"), Address(RVA = "0x22D0B58", Offset = "0x22D0B58", VA = "0x22D0B58", Slot = "25")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EE0")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x600D9AC"), Address(RVA = "0x22D0B60", Offset = "0x22D0B60", VA = "0x22D0B60", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x17002EE1")]
    public SkillModelListBase SkillModelList
    {
      [Token(Token = "0x600D9AD"), Address(RVA = "0x22D0B68", Offset = "0x22D0B68", VA = "0x22D0B68", Slot = "23")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EE2")]
    public bool ExistReinforce
    {
      [Token(Token = "0x600D9AE"), Address(RVA = "0x22D0C1C", Offset = "0x22D0C1C", VA = "0x22D0C1C", Slot = "43")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EE3")]
    public bool ExistResist
    {
      [Token(Token = "0x600D9AF"), Address(RVA = "0x22D0DA0", Offset = "0x22D0DA0", VA = "0x22D0DA0", Slot = "44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EE4")]
    public bool ExistSlay
    {
      [Token(Token = "0x600D9B0"), Address(RVA = "0x22D0F24", Offset = "0x22D0F24", VA = "0x22D0F24", Slot = "45")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EE5")]
    public bool ExistResistSlay
    {
      [Token(Token = "0x600D9B1"), Address(RVA = "0x22D10A8", Offset = "0x22D10A8", VA = "0x22D10A8", Slot = "46")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D9B2")]
    [Address(RVA = "0x22D122C", Offset = "0x22D122C", VA = "0x22D122C")]
    public void Reset()
    {
    }

    [Token(Token = "0x600D9B3")]
    [Address(RVA = "0x22D156C", Offset = "0x22D156C", VA = "0x22D156C")]
    public void Set(TrustData trust)
    {
    }

    [Token(Token = "0x600D9B4")]
    [Address(RVA = "0x22D13B4", Offset = "0x22D13B4", VA = "0x22D13B4")]
    public void Set(TrustModel model)
    {
    }

    [Token(Token = "0x600D9B5")]
    [Address(RVA = "0x22D128C", Offset = "0x22D128C", VA = "0x22D128C")]
    public TrustModel()
    {
    }
  }
}
