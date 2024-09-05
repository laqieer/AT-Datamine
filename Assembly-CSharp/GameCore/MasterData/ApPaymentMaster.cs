// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ApPaymentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B8")]
  [Serializable]
  public sealed class ApPaymentMaster : BaseMaster<ApPaymentData>
  {
    [Token(Token = "0x60060AF")]
    [Address(RVA = "0x28D99E0", Offset = "0x28D99E0", VA = "0x28D99E0")]
    public IReadOnlyDictionary<int, ApPaymentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ApPaymentData>) null;
    }

    [Token(Token = "0x60060B0")]
    [Address(RVA = "0x28D99E8", Offset = "0x28D99E8", VA = "0x28D99E8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060B1")]
    [Address(RVA = "0x28D9A48", Offset = "0x28D9A48", VA = "0x28D9A48", Slot = "5")]
    protected override ApPaymentData LoadEntity(IMasterDataReader reader) => (ApPaymentData) null;

    [Token(Token = "0x60060B2")]
    [Address(RVA = "0x28D9AA0", Offset = "0x28D9AA0", VA = "0x28D9AA0")]
    public ApPaymentData GetDataByRecoveryItemId(int recoveryItemId) => (ApPaymentData) null;

    [Token(Token = "0x60060B3")]
    [Address(RVA = "0x28D9C24", Offset = "0x28D9C24", VA = "0x28D9C24")]
    public ApPaymentMaster()
    {
    }
  }
}
