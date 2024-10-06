// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionEffectSpriteMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F3F")]
  [Serializable]
  public sealed class AccessoryOptionEffectSpriteMaster : BaseMaster<AccessoryOptionEffectSpriteData>
  {
    [Token(Token = "0x60059E4")]
    [Address(RVA = "0x3C39DEC", Offset = "0x3C39DEC", VA = "0x3C39DEC")]
    public IReadOnlyDictionary<int, AccessoryOptionEffectSpriteData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryOptionEffectSpriteData>) null;
    }

    [Token(Token = "0x60059E5")]
    [Address(RVA = "0x3C39DF4", Offset = "0x3C39DF4", VA = "0x3C39DF4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059E6")]
    [Address(RVA = "0x3C39E54", Offset = "0x3C39E54", VA = "0x3C39E54", Slot = "5")]
    protected override AccessoryOptionEffectSpriteData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryOptionEffectSpriteData) null;
    }

    [Token(Token = "0x60059E7")]
    [Address(RVA = "0x3C39EAC", Offset = "0x3C39EAC", VA = "0x3C39EAC")]
    public AccessoryOptionEffectSpriteMaster()
    {
    }
  }
}
