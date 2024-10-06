// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200105F")]
  [Serializable]
  public sealed class MedalMaster : BaseMaster<MedalData>
  {
    [Token(Token = "0x4005117")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005F0D")]
    [Address(RVA = "0x28CA5A4", Offset = "0x28CA5A4", VA = "0x28CA5A4")]
    public IReadOnlyDictionary<int, MedalData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MedalData>) null;
    }

    [Token(Token = "0x6005F0E")]
    [Address(RVA = "0x28CA5AC", Offset = "0x28CA5AC", VA = "0x28CA5AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F0F")]
    [Address(RVA = "0x28CA60C", Offset = "0x28CA60C", VA = "0x28CA60C", Slot = "5")]
    protected override MedalData LoadEntity(IMasterDataReader reader) => (MedalData) null;

    [Token(Token = "0x6005F10")]
    [Address(RVA = "0x28CA664", Offset = "0x28CA664", VA = "0x28CA664")]
    public MedalData[] GetDataByMedalType(MedalTypeEnum medalType) => (MedalData[]) null;

    [Token(Token = "0x6005F11")]
    [Address(RVA = "0x28CA788", Offset = "0x28CA788", VA = "0x28CA788")]
    public MedalMaster()
    {
    }
  }
}
