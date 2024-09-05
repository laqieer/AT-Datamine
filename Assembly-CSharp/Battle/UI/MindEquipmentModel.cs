// Decompiled with JetBrains decompiler
// Type: Battle.UI.MindEquipmentModel
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
  [Token(Token = "0x2002391")]
  public class MindEquipmentModel : EquipmentMindEquipmentModelBase, IEquipmentModel
  {
    [Token(Token = "0x4009756")]
    [FieldOffset(Offset = "0xB0")]
    private Battle.UI.SkillModelList skillModelList;
    [Token(Token = "0x4009757")]
    [FieldOffset(Offset = "0xB8")]
    private ParameterModel parameter;
    [Token(Token = "0x4009758")]
    [FieldOffset(Offset = "0xC0")]
    private AdditionalParameterModel additionalParameter;
    [Token(Token = "0x4009759")]
    [FieldOffset(Offset = "0xC8")]
    private EquipmentCommonModel common;

    [Token(Token = "0x17002EC5")]
    public override SkillModelListBase SkillModelList
    {
      [Token(Token = "0x600D939"), Address(RVA = "0x22C5B8C", Offset = "0x22C5B8C", VA = "0x22C5B8C", Slot = "4")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17002EC6")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x600D93A"), Address(RVA = "0x22C5B94", Offset = "0x22C5B94", VA = "0x22C5B94", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EC7")]
    public AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x600D93B"), Address(RVA = "0x22C5B9C", Offset = "0x22C5B9C", VA = "0x22C5B9C", Slot = "25")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17002EC8")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x600D93C"), Address(RVA = "0x22C5BA4", Offset = "0x22C5BA4", VA = "0x22C5BA4", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x17002EC9")]
    public bool ExistReinforce
    {
      [Token(Token = "0x600D93D"), Address(RVA = "0x22C5BAC", Offset = "0x22C5BAC", VA = "0x22C5BAC", Slot = "43")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002ECA")]
    public bool ExistResist
    {
      [Token(Token = "0x600D93E"), Address(RVA = "0x22C5D30", Offset = "0x22C5D30", VA = "0x22C5D30", Slot = "44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002ECB")]
    public bool ExistSlay
    {
      [Token(Token = "0x600D93F"), Address(RVA = "0x22C5EB4", Offset = "0x22C5EB4", VA = "0x22C5EB4", Slot = "45")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002ECC")]
    public bool ExistResistSlay
    {
      [Token(Token = "0x600D940"), Address(RVA = "0x22C6038", Offset = "0x22C6038", VA = "0x22C6038", Slot = "46")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D941")]
    [Address(RVA = "0x22C61BC", Offset = "0x22C61BC", VA = "0x22C61BC")]
    public void Reset()
    {
    }

    [Token(Token = "0x600D942")]
    [Address(RVA = "0x22C65A0", Offset = "0x22C65A0", VA = "0x22C65A0")]
    public void Set(MindEquipmentData mind)
    {
    }

    [Token(Token = "0x600D943")]
    [Address(RVA = "0x22C6314", Offset = "0x22C6314", VA = "0x22C6314")]
    public void Set(MindEquipmentModel model)
    {
    }

    [Token(Token = "0x600D944")]
    [Address(RVA = "0x22C621C", Offset = "0x22C621C", VA = "0x22C621C")]
    public MindEquipmentModel()
    {
    }
  }
}
