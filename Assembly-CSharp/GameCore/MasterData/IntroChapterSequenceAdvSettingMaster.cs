// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceAdvSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200102E")]
  [Serializable]
  public sealed class IntroChapterSequenceAdvSettingMaster : 
    BaseMaster<IntroChapterSequenceAdvSettingData>
  {
    [Token(Token = "0x6005E1C")]
    [Address(RVA = "0x2799E4C", Offset = "0x2799E4C", VA = "0x2799E4C")]
    public IReadOnlyDictionary<int, IntroChapterSequenceAdvSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IntroChapterSequenceAdvSettingData>) null;
    }

    [Token(Token = "0x6005E1D")]
    [Address(RVA = "0x2799E54", Offset = "0x2799E54", VA = "0x2799E54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E1E")]
    [Address(RVA = "0x2799EB4", Offset = "0x2799EB4", VA = "0x2799EB4", Slot = "5")]
    protected override IntroChapterSequenceAdvSettingData LoadEntity(IMasterDataReader reader)
    {
      return (IntroChapterSequenceAdvSettingData) null;
    }

    [Token(Token = "0x6005E1F")]
    [Address(RVA = "0x2799F0C", Offset = "0x2799F0C", VA = "0x2799F0C")]
    public IntroChapterSequenceAdvSettingMaster()
    {
    }
  }
}
