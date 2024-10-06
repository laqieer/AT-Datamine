// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAdvInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DCB")]
  [Serializable]
  public sealed class StoryAdvInfoData : IMasterDataEntity
  {
    [Token(Token = "0x40041FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40041FE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int advType;
    [Token(Token = "0x40041FF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string assetName;
    [Token(Token = "0x4004200")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string BGMBank;
    [Token(Token = "0x4004201")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string BGMEvent;
    [Token(Token = "0x4004202")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int choiceInfo1;
    [Token(Token = "0x4004203")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int choiceInfo2;
    [Token(Token = "0x4004204")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int choiceInfo3;
    [Token(Token = "0x4004205")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int choiceInfo4;
    [Token(Token = "0x4004206")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int choiceInfo5;

    [Token(Token = "0x17000C07")]
    public int Key
    {
      [Token(Token = "0x6005445"), Address(RVA = "0x3AA3B60", Offset = "0x3AA3B60", VA = "0x3AA3B60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005446")]
    [Address(RVA = "0x3AA3B68", Offset = "0x3AA3B68", VA = "0x3AA3B68", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005447")]
    [Address(RVA = "0x3AA3FD4", Offset = "0x3AA3FD4", VA = "0x3AA3FD4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005448")]
    [Address(RVA = "0x3AA40F8", Offset = "0x3AA40F8", VA = "0x3AA40F8")]
    public StoryAdvInfoData()
    {
    }
  }
}
