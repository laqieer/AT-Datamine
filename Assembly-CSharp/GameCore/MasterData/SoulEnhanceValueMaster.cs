// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SoulEnhanceValueMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E9E")]
  [Serializable]
  public sealed class SoulEnhanceValueMaster : BaseMaster<SoulEnhanceValueData>
  {
    [Token(Token = "0x40046AD")]
    private const int SOUL_ENHANCE_ID = 1;

    [Token(Token = "0x60058E6")]
    [Address(RVA = "0x3C2E970", Offset = "0x3C2E970", VA = "0x3C2E970")]
    public IReadOnlyDictionary<int, SoulEnhanceValueData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SoulEnhanceValueData>) null;
    }

    [Token(Token = "0x60058E7")]
    [Address(RVA = "0x3C2E978", Offset = "0x3C2E978", VA = "0x3C2E978", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058E8")]
    [Address(RVA = "0x3C2E9D8", Offset = "0x3C2E9D8", VA = "0x3C2E9D8", Slot = "5")]
    protected override SoulEnhanceValueData LoadEntity(IMasterDataReader reader)
    {
      return (SoulEnhanceValueData) null;
    }

    [Token(Token = "0x60058E9")]
    [Address(RVA = "0x3C2EA30", Offset = "0x3C2EA30", VA = "0x3C2EA30")]
    public IReadOnlyCollection<SoulEnhanceValueData> GetList()
    {
      return (IReadOnlyCollection<SoulEnhanceValueData>) null;
    }

    [Token(Token = "0x60058EA")]
    [Address(RVA = "0x3C2EA80", Offset = "0x3C2EA80", VA = "0x3C2EA80")]
    public int GetStyleEnhance() => new int();

    [Token(Token = "0x60058EB")]
    [Address(RVA = "0x3C2EAE0", Offset = "0x3C2EAE0", VA = "0x3C2EAE0")]
    public int GetMindEquipmentEnhance() => new int();

    [Token(Token = "0x60058EC")]
    [Address(RVA = "0x3C2EB40", Offset = "0x3C2EB40", VA = "0x3C2EB40")]
    public int GetWeaponEnhance() => new int();

    [Token(Token = "0x60058ED")]
    [Address(RVA = "0x3C2EBA0", Offset = "0x3C2EBA0", VA = "0x3C2EBA0")]
    public int GetAccessoryEnhance() => new int();

    [Token(Token = "0x60058EE")]
    [Address(RVA = "0x3C2EC00", Offset = "0x3C2EC00", VA = "0x3C2EC00")]
    public SoulEnhanceValueMaster()
    {
    }
  }
}
