// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionBattleEnterLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001248")]
  [Serializable]
  public sealed class StoryFreeActionBattleEnterLayoutMaster : 
    BaseMaster<StoryFreeActionBattleEnterLayoutData>
  {
    [Token(Token = "0x60067FC")]
    [Address(RVA = "0x4D34A7C", Offset = "0x4D34A7C", VA = "0x4D34A7C")]
    public IReadOnlyDictionary<int, StoryFreeActionBattleEnterLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionBattleEnterLayoutData>) null;
    }

    [Token(Token = "0x60067FD")]
    [Address(RVA = "0x4D34A84", Offset = "0x4D34A84", VA = "0x4D34A84", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067FE")]
    [Address(RVA = "0x4D34AE4", Offset = "0x4D34AE4", VA = "0x4D34AE4", Slot = "5")]
    protected override StoryFreeActionBattleEnterLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionBattleEnterLayoutData) null;
    }

    [Token(Token = "0x60067FF")]
    [Address(RVA = "0x4D34B3C", Offset = "0x4D34B3C", VA = "0x4D34B3C")]
    public IEnumerable<StoryFreeActionBattleEnterLayoutData> GetList()
    {
      return (IEnumerable<StoryFreeActionBattleEnterLayoutData>) null;
    }

    [Token(Token = "0x6006800")]
    [Address(RVA = "0x4D34B8C", Offset = "0x4D34B8C", VA = "0x4D34B8C")]
    public StoryFreeActionBattleEnterLayoutMaster()
    {
    }
  }
}
