// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FAD")]
  [Serializable]
  public sealed class ExpeditionStageDescriptionMaster : BaseMaster<ExpeditionStageDescriptionData>
  {
    [Token(Token = "0x6005BFD")]
    [Address(RVA = "0x2787E4C", Offset = "0x2787E4C", VA = "0x2787E4C")]
    public IReadOnlyDictionary<int, ExpeditionStageDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionStageDescriptionData>) null;
    }

    [Token(Token = "0x6005BFE")]
    [Address(RVA = "0x2787E54", Offset = "0x2787E54", VA = "0x2787E54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BFF")]
    [Address(RVA = "0x2787EB4", Offset = "0x2787EB4", VA = "0x2787EB4", Slot = "5")]
    protected override ExpeditionStageDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionStageDescriptionData) null;
    }

    [Token(Token = "0x6005C00")]
    [Address(RVA = "0x2787F0C", Offset = "0x2787F0C", VA = "0x2787F0C")]
    public ExpeditionStageDescriptionMaster()
    {
    }
  }
}
