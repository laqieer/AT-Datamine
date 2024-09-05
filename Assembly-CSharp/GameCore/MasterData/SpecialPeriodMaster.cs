// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpecialPeriodMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001144")]
  [Serializable]
  public sealed class SpecialPeriodMaster : BaseMaster<SpecialPeriodData>
  {
    [Token(Token = "0x6006345")]
    [Address(RVA = "0x4AE6A08", Offset = "0x4AE6A08", VA = "0x4AE6A08")]
    public IReadOnlyDictionary<int, SpecialPeriodData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SpecialPeriodData>) null;
    }

    [Token(Token = "0x6006346")]
    [Address(RVA = "0x4AE6A10", Offset = "0x4AE6A10", VA = "0x4AE6A10", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006347")]
    [Address(RVA = "0x4AE6A70", Offset = "0x4AE6A70", VA = "0x4AE6A70", Slot = "5")]
    protected override SpecialPeriodData LoadEntity(IMasterDataReader reader)
    {
      return (SpecialPeriodData) null;
    }

    [Token(Token = "0x6006348")]
    [Address(RVA = "0x4AE6AE0", Offset = "0x4AE6AE0", VA = "0x4AE6AE0")]
    private void OnLoadEntity(SpecialPeriodData entity)
    {
    }

    [Token(Token = "0x6006349")]
    [Address(RVA = "0x4AE6B34", Offset = "0x4AE6B34", VA = "0x4AE6B34")]
    public SpecialPeriodData GetReleasedPeriod(DateTime? datetime = null)
    {
      return (SpecialPeriodData) null;
    }

    [Token(Token = "0x600634A")]
    [Address(RVA = "0x4AE6E14", Offset = "0x4AE6E14", VA = "0x4AE6E14")]
    public SpecialPeriodData GetReleasedPeriod(int periodId, DateTime? datetime = null)
    {
      return (SpecialPeriodData) null;
    }

    [Token(Token = "0x600634B")]
    [Address(RVA = "0x4AE6AE4", Offset = "0x4AE6AE4", VA = "0x4AE6AE4")]
    private void OverwriteDefault(SpecialPeriodData entity)
    {
    }

    [Token(Token = "0x17000EE5")]
    private DateTime DefaultDateTime
    {
      [Token(Token = "0x600634C"), Address(RVA = "0x4AE7124", Offset = "0x4AE7124", VA = "0x4AE7124")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600634D")]
    [Address(RVA = "0x4AE7098", Offset = "0x4AE7098", VA = "0x4AE7098")]
    private bool CheckDefault(in DateTime value) => new bool();

    [Token(Token = "0x600634E")]
    [Address(RVA = "0x4AE712C", Offset = "0x4AE712C", VA = "0x4AE712C")]
    public SpecialPeriodMaster()
    {
    }
  }
}
