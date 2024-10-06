// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleLimitBreakStatusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C6")]
  [Serializable]
  public sealed class StyleLimitBreakStatusMaster : BaseMaster<StyleLimitBreakStatusData>
  {
    [Token(Token = "0x4005C71")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, StyleLimitBreakStatusData> rarityStarMap;

    [Token(Token = "0x6006F1A")]
    [Address(RVA = "0x4710CD4", Offset = "0x4710CD4", VA = "0x4710CD4")]
    public IReadOnlyDictionary<int, StyleLimitBreakStatusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleLimitBreakStatusData>) null;
    }

    [Token(Token = "0x6006F1B")]
    [Address(RVA = "0x4710CDC", Offset = "0x4710CDC", VA = "0x4710CDC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006F1C")]
    [Address(RVA = "0x4710D3C", Offset = "0x4710D3C", VA = "0x4710D3C", Slot = "5")]
    protected override StyleLimitBreakStatusData LoadEntity(IMasterDataReader reader)
    {
      return (StyleLimitBreakStatusData) null;
    }

    [Token(Token = "0x6006F1D")]
    [Address(RVA = "0x4710DAC", Offset = "0x4710DAC", VA = "0x4710DAC")]
    private void OnLoadEntity(StyleLimitBreakStatusData entity)
    {
    }

    [Token(Token = "0x6006F1E")]
    [Address(RVA = "0x4710E48", Offset = "0x4710E48", VA = "0x4710E48")]
    public StyleLimitBreakStatusData GetDataByID(int id) => (StyleLimitBreakStatusData) null;

    [Token(Token = "0x6006F1F")]
    [Address(RVA = "0x4710EC0", Offset = "0x4710EC0", VA = "0x4710EC0")]
    public StyleLimitBreakStatusMaster()
    {
    }
  }
}
