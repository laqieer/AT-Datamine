// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F0")]
  [Serializable]
  public sealed class AreaQuestAreaGroupData : IMasterDataEntity
  {
    [Token(Token = "0x40052C5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string refName;
    [Token(Token = "0x40052C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public AreaGroupTypeEnum areaGroupType;
    [Token(Token = "0x40052C8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int areaGroupReleaseConditionId;
    [Token(Token = "0x40052C9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int backgroundResourceId;

    [Token(Token = "0x17000E88")]
    public int Key
    {
      [Token(Token = "0x600619F"), Address(RVA = "0x28E1E44", Offset = "0x28E1E44", VA = "0x28E1E44", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061A0")]
    [Address(RVA = "0x28E1E4C", Offset = "0x28E1E4C", VA = "0x28E1E4C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60061A1")]
    [Address(RVA = "0x28E2078", Offset = "0x28E2078", VA = "0x28E2078", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60061A2")]
    [Address(RVA = "0x28E2130", Offset = "0x28E2130", VA = "0x28E2130")]
    public AreaQuestAreaGroupData()
    {
    }
  }
}
