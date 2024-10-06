// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardStyleSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200135D")]
  [Serializable]
  public sealed class AbilityBoardStyleSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005AF5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AF6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int boardListId;
    [Token(Token = "0x4005AF7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int parameterPatternId;
    [Token(Token = "0x4005AF8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int elementPatternId;
    [Token(Token = "0x4005AF9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int attackPatternId;
    [Token(Token = "0x4005AFA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int customNodeSetting;
    [Token(Token = "0x4005AFB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int customAttackParameter;
    [Token(Token = "0x4005AFC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int customDefenseParameter;
    [Token(Token = "0x4005AFD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ParameterTypeEnum advantageousTypeId;
    [Token(Token = "0x4005AFE")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int materialType;
    [Token(Token = "0x4005AFF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int scrollType;

    [Token(Token = "0x17001070")]
    public int Key
    {
      [Token(Token = "0x6006D15"), Address(RVA = "0x46F98E8", Offset = "0x46F98E8", VA = "0x46F98E8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D16")]
    [Address(RVA = "0x46F98F0", Offset = "0x46F98F0", VA = "0x46F98F0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D17")]
    [Address(RVA = "0x46F9D5C", Offset = "0x46F9D5C", VA = "0x46F9D5C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D18")]
    [Address(RVA = "0x46F9E70", Offset = "0x46F9E70", VA = "0x46F9E70")]
    public AbilityBoardStyleSettingData()
    {
    }
  }
}
