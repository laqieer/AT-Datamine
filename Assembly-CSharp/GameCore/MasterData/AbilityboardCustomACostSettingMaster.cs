// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomACostSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001338")]
  [Serializable]
  public sealed class AbilityboardCustomACostSettingMaster : 
    BaseMaster<AbilityboardCustomACostSettingData>
  {
    [Token(Token = "0x4005A9D")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityboardCustomACostSettingData>> dividedElementTypeTable;

    [Token(Token = "0x6006C6B")]
    [Address(RVA = "0x46F3510", Offset = "0x46F3510", VA = "0x46F3510")]
    public IReadOnlyDictionary<int, AbilityboardCustomACostSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityboardCustomACostSettingData>) null;
    }

    [Token(Token = "0x6006C6C")]
    [Address(RVA = "0x46F3518", Offset = "0x46F3518", VA = "0x46F3518", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C6D")]
    [Address(RVA = "0x46F3578", Offset = "0x46F3578", VA = "0x46F3578", Slot = "5")]
    protected override AbilityboardCustomACostSettingData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityboardCustomACostSettingData) null;
    }

    [Token(Token = "0x6006C6E")]
    [Address(RVA = "0x46F35E8", Offset = "0x46F35E8", VA = "0x46F35E8")]
    private void OnLoadEntity(AbilityboardCustomACostSettingData entity)
    {
    }

    [Token(Token = "0x6006C6F")]
    [Address(RVA = "0x46F35EC", Offset = "0x46F35EC", VA = "0x46F35EC")]
    private void GroupingByElementType(AbilityboardCustomACostSettingData entity)
    {
    }

    [Token(Token = "0x6006C70")]
    [Address(RVA = "0x46F37A8", Offset = "0x46F37A8", VA = "0x46F37A8")]
    public List<AbilityboardCustomACostSettingData> GetListByElementType(int elementType)
    {
      return (List<AbilityboardCustomACostSettingData>) null;
    }

    [Token(Token = "0x6006C71")]
    [Address(RVA = "0x46F3820", Offset = "0x46F3820", VA = "0x46F3820")]
    public AbilityboardCustomACostSettingMaster()
    {
    }
  }
}
