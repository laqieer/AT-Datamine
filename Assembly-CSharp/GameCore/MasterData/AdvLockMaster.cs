// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvLockMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB7")]
  [Serializable]
  public sealed class AdvLockMaster : BaseMaster<AdvLockData>
  {
    [Token(Token = "0x60053E7")]
    [Address(RVA = "0x3A9F01C", Offset = "0x3A9F01C", VA = "0x3A9F01C")]
    public IReadOnlyDictionary<int, AdvLockData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvLockData>) null;
    }

    [Token(Token = "0x60053E8")]
    [Address(RVA = "0x3A9F024", Offset = "0x3A9F024", VA = "0x3A9F024", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053E9")]
    [Address(RVA = "0x3A9F084", Offset = "0x3A9F084", VA = "0x3A9F084", Slot = "5")]
    protected override AdvLockData LoadEntity(IMasterDataReader reader) => (AdvLockData) null;

    [Token(Token = "0x60053EA")]
    [Address(RVA = "0x3A9F0DC", Offset = "0x3A9F0DC", VA = "0x3A9F0DC")]
    public AdvLockMaster()
    {
    }
  }
}
