// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionEffectSpriteMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F81")]
  [Serializable]
  public sealed class WeaponOptionEffectSpriteMaster : BaseMaster<WeaponOptionEffectSpriteData>
  {
    [Token(Token = "0x6005B33")]
    [Address(RVA = "0x278064C", Offset = "0x278064C", VA = "0x278064C")]
    public IReadOnlyDictionary<int, WeaponOptionEffectSpriteData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponOptionEffectSpriteData>) null;
    }

    [Token(Token = "0x6005B34")]
    [Address(RVA = "0x2780654", Offset = "0x2780654", VA = "0x2780654", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B35")]
    [Address(RVA = "0x27806B4", Offset = "0x27806B4", VA = "0x27806B4", Slot = "5")]
    protected override WeaponOptionEffectSpriteData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponOptionEffectSpriteData) null;
    }

    [Token(Token = "0x6005B36")]
    [Address(RVA = "0x278070C", Offset = "0x278070C", VA = "0x278070C")]
    public WeaponOptionEffectSpriteMaster()
    {
    }
  }
}
