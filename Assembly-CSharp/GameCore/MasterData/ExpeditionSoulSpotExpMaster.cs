// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionSoulSpotExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA7")]
  [Serializable]
  public sealed class ExpeditionSoulSpotExpMaster : BaseMaster<ExpeditionSoulSpotExpData>
  {
    [Token(Token = "0x6005BE5")]
    [Address(RVA = "0x2787114", Offset = "0x2787114", VA = "0x2787114")]
    public IReadOnlyDictionary<int, ExpeditionSoulSpotExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionSoulSpotExpData>) null;
    }

    [Token(Token = "0x6005BE6")]
    [Address(RVA = "0x278711C", Offset = "0x278711C", VA = "0x278711C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BE7")]
    [Address(RVA = "0x278717C", Offset = "0x278717C", VA = "0x278717C", Slot = "5")]
    protected override ExpeditionSoulSpotExpData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionSoulSpotExpData) null;
    }

    [Token(Token = "0x6005BE8")]
    [Address(RVA = "0x27871D4", Offset = "0x27871D4", VA = "0x27871D4")]
    public ExpeditionSoulSpotExpMaster()
    {
    }
  }
}
