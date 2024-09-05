// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvExpandedLockMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DAE")]
  [Serializable]
  public sealed class AdvExpandedLockMaster : BaseMaster<AdvExpandedLockData>
  {
    [Token(Token = "0x60053BD")]
    [Address(RVA = "0x3A9D1A8", Offset = "0x3A9D1A8", VA = "0x3A9D1A8")]
    public IReadOnlyDictionary<int, AdvExpandedLockData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvExpandedLockData>) null;
    }

    [Token(Token = "0x60053BE")]
    [Address(RVA = "0x3A9D1B0", Offset = "0x3A9D1B0", VA = "0x3A9D1B0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053BF")]
    [Address(RVA = "0x3A9D210", Offset = "0x3A9D210", VA = "0x3A9D210", Slot = "5")]
    protected override AdvExpandedLockData LoadEntity(IMasterDataReader reader)
    {
      return (AdvExpandedLockData) null;
    }

    [Token(Token = "0x60053C0")]
    [Address(RVA = "0x3A9D268", Offset = "0x3A9D268", VA = "0x3A9D268")]
    public AdvExpandedLockMaster()
    {
    }
  }
}
