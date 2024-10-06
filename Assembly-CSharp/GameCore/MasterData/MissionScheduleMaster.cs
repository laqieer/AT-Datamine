// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionScheduleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A3")]
  [Serializable]
  public sealed class MissionScheduleMaster : BaseMaster<MissionScheduleData>
  {
    [Token(Token = "0x600604F")]
    [Address(RVA = "0x28D6338", Offset = "0x28D6338", VA = "0x28D6338")]
    public IReadOnlyDictionary<int, MissionScheduleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionScheduleData>) null;
    }

    [Token(Token = "0x6006050")]
    [Address(RVA = "0x28D6340", Offset = "0x28D6340", VA = "0x28D6340", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006051")]
    [Address(RVA = "0x28D63A0", Offset = "0x28D63A0", VA = "0x28D63A0", Slot = "5")]
    protected override MissionScheduleData LoadEntity(IMasterDataReader reader)
    {
      return (MissionScheduleData) null;
    }

    [Token(Token = "0x6006052")]
    [Address(RVA = "0x28D63F8", Offset = "0x28D63F8", VA = "0x28D63F8")]
    public MissionScheduleMaster()
    {
    }
  }
}
