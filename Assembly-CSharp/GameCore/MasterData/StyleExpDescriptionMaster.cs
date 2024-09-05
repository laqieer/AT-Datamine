// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleExpDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013AE")]
  [Serializable]
  public sealed class StyleExpDescriptionMaster : BaseMaster<StyleExpDescriptionData>
  {
    [Token(Token = "0x4005BB4")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StyleExpDescriptionData>> descriptionTable;

    [Token(Token = "0x6006E86")]
    [Address(RVA = "0x4706C30", Offset = "0x4706C30", VA = "0x4706C30")]
    public IReadOnlyDictionary<int, StyleExpDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleExpDescriptionData>) null;
    }

    [Token(Token = "0x6006E87")]
    [Address(RVA = "0x4706C38", Offset = "0x4706C38", VA = "0x4706C38", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E88")]
    [Address(RVA = "0x4706EFC", Offset = "0x4706EFC", VA = "0x4706EFC", Slot = "5")]
    protected override StyleExpDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (StyleExpDescriptionData) null;
    }

    [Token(Token = "0x6006E89")]
    [Address(RVA = "0x4706F6C", Offset = "0x4706F6C", VA = "0x4706F6C")]
    private void OnLoadEntity(StyleExpDescriptionData entity)
    {
    }

    [Token(Token = "0x6006E8A")]
    [Address(RVA = "0x4706CA0", Offset = "0x4706CA0", VA = "0x4706CA0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006E8B")]
    [Address(RVA = "0x4706F70", Offset = "0x4706F70", VA = "0x4706F70")]
    private void GroupingByStyleExpId(StyleExpDescriptionData entity)
    {
    }

    [Token(Token = "0x6006E8C")]
    [Address(RVA = "0x470712C", Offset = "0x470712C", VA = "0x470712C")]
    public IReadOnlyList<StyleExpDescriptionData> GetListByStyleExpId(int styleExpId)
    {
      return (IReadOnlyList<StyleExpDescriptionData>) null;
    }

    [Token(Token = "0x6006E8D")]
    [Address(RVA = "0x47071E8", Offset = "0x47071E8", VA = "0x47071E8")]
    public StyleExpDescriptionData GetDataByStyleExpIdLevelPair(int styleExpId, int level)
    {
      return (StyleExpDescriptionData) null;
    }

    [Token(Token = "0x6006E8E")]
    [Address(RVA = "0x470750C", Offset = "0x470750C", VA = "0x470750C")]
    public bool IsTargetLevelData(int styleExpId, int level) => new bool();

    [Token(Token = "0x6006E8F")]
    [Address(RVA = "0x470782C", Offset = "0x470782C", VA = "0x470782C")]
    public StyleExpDescriptionData GetDataByStyleExpIdExpPair(int styleExpId, int exp)
    {
      return (StyleExpDescriptionData) null;
    }

    [Token(Token = "0x6006E90")]
    [Address(RVA = "0x4707C54", Offset = "0x4707C54", VA = "0x4707C54")]
    public IReadOnlyCollection<StyleExpDescriptionData> GetListByStayleExpIdLevelPair(
      int coreExpId,
      int startLevel,
      int endLevel)
    {
      return (IReadOnlyCollection<StyleExpDescriptionData>) null;
    }

    [Token(Token = "0x6006E91")]
    [Address(RVA = "0x4707D80", Offset = "0x4707D80", VA = "0x4707D80")]
    public IReadOnlyCollection<StyleExpDescriptionData> GetListByStyleExpIdExpPair(
      int coreExpId,
      int exp1,
      int exp2)
    {
      return (IReadOnlyCollection<StyleExpDescriptionData>) null;
    }

    [Token(Token = "0x6006E92")]
    [Address(RVA = "0x4708150", Offset = "0x4708150", VA = "0x4708150")]
    public StyleExpDescriptionMaster()
    {
    }
  }
}
