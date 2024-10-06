// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LpRecoveryPaymentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200136E")]
  [Serializable]
  public sealed class LpRecoveryPaymentMaster : BaseMaster<LpRecoveryPaymentData>
  {
    [Token(Token = "0x6006D62")]
    [Address(RVA = "0x46FC530", Offset = "0x46FC530", VA = "0x46FC530")]
    public IReadOnlyDictionary<int, LpRecoveryPaymentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LpRecoveryPaymentData>) null;
    }

    [Token(Token = "0x6006D63")]
    [Address(RVA = "0x46FC538", Offset = "0x46FC538", VA = "0x46FC538", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D64")]
    [Address(RVA = "0x46FC598", Offset = "0x46FC598", VA = "0x46FC598", Slot = "5")]
    protected override LpRecoveryPaymentData LoadEntity(IMasterDataReader reader)
    {
      return (LpRecoveryPaymentData) null;
    }

    [Token(Token = "0x6006D65")]
    [Address(RVA = "0x46FC5F0", Offset = "0x46FC5F0", VA = "0x46FC5F0")]
    public LpRecoveryPaymentMaster()
    {
    }
  }
}
