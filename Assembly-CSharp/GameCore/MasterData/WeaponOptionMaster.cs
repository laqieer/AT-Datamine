// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F85")]
  [Serializable]
  public sealed class WeaponOptionMaster : BaseMaster<WeaponOptionData>
  {
    [Token(Token = "0x6005B44")]
    [Address(RVA = "0x2780D90", Offset = "0x2780D90", VA = "0x2780D90")]
    public IReadOnlyDictionary<int, WeaponOptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponOptionData>) null;
    }

    [Token(Token = "0x6005B45")]
    [Address(RVA = "0x2780D98", Offset = "0x2780D98", VA = "0x2780D98", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B46")]
    [Address(RVA = "0x2780DF8", Offset = "0x2780DF8", VA = "0x2780DF8", Slot = "5")]
    protected override WeaponOptionData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponOptionData) null;
    }

    [Token(Token = "0x6005B47")]
    [Address(RVA = "0x2780E50", Offset = "0x2780E50", VA = "0x2780E50")]
    public int GetSpriteId(int id) => new int();

    [Token(Token = "0x6005B48")]
    [Address(RVA = "0x2780F30", Offset = "0x2780F30", VA = "0x2780F30")]
    public WeaponOptionMaster()
    {
    }
  }
}
