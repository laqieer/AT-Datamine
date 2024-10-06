// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EpItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200104F")]
  [Serializable]
  public sealed class EpItemMaster : BaseMaster<EpItemData>
  {
    [Token(Token = "0x40050CE")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005EB6")]
    [Address(RVA = "0x28C6AF4", Offset = "0x28C6AF4", VA = "0x28C6AF4")]
    public IReadOnlyDictionary<int, EpItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EpItemData>) null;
    }

    [Token(Token = "0x6005EB7")]
    [Address(RVA = "0x28C6AFC", Offset = "0x28C6AFC", VA = "0x28C6AFC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EB8")]
    [Address(RVA = "0x28C6B5C", Offset = "0x28C6B5C", VA = "0x28C6B5C", Slot = "5")]
    protected override EpItemData LoadEntity(IMasterDataReader reader) => (EpItemData) null;

    [Token(Token = "0x6005EB9")]
    [Address(RVA = "0x28C6BB4", Offset = "0x28C6BB4", VA = "0x28C6BB4")]
    public EpItemMaster()
    {
    }
  }
}
