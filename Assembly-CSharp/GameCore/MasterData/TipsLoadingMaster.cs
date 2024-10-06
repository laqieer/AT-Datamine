// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TipsLoadingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA4")]
  [Serializable]
  public sealed class TipsLoadingMaster : BaseMaster<TipsLoadingData>
  {
    [Token(Token = "0x6005905")]
    [Address(RVA = "0x3C2F720", Offset = "0x3C2F720", VA = "0x3C2F720")]
    public IReadOnlyDictionary<int, TipsLoadingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TipsLoadingData>) null;
    }

    [Token(Token = "0x6005906")]
    [Address(RVA = "0x3C2F728", Offset = "0x3C2F728", VA = "0x3C2F728", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005907")]
    [Address(RVA = "0x3C2F788", Offset = "0x3C2F788", VA = "0x3C2F788", Slot = "5")]
    protected override TipsLoadingData LoadEntity(IMasterDataReader reader)
    {
      return (TipsLoadingData) null;
    }

    [Token(Token = "0x6005908")]
    [Address(RVA = "0x3C2F7E0", Offset = "0x3C2F7E0", VA = "0x3C2F7E0")]
    public TipsLoadingMaster()
    {
    }
  }
}
