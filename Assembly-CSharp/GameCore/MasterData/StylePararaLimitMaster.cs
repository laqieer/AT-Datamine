// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StylePararaLimitMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C8")]
  [Serializable]
  public sealed class StylePararaLimitMaster : BaseMaster<StylePararaLimitData>
  {
    [Token(Token = "0x4005C7C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StylePararaLimitData>> pararaLimitTable;

    [Token(Token = "0x6006F24")]
    [Address(RVA = "0x4711470", Offset = "0x4711470", VA = "0x4711470")]
    public IReadOnlyDictionary<int, StylePararaLimitData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StylePararaLimitData>) null;
    }

    [Token(Token = "0x6006F25")]
    [Address(RVA = "0x4711478", Offset = "0x4711478", VA = "0x4711478", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006F26")]
    [Address(RVA = "0x47114D8", Offset = "0x47114D8", VA = "0x47114D8", Slot = "5")]
    protected override StylePararaLimitData LoadEntity(IMasterDataReader reader)
    {
      return (StylePararaLimitData) null;
    }

    [Token(Token = "0x6006F27")]
    [Address(RVA = "0x4711548", Offset = "0x4711548", VA = "0x4711548")]
    private void OnLoadEntity(StylePararaLimitData entity)
    {
    }

    [Token(Token = "0x6006F28")]
    [Address(RVA = "0x471154C", Offset = "0x471154C", VA = "0x471154C")]
    private void GroupingByStyleId(StylePararaLimitData entity)
    {
    }

    [Token(Token = "0x6006F29")]
    [Address(RVA = "0x4711708", Offset = "0x4711708", VA = "0x4711708")]
    public StylePararaLimitData GetByStyleIdAndReincarnationCount(
      int styleId,
      int reincarnationCount)
    {
      return (StylePararaLimitData) null;
    }

    [Token(Token = "0x6006F2A")]
    [Address(RVA = "0x4711898", Offset = "0x4711898", VA = "0x4711898")]
    public StylePararaLimitMaster()
    {
    }
  }
}
