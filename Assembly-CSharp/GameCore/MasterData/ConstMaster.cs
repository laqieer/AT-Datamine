// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E89")]
  [Serializable]
  public sealed class ConstMaster : BaseMaster<ConstData>
  {
    [Token(Token = "0x600587B")]
    [Address(RVA = "0x3E49484", Offset = "0x3E49484", VA = "0x3E49484")]
    public IReadOnlyDictionary<int, ConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ConstData>) null;
    }

    [Token(Token = "0x600587C")]
    [Address(RVA = "0x3E4948C", Offset = "0x3E4948C", VA = "0x3E4948C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600587D")]
    [Address(RVA = "0x3E49568", Offset = "0x3E49568", VA = "0x3E49568", Slot = "5")]
    protected override ConstData LoadEntity(IMasterDataReader reader) => (ConstData) null;

    [Token(Token = "0x600587E")]
    [Address(RVA = "0x3E494F4", Offset = "0x3E494F4", VA = "0x3E494F4")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000D26")]
    public ConstData Data
    {
      [Token(Token = "0x600587F"), Address(RVA = "0x3E495C0", Offset = "0x3E495C0", VA = "0x3E495C0")] get
      {
        return (ConstData) null;
      }
      [Token(Token = "0x6005880"), Address(RVA = "0x3E495C8", Offset = "0x3E495C8", VA = "0x3E495C8")] private set
      {
      }
    }

    [Token(Token = "0x6005881")]
    [Address(RVA = "0x3E495D0", Offset = "0x3E495D0", VA = "0x3E495D0")]
    public ConstMaster()
    {
    }
  }
}
