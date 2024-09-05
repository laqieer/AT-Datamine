// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionTabMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B6")]
  [Serializable]
  public sealed class TotalMissionTabMaster : BaseMaster<TotalMissionTabData>
  {
    [Token(Token = "0x4005232")]
    public const string TEXT_AB = "text_masterdata_mission";

    [Token(Token = "0x60060A6")]
    [Address(RVA = "0x28D95EC", Offset = "0x28D95EC", VA = "0x28D95EC")]
    public IReadOnlyDictionary<int, TotalMissionTabData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TotalMissionTabData>) null;
    }

    [Token(Token = "0x60060A7")]
    [Address(RVA = "0x28D95F4", Offset = "0x28D95F4", VA = "0x28D95F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060A8")]
    [Address(RVA = "0x28D9654", Offset = "0x28D9654", VA = "0x28D9654", Slot = "5")]
    protected override TotalMissionTabData LoadEntity(IMasterDataReader reader)
    {
      return (TotalMissionTabData) null;
    }

    [Token(Token = "0x60060A9")]
    [Address(RVA = "0x28D96AC", Offset = "0x28D96AC", VA = "0x28D96AC")]
    public TotalMissionTabMaster()
    {
    }
  }
}
