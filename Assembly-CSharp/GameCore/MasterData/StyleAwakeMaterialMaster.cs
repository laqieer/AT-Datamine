// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleAwakeMaterialMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013AC")]
  [Serializable]
  public sealed class StyleAwakeMaterialMaster : BaseMaster<StyleAwakeMaterialData>
  {
    [Token(Token = "0x4005BAA")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<Tuple<int, ElementTypeEnum>, List<StyleAwakeMaterialData>> initialRarityMap;
    [Token(Token = "0x4005BAB")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<StyleAwakeMaterialData>> styleMap;

    [Token(Token = "0x6006E7A")]
    [Address(RVA = "0x4705E78", Offset = "0x4705E78", VA = "0x4705E78")]
    public IReadOnlyDictionary<int, StyleAwakeMaterialData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleAwakeMaterialData>) null;
    }

    [Token(Token = "0x6006E7B")]
    [Address(RVA = "0x4705E80", Offset = "0x4705E80", VA = "0x4705E80", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E7C")]
    [Address(RVA = "0x4705EE0", Offset = "0x4705EE0", VA = "0x4705EE0", Slot = "5")]
    protected override StyleAwakeMaterialData LoadEntity(IMasterDataReader reader)
    {
      return (StyleAwakeMaterialData) null;
    }

    [Token(Token = "0x6006E7D")]
    [Address(RVA = "0x4705F50", Offset = "0x4705F50", VA = "0x4705F50")]
    private void OnLoadEntity(StyleAwakeMaterialData entity)
    {
    }

    [Token(Token = "0x6006E7E")]
    [Address(RVA = "0x47062C8", Offset = "0x47062C8", VA = "0x47062C8")]
    public StyleAwakeMaterialData[] GetInitialRarityDatas(
      int initialRarity,
      ElementTypeEnum element,
      int awakeCount)
    {
      return (StyleAwakeMaterialData[]) null;
    }

    [Token(Token = "0x6006E7F")]
    [Address(RVA = "0x4706630", Offset = "0x4706630", VA = "0x4706630")]
    public StyleAwakeMaterialData[] GetStyleDatas(int styleId, int awakeCount)
    {
      return (StyleAwakeMaterialData[]) null;
    }

    [Token(Token = "0x6006E80")]
    [Address(RVA = "0x4706408", Offset = "0x4706408", VA = "0x4706408")]
    private void GetData(
      List<StyleAwakeMaterialData> targetList,
      int awakeCount,
      out List<StyleAwakeMaterialData> materialDatas)
    {
    }

    [Token(Token = "0x6006E81")]
    [Address(RVA = "0x470671C", Offset = "0x470671C", VA = "0x470671C")]
    public StyleAwakeMaterialMaster()
    {
    }
  }
}
