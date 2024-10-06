// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeShortcutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F9")]
  [Serializable]
  public sealed class AreaQuestAreaNodeShortcutData : IMasterDataEntity
  {
    [Token(Token = "0x40052E0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052E1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string refName;
    [Token(Token = "0x40052E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int areaNodeShortcutGroupId;
    [Token(Token = "0x40052E3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int jumpAreaNodeId;

    [Token(Token = "0x17000E97")]
    public int Key
    {
      [Token(Token = "0x60061DB"), Address(RVA = "0x4AD8D0C", Offset = "0x4AD8D0C", VA = "0x4AD8D0C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061DC")]
    [Address(RVA = "0x4AD8D14", Offset = "0x4AD8D14", VA = "0x4AD8D14", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60061DD")]
    [Address(RVA = "0x4AD8EE0", Offset = "0x4AD8EE0", VA = "0x4AD8EE0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E98")]
    public string DisplayTitle
    {
      [Token(Token = "0x60061DE"), Address(RVA = "0x4AD8F88", Offset = "0x4AD8F88", VA = "0x4AD8F88")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60061DF")]
    [Address(RVA = "0x4AD9064", Offset = "0x4AD9064", VA = "0x4AD9064")]
    public AreaQuestAreaNodeShortcutData()
    {
    }
  }
}
