// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ReincarnationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013AA")]
  [Serializable]
  public sealed class ReincarnationMaster : BaseMaster<ReincarnationData>
  {
    [Token(Token = "0x6006E72")]
    [Address(RVA = "0x47059A0", Offset = "0x47059A0", VA = "0x47059A0")]
    public IReadOnlyDictionary<int, ReincarnationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ReincarnationData>) null;
    }

    [Token(Token = "0x6006E73")]
    [Address(RVA = "0x47059A8", Offset = "0x47059A8", VA = "0x47059A8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E74")]
    [Address(RVA = "0x4705A08", Offset = "0x4705A08", VA = "0x4705A08", Slot = "5")]
    protected override ReincarnationData LoadEntity(IMasterDataReader reader)
    {
      return (ReincarnationData) null;
    }

    [Token(Token = "0x6006E75")]
    [Address(RVA = "0x4705A60", Offset = "0x4705A60", VA = "0x4705A60")]
    public ReincarnationMaster()
    {
    }
  }
}
