// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeSeasonScheduleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001026")]
  [Serializable]
  public sealed class HomeSeasonScheduleMaster : BaseMaster<HomeSeasonScheduleData>
  {
    [Token(Token = "0x6005DF8")]
    [Address(RVA = "0x2798D04", Offset = "0x2798D04", VA = "0x2798D04")]
    public IReadOnlyDictionary<int, HomeSeasonScheduleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, HomeSeasonScheduleData>) null;
    }

    [Token(Token = "0x6005DF9")]
    [Address(RVA = "0x2798D0C", Offset = "0x2798D0C", VA = "0x2798D0C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DFA")]
    [Address(RVA = "0x2798D6C", Offset = "0x2798D6C", VA = "0x2798D6C", Slot = "5")]
    protected override HomeSeasonScheduleData LoadEntity(IMasterDataReader reader)
    {
      return (HomeSeasonScheduleData) null;
    }

    [Token(Token = "0x6005DFB")]
    [Address(RVA = "0x2798DC4", Offset = "0x2798DC4", VA = "0x2798DC4")]
    public HomeSeasonScheduleMaster()
    {
    }
  }
}
