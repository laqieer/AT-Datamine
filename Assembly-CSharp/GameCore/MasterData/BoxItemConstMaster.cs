// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BoxItemConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001042")]
  [Serializable]
  public sealed class BoxItemConstMaster : BaseMaster<BoxItemConstData>
  {
    [Token(Token = "0x6005E71")]
    [Address(RVA = "0x28C39F0", Offset = "0x28C39F0", VA = "0x28C39F0")]
    public IReadOnlyDictionary<int, BoxItemConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BoxItemConstData>) null;
    }

    [Token(Token = "0x6005E72")]
    [Address(RVA = "0x28C39F8", Offset = "0x28C39F8", VA = "0x28C39F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E73")]
    [Address(RVA = "0x28C3A58", Offset = "0x28C3A58", VA = "0x28C3A58", Slot = "5")]
    protected override BoxItemConstData LoadEntity(IMasterDataReader reader)
    {
      return (BoxItemConstData) null;
    }

    [Token(Token = "0x6005E74")]
    [Address(RVA = "0x28C3AB0", Offset = "0x28C3AB0", VA = "0x28C3AB0")]
    public BoxItemConstMaster()
    {
    }
  }
}
