// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleLogTextFormatMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E1C")]
  [Serializable]
  public sealed class BattleLogTextFormatMaster : BaseMaster<BattleLogTextFormatData>
  {
    [Token(Token = "0x60055FB")]
    [Address(RVA = "0x3E30984", Offset = "0x3E30984", VA = "0x3E30984")]
    public IReadOnlyDictionary<int, BattleLogTextFormatData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleLogTextFormatData>) null;
    }

    [Token(Token = "0x60055FC")]
    [Address(RVA = "0x3E3098C", Offset = "0x3E3098C", VA = "0x3E3098C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055FD")]
    [Address(RVA = "0x3E309EC", Offset = "0x3E309EC", VA = "0x3E309EC", Slot = "5")]
    protected override BattleLogTextFormatData LoadEntity(IMasterDataReader reader)
    {
      return (BattleLogTextFormatData) null;
    }

    [Token(Token = "0x60055FE")]
    [Address(RVA = "0x3E30A44", Offset = "0x3E30A44", VA = "0x3E30A44")]
    public BattleLogTextFormatMaster()
    {
    }
  }
}
