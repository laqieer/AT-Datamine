// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleLandCorrectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E1A")]
  [Serializable]
  public sealed class BattleLandCorrectMaster : BaseMaster<BattleLandCorrectData>
  {
    [Token(Token = "0x400432C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, BattleLandCorrectData> mapWithLandform;

    [Token(Token = "0x60055EC")]
    [Address(RVA = "0x3E2FC30", Offset = "0x3E2FC30", VA = "0x3E2FC30")]
    public IReadOnlyDictionary<int, BattleLandCorrectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleLandCorrectData>) null;
    }

    [Token(Token = "0x60055ED")]
    [Address(RVA = "0x3E2FC38", Offset = "0x3E2FC38", VA = "0x3E2FC38", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055EE")]
    [Address(RVA = "0x3E2FC98", Offset = "0x3E2FC98", VA = "0x3E2FC98", Slot = "5")]
    protected override BattleLandCorrectData LoadEntity(IMasterDataReader reader)
    {
      return (BattleLandCorrectData) null;
    }

    [Token(Token = "0x60055EF")]
    [Address(RVA = "0x3E2FD08", Offset = "0x3E2FD08", VA = "0x3E2FD08")]
    private void OnLoadEntity(BattleLandCorrectData entity)
    {
    }

    [Token(Token = "0x60055F0")]
    [Address(RVA = "0x3E2FD68", Offset = "0x3E2FD68", VA = "0x3E2FD68")]
    public BattleLandCorrectData GetByLandform(LandformTypeEnum type)
    {
      return (BattleLandCorrectData) null;
    }

    [Token(Token = "0x60055F1")]
    [Address(RVA = "0x3E2FD6C", Offset = "0x3E2FD6C", VA = "0x3E2FD6C")]
    public BattleLandCorrectData GetByLandform(int typeId) => (BattleLandCorrectData) null;

    [Token(Token = "0x60055F2")]
    [Address(RVA = "0x3E2FDDC", Offset = "0x3E2FDDC", VA = "0x3E2FDDC")]
    public BattleLandCorrectMaster()
    {
    }
  }
}
