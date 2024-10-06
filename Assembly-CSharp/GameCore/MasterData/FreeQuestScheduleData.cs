// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FreeQuestScheduleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001119")]
  [Serializable]
  public sealed class FreeQuestScheduleData : IMasterDataEntity
  {
    [Token(Token = "0x4005343")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005344")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string text;
    [Token(Token = "0x4005345")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4005346")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000EAD")]
    public int Key
    {
      [Token(Token = "0x600626B"), Address(RVA = "0x4ADF0E0", Offset = "0x4ADF0E0", VA = "0x4ADF0E0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600626C")]
    [Address(RVA = "0x4ADF0E8", Offset = "0x4ADF0E8", VA = "0x4ADF0E8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600626D")]
    [Address(RVA = "0x4ADF2B4", Offset = "0x4ADF2B4", VA = "0x4ADF2B4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600626E")]
    [Address(RVA = "0x4ADF3B4", Offset = "0x4ADF3B4", VA = "0x4ADF3B4")]
    public FreeQuestScheduleData()
    {
    }
  }
}
