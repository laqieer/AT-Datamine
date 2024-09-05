// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PreHomeEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010E4")]
  [Serializable]
  public sealed class PreHomeEventMaster : BaseMaster<PreHomeEventData>
  {
    [Token(Token = "0x600617B")]
    [Address(RVA = "0x28E0E6C", Offset = "0x28E0E6C", VA = "0x28E0E6C")]
    public IReadOnlyDictionary<int, PreHomeEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PreHomeEventData>) null;
    }

    [Token(Token = "0x600617C")]
    [Address(RVA = "0x28E0E74", Offset = "0x28E0E74", VA = "0x28E0E74", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600617D")]
    [Address(RVA = "0x28E0ED4", Offset = "0x28E0ED4", VA = "0x28E0ED4", Slot = "5")]
    protected override PreHomeEventData LoadEntity(IMasterDataReader reader)
    {
      return (PreHomeEventData) null;
    }

    [Token(Token = "0x600617E")]
    [Address(RVA = "0x28E0F2C", Offset = "0x28E0F2C", VA = "0x28E0F2C")]
    public PreHomeEventMaster()
    {
    }
  }
}
