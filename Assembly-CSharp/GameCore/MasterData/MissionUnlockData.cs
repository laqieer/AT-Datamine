// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionUnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010AA")]
  [Serializable]
  public sealed class MissionUnlockData : IMasterDataEntity
  {
    [Token(Token = "0x4005217")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005218")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000E5F")]
    public int Key
    {
      [Token(Token = "0x600606E"), Address(RVA = "0x28D7598", Offset = "0x28D7598", VA = "0x28D7598", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600606F")]
    [Address(RVA = "0x28D75A0", Offset = "0x28D75A0", VA = "0x28D75A0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006070")]
    [Address(RVA = "0x28D76AC", Offset = "0x28D76AC", VA = "0x28D76AC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006071")]
    [Address(RVA = "0x28D7734", Offset = "0x28D7734", VA = "0x28D7734")]
    public MissionUnlockData()
    {
    }
  }
}
