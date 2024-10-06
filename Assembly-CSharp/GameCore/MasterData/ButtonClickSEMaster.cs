// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ButtonClickSEMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E81")]
  [Serializable]
  public sealed class ButtonClickSEMaster : BaseMaster<ButtonClickSEData>
  {
    [Token(Token = "0x600585D")]
    [Address(RVA = "0x3E48570", Offset = "0x3E48570", VA = "0x3E48570")]
    public IReadOnlyDictionary<int, ButtonClickSEData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ButtonClickSEData>) null;
    }

    [Token(Token = "0x600585E")]
    [Address(RVA = "0x3E48578", Offset = "0x3E48578", VA = "0x3E48578", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600585F")]
    [Address(RVA = "0x3E485D8", Offset = "0x3E485D8", VA = "0x3E485D8", Slot = "5")]
    protected override ButtonClickSEData LoadEntity(IMasterDataReader reader)
    {
      return (ButtonClickSEData) null;
    }

    [Token(Token = "0x6005860")]
    [Address(RVA = "0x3E48630", Offset = "0x3E48630", VA = "0x3E48630")]
    public ButtonClickSEMaster()
    {
    }
  }
}
