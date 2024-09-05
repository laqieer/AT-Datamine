// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScenarioQuestScheduleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001131")]
  [Serializable]
  public sealed class ScenarioQuestScheduleData : IMasterDataEntity
  {
    [Token(Token = "0x40053AD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string text;
    [Token(Token = "0x40053AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int banner;
    [Token(Token = "0x40053B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40053B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000ED7")]
    public int Key
    {
      [Token(Token = "0x60062F5"), Address(RVA = "0x4AE3F84", Offset = "0x4AE3F84", VA = "0x4AE3F84", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062F6")]
    [Address(RVA = "0x4AE3F8C", Offset = "0x4AE3F8C", VA = "0x4AE3F8C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062F7")]
    [Address(RVA = "0x4AE41B8", Offset = "0x4AE41B8", VA = "0x4AE41B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60062F8")]
    [Address(RVA = "0x4AE42C8", Offset = "0x4AE42C8", VA = "0x4AE42C8")]
    public ScenarioQuestScheduleData()
    {
    }
  }
}
