// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBoxMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F9B")]
  [Serializable]
  public sealed class ExpeditionBoxMaster : BaseMaster<ExpeditionBoxData>
  {
    [Token(Token = "0x6005BB1")]
    [Address(RVA = "0x278589C", Offset = "0x278589C", VA = "0x278589C")]
    public IReadOnlyDictionary<int, ExpeditionBoxData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBoxData>) null;
    }

    [Token(Token = "0x6005BB2")]
    [Address(RVA = "0x27858A4", Offset = "0x27858A4", VA = "0x27858A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BB3")]
    [Address(RVA = "0x2785904", Offset = "0x2785904", VA = "0x2785904", Slot = "5")]
    protected override ExpeditionBoxData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBoxData) null;
    }

    [Token(Token = "0x6005BB4")]
    [Address(RVA = "0x278595C", Offset = "0x278595C", VA = "0x278595C")]
    public ExpeditionBoxMaster()
    {
    }
  }
}
