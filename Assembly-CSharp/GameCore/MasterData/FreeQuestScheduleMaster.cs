// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FreeQuestScheduleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001118")]
  [Serializable]
  public sealed class FreeQuestScheduleMaster : BaseMaster<FreeQuestScheduleData>
  {
    [Token(Token = "0x6006267")]
    [Address(RVA = "0x4ADEFD8", Offset = "0x4ADEFD8", VA = "0x4ADEFD8")]
    public IReadOnlyDictionary<int, FreeQuestScheduleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, FreeQuestScheduleData>) null;
    }

    [Token(Token = "0x6006268")]
    [Address(RVA = "0x4ADEFE0", Offset = "0x4ADEFE0", VA = "0x4ADEFE0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006269")]
    [Address(RVA = "0x4ADF040", Offset = "0x4ADF040", VA = "0x4ADF040", Slot = "5")]
    protected override FreeQuestScheduleData LoadEntity(IMasterDataReader reader)
    {
      return (FreeQuestScheduleData) null;
    }

    [Token(Token = "0x600626A")]
    [Address(RVA = "0x4ADF098", Offset = "0x4ADF098", VA = "0x4ADF098")]
    public FreeQuestScheduleMaster()
    {
    }
  }
}
