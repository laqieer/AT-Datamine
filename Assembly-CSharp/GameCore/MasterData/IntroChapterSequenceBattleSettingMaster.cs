// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceBattleSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001030")]
  [Serializable]
  public sealed class IntroChapterSequenceBattleSettingMaster : 
    BaseMaster<IntroChapterSequenceBattleSettingData>
  {
    [Token(Token = "0x6005E24")]
    [Address(RVA = "0x279A0F4", Offset = "0x279A0F4", VA = "0x279A0F4")]
    public IReadOnlyDictionary<int, IntroChapterSequenceBattleSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IntroChapterSequenceBattleSettingData>) null;
    }

    [Token(Token = "0x6005E25")]
    [Address(RVA = "0x279A0FC", Offset = "0x279A0FC", VA = "0x279A0FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E26")]
    [Address(RVA = "0x279A15C", Offset = "0x279A15C", VA = "0x279A15C", Slot = "5")]
    protected override IntroChapterSequenceBattleSettingData LoadEntity(IMasterDataReader reader)
    {
      return (IntroChapterSequenceBattleSettingData) null;
    }

    [Token(Token = "0x6005E27")]
    [Address(RVA = "0x279A1B4", Offset = "0x279A1B4", VA = "0x279A1B4")]
    public IntroChapterSequenceBattleSettingMaster()
    {
    }
  }
}
