// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LandTagMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E48")]
  [Serializable]
  public sealed class LandTagMaster : BaseMaster<LandTagData>
  {
    [Token(Token = "0x60056E3")]
    [Address(RVA = "0x3E3A524", Offset = "0x3E3A524", VA = "0x3E3A524")]
    public IReadOnlyDictionary<int, LandTagData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LandTagData>) null;
    }

    [Token(Token = "0x60056E4")]
    [Address(RVA = "0x3E3A52C", Offset = "0x3E3A52C", VA = "0x3E3A52C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60056E5")]
    [Address(RVA = "0x3E3A58C", Offset = "0x3E3A58C", VA = "0x3E3A58C", Slot = "5")]
    protected override LandTagData LoadEntity(IMasterDataReader reader) => (LandTagData) null;

    [Token(Token = "0x60056E6")]
    [Address(RVA = "0x3E3A5E4", Offset = "0x3E3A5E4", VA = "0x3E3A5E4")]
    public LandTagMaster()
    {
    }
  }
}
