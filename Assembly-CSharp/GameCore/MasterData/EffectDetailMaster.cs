// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EffectDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011AD")]
  [Serializable]
  public sealed class EffectDetailMaster : BaseMaster<EffectDetailData>
  {
    [Token(Token = "0x4005504")]
    public const string TEXT_AB = "text_masterdata_skill";
    [Token(Token = "0x4005505")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<(int skillId, int level), List<EffectDetailData>> mapBySkill;

    [Token(Token = "0x6006543")]
    [Address(RVA = "0x4AF6F44", Offset = "0x4AF6F44", VA = "0x4AF6F44")]
    public IReadOnlyDictionary<int, EffectDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EffectDetailData>) null;
    }

    [Token(Token = "0x6006544")]
    [Address(RVA = "0x4AF6F4C", Offset = "0x4AF6F4C", VA = "0x4AF6F4C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006545")]
    [Address(RVA = "0x4AF72F0", Offset = "0x4AF72F0", VA = "0x4AF72F0", Slot = "5")]
    protected override EffectDetailData LoadEntity(IMasterDataReader reader)
    {
      return (EffectDetailData) null;
    }

    [Token(Token = "0x6006546")]
    [Address(RVA = "0x4AF7360", Offset = "0x4AF7360", VA = "0x4AF7360")]
    private void OnLoadEntity(EffectDetailData entity)
    {
    }

    [Token(Token = "0x6006547")]
    [Address(RVA = "0x4AF6FB4", Offset = "0x4AF6FB4", VA = "0x4AF6FB4")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006548")]
    [Address(RVA = "0x4AF7500", Offset = "0x4AF7500", VA = "0x4AF7500")]
    public IReadOnlyList<EffectDetailData> GetEffects(int baseMasterId, int level)
    {
      return (IReadOnlyList<EffectDetailData>) null;
    }

    [Token(Token = "0x6006549")]
    [Address(RVA = "0x4AF75FC", Offset = "0x4AF75FC", VA = "0x4AF75FC")]
    public EffectDetailMaster()
    {
    }
  }
}
