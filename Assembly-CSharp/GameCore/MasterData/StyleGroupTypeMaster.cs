// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleGroupTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F29")]
  [Serializable]
  public sealed class StyleGroupTypeMaster : BaseMaster<StyleGroupTypeData>
  {
    [Token(Token = "0x4004BEA")]
    public const string TEXT_AB = "text_masterdata_unit";

    [Token(Token = "0x60059A4")]
    [Address(RVA = "0x3C33668", Offset = "0x3C33668", VA = "0x3C33668")]
    public IReadOnlyDictionary<int, StyleGroupTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleGroupTypeData>) null;
    }

    [Token(Token = "0x60059A5")]
    [Address(RVA = "0x3C33670", Offset = "0x3C33670", VA = "0x3C33670", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059A6")]
    [Address(RVA = "0x3C336D0", Offset = "0x3C336D0", VA = "0x3C336D0", Slot = "5")]
    protected override StyleGroupTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StyleGroupTypeData) null;
    }

    [Token(Token = "0x60059A7")]
    [Address(RVA = "0x3C33728", Offset = "0x3C33728", VA = "0x3C33728")]
    public StyleGroupTypeMaster()
    {
    }
  }
}
