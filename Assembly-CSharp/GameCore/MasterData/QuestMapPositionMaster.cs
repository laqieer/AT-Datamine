// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestMapPositionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001128")]
  [Serializable]
  public sealed class QuestMapPositionMaster : BaseMaster<QuestMapPositionData>
  {
    [Token(Token = "0x60062C0")]
    [Address(RVA = "0x4AE2738", Offset = "0x4AE2738", VA = "0x4AE2738")]
    public IReadOnlyDictionary<int, QuestMapPositionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, QuestMapPositionData>) null;
    }

    [Token(Token = "0x60062C1")]
    [Address(RVA = "0x4AE2740", Offset = "0x4AE2740", VA = "0x4AE2740", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062C2")]
    [Address(RVA = "0x4AE27A0", Offset = "0x4AE27A0", VA = "0x4AE27A0", Slot = "5")]
    protected override QuestMapPositionData LoadEntity(IMasterDataReader reader)
    {
      return (QuestMapPositionData) null;
    }

    [Token(Token = "0x60062C3")]
    [Address(RVA = "0x4AE27F8", Offset = "0x4AE27F8", VA = "0x4AE27F8")]
    public QuestMapPositionMaster()
    {
    }
  }
}
