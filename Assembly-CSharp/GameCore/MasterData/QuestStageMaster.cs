// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestStageMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200112A")]
  [Serializable]
  public sealed class QuestStageMaster : BaseMaster<QuestStageData>, IQuestStageMaster
  {
    [Token(Token = "0x60062C9")]
    [Address(RVA = "0x4AE2C10", Offset = "0x4AE2C10", VA = "0x4AE2C10")]
    public IReadOnlyDictionary<int, QuestStageData> GetEntities()
    {
      return (IReadOnlyDictionary<int, QuestStageData>) null;
    }

    [Token(Token = "0x60062CA")]
    [Address(RVA = "0x4AE2C18", Offset = "0x4AE2C18", VA = "0x4AE2C18", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062CB")]
    [Address(RVA = "0x4AE2C78", Offset = "0x4AE2C78", VA = "0x4AE2C78", Slot = "5")]
    protected override QuestStageData LoadEntity(IMasterDataReader reader) => (QuestStageData) null;

    [Token(Token = "0x60062CC")]
    [Address(RVA = "0x4AE2CD0", Offset = "0x4AE2CD0", VA = "0x4AE2CD0", Slot = "6")]
    public IQuestStage GetStage(int id) => (IQuestStage) null;

    [Token(Token = "0x60062CD")]
    [Address(RVA = "0x4AE2D28", Offset = "0x4AE2D28", VA = "0x4AE2D28")]
    public QuestStageMaster()
    {
    }
  }
}
