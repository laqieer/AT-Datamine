// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionBackgroundData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001247")]
  [Serializable]
  public sealed class StoryFreeActionBackgroundData : IMasterDataEntity
  {
    [Token(Token = "0x4005776")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005777")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005778")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int backGroundID;
    [Token(Token = "0x4005779")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int placementID;
    [Token(Token = "0x400577A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int cameraFieldID;
    [Token(Token = "0x400577B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int movableRouteID;
    [Token(Token = "0x400577C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int transitionAreaID;
    [Token(Token = "0x400577D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int environmentalSoundID;
    [Token(Token = "0x400577E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int uniqueObjectLabel;
    [Token(Token = "0x400577F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string debugTagModelName;
    [Token(Token = "0x4005780")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string debugTagChapter;
    [Token(Token = "0x4005781")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string debugTagWeather;
    [Token(Token = "0x4005782")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string debugTagTimeslot;

    [Token(Token = "0x17000FB0")]
    public int Key
    {
      [Token(Token = "0x60067F8"), Address(RVA = "0x4D343F8", Offset = "0x4D343F8", VA = "0x4D343F8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067F9")]
    [Address(RVA = "0x4D34400", Offset = "0x4D34400", VA = "0x4D34400", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067FA")]
    [Address(RVA = "0x4D3492C", Offset = "0x4D3492C", VA = "0x4D3492C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60067FB")]
    [Address(RVA = "0x4D34A74", Offset = "0x4D34A74", VA = "0x4D34A74")]
    public StoryFreeActionBackgroundData()
    {
    }
  }
}
