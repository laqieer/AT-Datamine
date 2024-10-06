// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001270")]
  [Serializable]
  public sealed class StoryFreeActionPlayerData : IMasterDataEntity
  {
    [Token(Token = "0x4005827")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005828")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005829")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int characterSwitchPatternID;

    [Token(Token = "0x17000FE0")]
    public int Key
    {
      [Token(Token = "0x60068D7"), Address(RVA = "0x48CA0A8", Offset = "0x48CA0A8", VA = "0x48CA0A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068D8")]
    [Address(RVA = "0x48CA0B0", Offset = "0x48CA0B0", VA = "0x48CA0B0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068D9")]
    [Address(RVA = "0x48CA21C", Offset = "0x48CA21C", VA = "0x48CA21C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60068DA")]
    [Address(RVA = "0x48CA2B4", Offset = "0x48CA2B4", VA = "0x48CA2B4")]
    public StoryFreeActionPlayerData()
    {
    }
  }
}
