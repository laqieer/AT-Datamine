// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBattleMissionRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E6B")]
  [Serializable]
  public sealed class StoryBattleMissionRewardData : IMasterDataEntity
  {
    [Token(Token = "0x40045B4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000CF5")]
    public int Key
    {
      [Token(Token = "0x60057DA"), Address(RVA = "0x3E44260", Offset = "0x3E44260", VA = "0x3E44260", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057DB")]
    [Address(RVA = "0x3E44268", Offset = "0x3E44268", VA = "0x3E44268", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057DC")]
    [Address(RVA = "0x3E44374", Offset = "0x3E44374", VA = "0x3E44374", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60057DD")]
    [Address(RVA = "0x3E443FC", Offset = "0x3E443FC", VA = "0x3E443FC")]
    public StoryBattleMissionRewardData()
    {
    }
  }
}
