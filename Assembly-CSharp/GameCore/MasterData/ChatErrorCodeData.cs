// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatErrorCodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000ED7")]
  [Serializable]
  public sealed class ChatErrorCodeData : IMasterDataEntity
  {
    [Token(Token = "0x40048CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40048D0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D44")]
    public int Key
    {
      [Token(Token = "0x6005945"), Address(RVA = "0x3C312A0", Offset = "0x3C312A0", VA = "0x3C312A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005946")]
    [Address(RVA = "0x3C312A8", Offset = "0x3C312A8", VA = "0x3C312A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005947")]
    [Address(RVA = "0x3C313B4", Offset = "0x3C313B4", VA = "0x3C313B4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005948")]
    [Address(RVA = "0x3C3143C", Offset = "0x3C3143C", VA = "0x3C3143C")]
    public ChatErrorCodeData()
    {
    }
  }
}
