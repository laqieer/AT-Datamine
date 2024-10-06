// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PreHomeEventAdvContentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010E3")]
  [Serializable]
  public sealed class PreHomeEventAdvContentData : IMasterDataEntity
  {
    [Token(Token = "0x40052A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052A8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int advDemoId;
    [Token(Token = "0x40052A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string advRunArgs;

    [Token(Token = "0x17000E81")]
    public int Key
    {
      [Token(Token = "0x6006177"), Address(RVA = "0x28E0C58", Offset = "0x28E0C58", VA = "0x28E0C58", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006178")]
    [Address(RVA = "0x28E0C60", Offset = "0x28E0C60", VA = "0x28E0C60", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006179")]
    [Address(RVA = "0x28E0DCC", Offset = "0x28E0DCC", VA = "0x28E0DCC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600617A")]
    [Address(RVA = "0x28E0E64", Offset = "0x28E0E64", VA = "0x28E0E64")]
    public PreHomeEventAdvContentData()
    {
    }
  }
}
