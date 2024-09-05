// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEnemyPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E3B")]
  [Serializable]
  public sealed class BattleEnemyPlacementData : IMasterDataEntity
  {
    [Token(Token = "0x40043FD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C88")]
    public int Key
    {
      [Token(Token = "0x60056B4"), Address(RVA = "0x3E38DB0", Offset = "0x3E38DB0", VA = "0x3E38DB0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056B5")]
    [Address(RVA = "0x3E38DB8", Offset = "0x3E38DB8", VA = "0x3E38DB8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60056B6")]
    [Address(RVA = "0x3E38EC4", Offset = "0x3E38EC4", VA = "0x3E38EC4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60056B7")]
    [Address(RVA = "0x3E38F4C", Offset = "0x3E38F4C", VA = "0x3E38F4C")]
    public BattleEnemyPlacementData()
    {
    }
  }
}
