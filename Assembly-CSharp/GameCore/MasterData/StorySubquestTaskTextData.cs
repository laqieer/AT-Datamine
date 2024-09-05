// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskTextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200131C")]
  [Serializable]
  public sealed class StorySubquestTaskTextData : IMasterDataEntity
  {
    [Token(Token = "0x4005A60")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A61")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;

    [Token(Token = "0x17001052")]
    public int Key
    {
      [Token(Token = "0x6006BF0"), Address(RVA = "0x48E7224", Offset = "0x48E7224", VA = "0x48E7224", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BF1")]
    [Address(RVA = "0x48E722C", Offset = "0x48E722C", VA = "0x48E722C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BF2")]
    [Address(RVA = "0x48E7338", Offset = "0x48E7338", VA = "0x48E7338", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001053")]
    public string Text
    {
      [Token(Token = "0x6006BF3"), Address(RVA = "0x48E73C0", Offset = "0x48E73C0", VA = "0x48E73C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BF4")]
    [Address(RVA = "0x48E749C", Offset = "0x48E749C", VA = "0x48E749C")]
    public StorySubquestTaskTextData()
    {
    }
  }
}
