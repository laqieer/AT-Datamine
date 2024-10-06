// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeTimeAnnouncementScheduleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200102B")]
  [Serializable]
  public sealed class HomeTimeAnnouncementScheduleData : IMasterDataEntity
  {
    [Token(Token = "0x4005048")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005049")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400504A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int start;
    [Token(Token = "0x400504B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int end;

    [Token(Token = "0x17000DDE")]
    public int Key
    {
      [Token(Token = "0x6005E0D"), Address(RVA = "0x2799894", Offset = "0x2799894", VA = "0x2799894", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E0E")]
    [Address(RVA = "0x279989C", Offset = "0x279989C", VA = "0x279989C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E0F")]
    [Address(RVA = "0x2799A68", Offset = "0x2799A68", VA = "0x2799A68", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E10")]
    [Address(RVA = "0x2799B10", Offset = "0x2799B10", VA = "0x2799B10")]
    public HomeTimeAnnouncementScheduleData()
    {
    }
  }
}
