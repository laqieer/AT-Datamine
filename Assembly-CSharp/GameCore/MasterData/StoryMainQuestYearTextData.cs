// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestYearTextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012BB")]
  [Serializable]
  public sealed class StoryMainQuestYearTextData : IMasterDataEntity
  {
    [Token(Token = "0x400591A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400591B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x400591C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string Text;

    [Token(Token = "0x1700100F")]
    public int Key
    {
      [Token(Token = "0x6006A49"), Address(RVA = "0x48D7D74", Offset = "0x48D7D74", VA = "0x48D7D74", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A4A")]
    [Address(RVA = "0x48D7D7C", Offset = "0x48D7D7C", VA = "0x48D7D7C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A4B")]
    [Address(RVA = "0x48D7EE8", Offset = "0x48D7EE8", VA = "0x48D7EE8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A4C")]
    [Address(RVA = "0x48D7F84", Offset = "0x48D7F84", VA = "0x48D7F84")]
    public StoryMainQuestYearTextData()
    {
    }
  }
}
