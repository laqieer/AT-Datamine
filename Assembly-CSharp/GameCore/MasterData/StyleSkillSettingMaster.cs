// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleSkillSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013BB")]
  [Serializable]
  public sealed class StyleSkillSettingMaster : BaseMaster<StyleSkillSettingData>
  {
    [Token(Token = "0x4005BCA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StyleSkillSettingData>> descriptionTable;

    [Token(Token = "0x6006EC9")]
    [Address(RVA = "0x4709A70", Offset = "0x4709A70", VA = "0x4709A70")]
    public IReadOnlyDictionary<int, StyleSkillSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleSkillSettingData>) null;
    }

    [Token(Token = "0x6006ECA")]
    [Address(RVA = "0x4709A78", Offset = "0x4709A78", VA = "0x4709A78", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006ECB")]
    [Address(RVA = "0x4709D3C", Offset = "0x4709D3C", VA = "0x4709D3C", Slot = "5")]
    protected override StyleSkillSettingData LoadEntity(IMasterDataReader reader)
    {
      return (StyleSkillSettingData) null;
    }

    [Token(Token = "0x6006ECC")]
    [Address(RVA = "0x4709DAC", Offset = "0x4709DAC", VA = "0x4709DAC")]
    private void OnLoadEntity(StyleSkillSettingData entity)
    {
    }

    [Token(Token = "0x6006ECD")]
    [Address(RVA = "0x4709AE0", Offset = "0x4709AE0", VA = "0x4709AE0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006ECE")]
    [Address(RVA = "0x4709DB0", Offset = "0x4709DB0", VA = "0x4709DB0")]
    private void GroupingByGroupId(StyleSkillSettingData entity)
    {
    }

    [Token(Token = "0x6006ECF")]
    [Address(RVA = "0x4709F6C", Offset = "0x4709F6C", VA = "0x4709F6C")]
    public StyleSkillSettingData GetListByStyleIdAndStyleSkillType(
      int styleId,
      StyleSkillTypeEnum styleSkillType)
    {
      return (StyleSkillSettingData) null;
    }

    [Token(Token = "0x6006ED0")]
    [Address(RVA = "0x470A110", Offset = "0x470A110", VA = "0x470A110")]
    public List<StyleSkillSettingData> GetListByStyleId(int styleId)
    {
      return (List<StyleSkillSettingData>) null;
    }

    [Token(Token = "0x6006ED1")]
    [Address(RVA = "0x470A1CC", Offset = "0x470A1CC", VA = "0x470A1CC")]
    public StyleSkillSettingData GetDataByCharacterSkillId(int skillId)
    {
      return (StyleSkillSettingData) null;
    }

    [Token(Token = "0x6006ED2")]
    [Address(RVA = "0x470A378", Offset = "0x470A378", VA = "0x470A378")]
    public StyleSkillSettingMaster()
    {
    }
  }
}
