// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvLockOneMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB4")]
  [Serializable]
  public sealed class AdvLockOneMaster : BaseMaster<AdvLockOneData>
  {
    [Token(Token = "0x40041A2")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AdvLockOneData>> lockTable;

    [Token(Token = "0x60053D5")]
    [Address(RVA = "0x3A9DFC8", Offset = "0x3A9DFC8", VA = "0x3A9DFC8")]
    public IReadOnlyDictionary<int, AdvLockOneData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvLockOneData>) null;
    }

    [Token(Token = "0x60053D6")]
    [Address(RVA = "0x3A9DFD0", Offset = "0x3A9DFD0", VA = "0x3A9DFD0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053D7")]
    [Address(RVA = "0x3A9E2E0", Offset = "0x3A9E2E0", VA = "0x3A9E2E0", Slot = "5")]
    protected override AdvLockOneData LoadEntity(IMasterDataReader reader) => (AdvLockOneData) null;

    [Token(Token = "0x60053D8")]
    [Address(RVA = "0x3A9E040", Offset = "0x3A9E040", VA = "0x3A9E040")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60053D9")]
    [Address(RVA = "0x3A9E350", Offset = "0x3A9E350", VA = "0x3A9E350")]
    private void OnLoadEntity(AdvLockOneData entity)
    {
    }

    [Token(Token = "0x60053DA")]
    [Address(RVA = "0x3A9E090", Offset = "0x3A9E090", VA = "0x3A9E090")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x60053DB")]
    [Address(RVA = "0x3A9E4CC", Offset = "0x3A9E4CC", VA = "0x3A9E4CC")]
    public List<AdvLockOneData> GetLockOrderTable(int lockID) => (List<AdvLockOneData>) null;

    [Token(Token = "0x60053DC")]
    [Address(RVA = "0x3A9E588", Offset = "0x3A9E588", VA = "0x3A9E588")]
    public AdvLockOneMaster()
    {
    }
  }
}
