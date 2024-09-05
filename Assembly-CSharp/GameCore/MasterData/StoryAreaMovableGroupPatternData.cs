// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableGroupPatternData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011CC")]
  [Serializable]
  public sealed class StoryAreaMovableGroupPatternData : IMasterDataEntity
  {
    [Token(Token = "0x4005592")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005593")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string groupPattern;
    [Token(Token = "0x4005594")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int mobSetting_1;
    [Token(Token = "0x4005595")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int mobSetting_2;

    [Token(Token = "0x17000F5F")]
    public int Key
    {
      [Token(Token = "0x60065D7"), Address(RVA = "0x4D1F6B8", Offset = "0x4D1F6B8", VA = "0x4D1F6B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065D8")]
    [Address(RVA = "0x4D1F6C0", Offset = "0x4D1F6C0", VA = "0x4D1F6C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065D9")]
    [Address(RVA = "0x4D1F88C", Offset = "0x4D1F88C", VA = "0x4D1F88C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60065DA")]
    [Address(RVA = "0x4D1F934", Offset = "0x4D1F934", VA = "0x4D1F934")]
    public StoryAreaMovableGroupPatternData()
    {
    }
  }
}
