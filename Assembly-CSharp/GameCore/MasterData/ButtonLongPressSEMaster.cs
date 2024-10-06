// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ButtonLongPressSEMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E84")]
  [Serializable]
  public sealed class ButtonLongPressSEMaster : BaseMaster<ButtonLongPressSEData>
  {
    [Token(Token = "0x6005865")]
    [Address(RVA = "0x3E4895C", Offset = "0x3E4895C", VA = "0x3E4895C")]
    public IReadOnlyDictionary<int, ButtonLongPressSEData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ButtonLongPressSEData>) null;
    }

    [Token(Token = "0x6005866")]
    [Address(RVA = "0x3E48964", Offset = "0x3E48964", VA = "0x3E48964", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005867")]
    [Address(RVA = "0x3E489C4", Offset = "0x3E489C4", VA = "0x3E489C4", Slot = "5")]
    protected override ButtonLongPressSEData LoadEntity(IMasterDataReader reader)
    {
      return (ButtonLongPressSEData) null;
    }

    [Token(Token = "0x6005868")]
    [Address(RVA = "0x3E48A1C", Offset = "0x3E48A1C", VA = "0x3E48A1C")]
    public ButtonLongPressSEMaster()
    {
    }
  }
}
