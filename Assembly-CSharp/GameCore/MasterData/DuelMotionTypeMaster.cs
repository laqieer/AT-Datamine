// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DuelMotionTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EE2")]
  [Serializable]
  public sealed class DuelMotionTypeMaster : BaseMaster<DuelMotionTypeData>
  {
    [Token(Token = "0x6005951")]
    [Address(RVA = "0x3C316F0", Offset = "0x3C316F0", VA = "0x3C316F0")]
    public IReadOnlyDictionary<int, DuelMotionTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, DuelMotionTypeData>) null;
    }

    [Token(Token = "0x6005952")]
    [Address(RVA = "0x3C316F8", Offset = "0x3C316F8", VA = "0x3C316F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005953")]
    [Address(RVA = "0x3C31758", Offset = "0x3C31758", VA = "0x3C31758", Slot = "5")]
    protected override DuelMotionTypeData LoadEntity(IMasterDataReader reader)
    {
      return (DuelMotionTypeData) null;
    }

    [Token(Token = "0x6005954")]
    [Address(RVA = "0x3C317B0", Offset = "0x3C317B0", VA = "0x3C317B0")]
    public Dictionary<int, DuelMotionTypeData>.ValueCollection GetList()
    {
      return (Dictionary<int, DuelMotionTypeData>.ValueCollection) null;
    }

    [Token(Token = "0x6005955")]
    [Address(RVA = "0x3C31800", Offset = "0x3C31800", VA = "0x3C31800")]
    public DuelMotionTypeMaster()
    {
    }
  }
}
