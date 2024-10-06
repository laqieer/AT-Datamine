// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestCorrectionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001126")]
  [Serializable]
  public sealed class QuestCorrectionMaster : BaseMaster<QuestCorrectionData>
  {
    [Token(Token = "0x4005376")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<QuestCorrectionData>> correctionDic;

    [Token(Token = "0x60062B6")]
    [Address(RVA = "0x4AE17A8", Offset = "0x4AE17A8", VA = "0x4AE17A8")]
    public IReadOnlyDictionary<int, QuestCorrectionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, QuestCorrectionData>) null;
    }

    [Token(Token = "0x60062B7")]
    [Address(RVA = "0x4AE17B0", Offset = "0x4AE17B0", VA = "0x4AE17B0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062B8")]
    [Address(RVA = "0x4AE1810", Offset = "0x4AE1810", VA = "0x4AE1810", Slot = "5")]
    protected override QuestCorrectionData LoadEntity(IMasterDataReader reader)
    {
      return (QuestCorrectionData) null;
    }

    [Token(Token = "0x60062B9")]
    [Address(RVA = "0x4AE1880", Offset = "0x4AE1880", VA = "0x4AE1880")]
    private void OnLoadEntity(QuestCorrectionData entity)
    {
    }

    [Token(Token = "0x60062BA")]
    [Address(RVA = "0x4AE19CC", Offset = "0x4AE19CC", VA = "0x4AE19CC")]
    public QuestCorrectionData GetData(int type, int value) => (QuestCorrectionData) null;

    [Token(Token = "0x60062BB")]
    [Address(RVA = "0x4AE1A88", Offset = "0x4AE1A88", VA = "0x4AE1A88")]
    public QuestCorrectionMaster()
    {
    }
  }
}
