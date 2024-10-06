// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B4")]
  [Serializable]
  public sealed class TotalMissionRewardMaster : BaseMaster<TotalMissionRewardData>
  {
    [Token(Token = "0x600609E")]
    [Address(RVA = "0x28D9340", Offset = "0x28D9340", VA = "0x28D9340")]
    public IReadOnlyDictionary<int, TotalMissionRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TotalMissionRewardData>) null;
    }

    [Token(Token = "0x600609F")]
    [Address(RVA = "0x28D9348", Offset = "0x28D9348", VA = "0x28D9348", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060A0")]
    [Address(RVA = "0x28D93A8", Offset = "0x28D93A8", VA = "0x28D93A8", Slot = "5")]
    protected override TotalMissionRewardData LoadEntity(IMasterDataReader reader)
    {
      return (TotalMissionRewardData) null;
    }

    [Token(Token = "0x60060A1")]
    [Address(RVA = "0x28D9400", Offset = "0x28D9400", VA = "0x28D9400")]
    public TotalMissionRewardMaster()
    {
    }
  }
}
