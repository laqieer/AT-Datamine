// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB5")]
  [Serializable]
  public sealed class ExpeditionStageMaster : BaseMaster<ExpeditionStageData>
  {
    [Token(Token = "0x4004F0C")]
    public const string TEXT_AB = "text_masterdata_expedition";

    [Token(Token = "0x6005C2A")]
    [Address(RVA = "0x2789AE0", Offset = "0x2789AE0", VA = "0x2789AE0")]
    public IReadOnlyDictionary<int, ExpeditionStageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionStageData>) null;
    }

    [Token(Token = "0x6005C2B")]
    [Address(RVA = "0x2789AE8", Offset = "0x2789AE8", VA = "0x2789AE8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C2C")]
    [Address(RVA = "0x2789B48", Offset = "0x2789B48", VA = "0x2789B48", Slot = "5")]
    protected override ExpeditionStageData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionStageData) null;
    }

    [Token(Token = "0x6005C2D")]
    [Address(RVA = "0x2789BA0", Offset = "0x2789BA0", VA = "0x2789BA0")]
    public ExpeditionStageMaster()
    {
    }
  }
}
