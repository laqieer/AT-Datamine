// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatPollingIntervalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E79")]
  [Serializable]
  public sealed class ChatPollingIntervalData : IMasterDataEntity
  {
    [Token(Token = "0x40045F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int[] pollingIntervals;

    [Token(Token = "0x17000D1E")]
    public int Key
    {
      [Token(Token = "0x600583E"), Address(RVA = "0x3E47338", Offset = "0x3E47338", VA = "0x3E47338", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600583F")]
    [Address(RVA = "0x3E47340", Offset = "0x3E47340", VA = "0x3E47340", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005840")]
    [Address(RVA = "0x3E474DC", Offset = "0x3E474DC", VA = "0x3E474DC")]
    public ChatPollingIntervalData()
    {
    }
  }
}
