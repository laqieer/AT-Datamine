// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PanelMissionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010AB")]
  [Serializable]
  public sealed class PanelMissionMaster : BaseMaster<PanelMissionData>
  {
    [Token(Token = "0x6006072")]
    [Address(RVA = "0x28D773C", Offset = "0x28D773C", VA = "0x28D773C")]
    public IReadOnlyDictionary<int, PanelMissionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PanelMissionData>) null;
    }

    [Token(Token = "0x6006073")]
    [Address(RVA = "0x28D7744", Offset = "0x28D7744", VA = "0x28D7744", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006074")]
    [Address(RVA = "0x28D77A4", Offset = "0x28D77A4", VA = "0x28D77A4", Slot = "5")]
    protected override PanelMissionData LoadEntity(IMasterDataReader reader)
    {
      return (PanelMissionData) null;
    }

    [Token(Token = "0x6006075")]
    [Address(RVA = "0x28D77FC", Offset = "0x28D77FC", VA = "0x28D77FC")]
    public PanelMissionMaster()
    {
    }
  }
}
