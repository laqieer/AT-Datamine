// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleLevelUpValueMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B8")]
  [Serializable]
  public sealed class StyleLevelUpValueMaster : BaseMaster<StyleLevelUpValueData>
  {
    [Token(Token = "0x6006EBE")]
    [Address(RVA = "0x4709580", Offset = "0x4709580", VA = "0x4709580")]
    public IReadOnlyDictionary<int, StyleLevelUpValueData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleLevelUpValueData>) null;
    }

    [Token(Token = "0x6006EBF")]
    [Address(RVA = "0x4709588", Offset = "0x4709588", VA = "0x4709588", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006EC0")]
    [Address(RVA = "0x47095E8", Offset = "0x47095E8", VA = "0x47095E8", Slot = "5")]
    protected override StyleLevelUpValueData LoadEntity(IMasterDataReader reader)
    {
      return (StyleLevelUpValueData) null;
    }

    [Token(Token = "0x6006EC1")]
    [Address(RVA = "0x4709640", Offset = "0x4709640", VA = "0x4709640")]
    public float GetValue(StyleLevelUpValueTypeEnum typeEnum) => new float();

    [Token(Token = "0x6006EC2")]
    [Address(RVA = "0x47097F4", Offset = "0x47097F4", VA = "0x47097F4")]
    public StyleLevelUpValueMaster()
    {
    }
  }
}
