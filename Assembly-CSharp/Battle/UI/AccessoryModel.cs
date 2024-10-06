// Decompiled with JetBrains decompiler
// Type: Battle.UI.AccessoryModel
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
  [Token(Token = "0x200238D")]
  public class AccessoryModel : EquipmentAccessoryModelBase, IEquipmentModel
  {
    [Token(Token = "0x400974E")]
    [FieldOffset(Offset = "0xB0")]
    private Battle.UI.SkillModelList skillModelList;
    [Token(Token = "0x400974F")]
    [FieldOffset(Offset = "0xB8")]
    private ParameterModel parameter;
    [Token(Token = "0x4009750")]
    [FieldOffset(Offset = "0xC0")]
    private AdditionalParameterModel additionalParameter;
    [Token(Token = "0x4009751")]
    [FieldOffset(Offset = "0xC8")]
    private EquipmentCommonModel common;
    [Token(Token = "0x4009752")]
    [FieldOffset(Offset = "0xD0")]
    private bool isUnknown;

    [Token(Token = "0x17002EA1")]
    public override SkillModelListBase SkillModelList
    {
      [Token(Token = "0x600D905"), Address(RVA = "0x1B9AF50", Offset = "0x1B9AF50", VA = "0x1B9AF50", Slot = "4")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EA2")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x600D906"), Address(RVA = "0x1B9AF58", Offset = "0x1B9AF58", VA = "0x1B9AF58", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EA3")]
    public AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x600D907"), Address(RVA = "0x1B9AF60", Offset = "0x1B9AF60", VA = "0x1B9AF60", Slot = "26")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EA4")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x600D908"), Address(RVA = "0x1B9AF68", Offset = "0x1B9AF68", VA = "0x1B9AF68", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x17002EA5")]
    public bool ExistReinforce
    {
      [Token(Token = "0x600D909"), Address(RVA = "0x1B9AF70", Offset = "0x1B9AF70", VA = "0x1B9AF70", Slot = "44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EA6")]
    public bool ExistResist
    {
      [Token(Token = "0x600D90A"), Address(RVA = "0x1B9B0F4", Offset = "0x1B9B0F4", VA = "0x1B9B0F4", Slot = "45")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EA7")]
    public bool ExistSlay
    {
      [Token(Token = "0x600D90B"), Address(RVA = "0x1B9B278", Offset = "0x1B9B278", VA = "0x1B9B278", Slot = "46")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EA8")]
    public bool ExistResistSlay
    {
      [Token(Token = "0x600D90C"), Address(RVA = "0x1B9B3FC", Offset = "0x1B9B3FC", VA = "0x1B9B3FC", Slot = "47")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002EA9")]
    public override bool IsUnknown
    {
      [Token(Token = "0x600D90D"), Address(RVA = "0x1B9B580", Offset = "0x1B9B580", VA = "0x1B9B580", Slot = "23")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D90E")]
    [Address(RVA = "0x1B9B588", Offset = "0x1B9B588", VA = "0x1B9B588")]
    public void Reset()
    {
    }

    [Token(Token = "0x600D90F")]
    [Address(RVA = "0x1B9B5E8", Offset = "0x1B9B5E8", VA = "0x1B9B5E8")]
    public void Set(AccessoryData acc)
    {
    }

    [Token(Token = "0x600D910")]
    [Address(RVA = "0x1B92110", Offset = "0x1B92110", VA = "0x1B92110")]
    public void Set(AccessoryModel model)
    {
    }

    [Token(Token = "0x600D911")]
    [Address(RVA = "0x1B92428", Offset = "0x1B92428", VA = "0x1B92428")]
    public AccessoryModel()
    {
    }
  }
}
