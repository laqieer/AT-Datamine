// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationIdentifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F6")]
  [Serializable]
  public sealed class StoryCommunicationIdentifierData : IMasterDataEntity
  {
    [Token(Token = "0x4005615")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005616")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005617")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int weeklyID;
    [Token(Token = "0x4005618")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int characterId;
    [Token(Token = "0x4005619")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int priority;
    [Token(Token = "0x400561A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int communicationItemPreferenceTypeID;
    [Token(Token = "0x400561B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int groupLabel;

    [Token(Token = "0x17000F76")]
    public int Key
    {
      [Token(Token = "0x600668A"), Address(RVA = "0x4D26568", Offset = "0x4D26568", VA = "0x4D26568", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600668B")]
    [Address(RVA = "0x4D26570", Offset = "0x4D26570", VA = "0x4D26570", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600668C")]
    [Address(RVA = "0x4D2685C", Offset = "0x4D2685C", VA = "0x4D2685C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600668D")]
    [Address(RVA = "0x4D26934", Offset = "0x4D26934", VA = "0x4D26934")]
    public StoryCommunicationIdentifierData()
    {
    }
  }
}
