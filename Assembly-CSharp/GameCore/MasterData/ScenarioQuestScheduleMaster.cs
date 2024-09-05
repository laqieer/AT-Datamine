// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScenarioQuestScheduleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001130")]
  [Serializable]
  public sealed class ScenarioQuestScheduleMaster : BaseMaster<ScenarioQuestScheduleData>
  {
    [Token(Token = "0x60062F1")]
    [Address(RVA = "0x4AE3E7C", Offset = "0x4AE3E7C", VA = "0x4AE3E7C")]
    public IReadOnlyDictionary<int, ScenarioQuestScheduleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScenarioQuestScheduleData>) null;
    }

    [Token(Token = "0x60062F2")]
    [Address(RVA = "0x4AE3E84", Offset = "0x4AE3E84", VA = "0x4AE3E84", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062F3")]
    [Address(RVA = "0x4AE3EE4", Offset = "0x4AE3EE4", VA = "0x4AE3EE4", Slot = "5")]
    protected override ScenarioQuestScheduleData LoadEntity(IMasterDataReader reader)
    {
      return (ScenarioQuestScheduleData) null;
    }

    [Token(Token = "0x60062F4")]
    [Address(RVA = "0x4AE3F3C", Offset = "0x4AE3F3C", VA = "0x4AE3F3C")]
    public ScenarioQuestScheduleMaster()
    {
    }
  }
}
