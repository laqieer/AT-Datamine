// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildSettingsPolicyTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FCC")]
  [Serializable]
  public sealed class GuildSettingsPolicyTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004F58")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;

    [Token(Token = "0x17000DA7")]
    public int Key
    {
      [Token(Token = "0x6005C7A"), Address(RVA = "0x278C0E4", Offset = "0x278C0E4", VA = "0x278C0E4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C7B")]
    [Address(RVA = "0x278C0EC", Offset = "0x278C0EC", VA = "0x278C0EC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C7C")]
    [Address(RVA = "0x278C198", Offset = "0x278C198", VA = "0x278C198", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DA8")]
    public string Name
    {
      [Token(Token = "0x6005C7D"), Address(RVA = "0x278C204", Offset = "0x278C204", VA = "0x278C204")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005C7E")]
    [Address(RVA = "0x278C2E0", Offset = "0x278C2E0", VA = "0x278C2E0")]
    public GuildSettingsPolicyTypeData()
    {
    }
  }
}
