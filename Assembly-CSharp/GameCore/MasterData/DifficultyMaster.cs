// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DifficultyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001112")]
  [Serializable]
  public sealed class DifficultyMaster : BaseMaster<DifficultyData>
  {
    [Token(Token = "0x600624F")]
    [Address(RVA = "0x4ADE40C", Offset = "0x4ADE40C", VA = "0x4ADE40C")]
    public IReadOnlyDictionary<int, DifficultyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, DifficultyData>) null;
    }

    [Token(Token = "0x6006250")]
    [Address(RVA = "0x4ADE414", Offset = "0x4ADE414", VA = "0x4ADE414", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006251")]
    [Address(RVA = "0x4ADE474", Offset = "0x4ADE474", VA = "0x4ADE474", Slot = "5")]
    protected override DifficultyData LoadEntity(IMasterDataReader reader) => (DifficultyData) null;

    [Token(Token = "0x6006252")]
    [Address(RVA = "0x4ADE4CC", Offset = "0x4ADE4CC", VA = "0x4ADE4CC")]
    public DifficultyMaster()
    {
    }
  }
}
