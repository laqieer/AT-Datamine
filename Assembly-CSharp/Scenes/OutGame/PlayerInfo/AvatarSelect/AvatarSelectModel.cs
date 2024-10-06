// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.AvatarSelect.AvatarSelectModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.AvatarSelect
{
  [Token(Token = "0x20034CF")]
  internal class AvatarSelectModel
  {
    [Token(Token = "0x400E5D8")]
    [FieldOffset(Offset = "0x18")]
    public Action OnSelectedIndexChanged;
    [Token(Token = "0x400E5D9")]
    [FieldOffset(Offset = "0x20")]
    public Action OnApplied;
    [Token(Token = "0x400E5DA")]
    [FieldOffset(Offset = "0x28")]
    public Action<IEnumerator> StartCoroutine;
    [Token(Token = "0x400E5DB")]
    [FieldOffset(Offset = "0x30")]
    private List<PlayerAvatarData> playerAvatarDatas;

    [Token(Token = "0x170044B6")]
    public int SelectedIndexOnCreate
    {
      [Token(Token = "0x6014B8A"), Address(RVA = "0x1D6F910", Offset = "0x1D6F910", VA = "0x1D6F910")] get
      {
        return new int();
      }
      [Token(Token = "0x6014B8B"), Address(RVA = "0x1D6F918", Offset = "0x1D6F918", VA = "0x1D6F918")] private set
      {
      }
    }

    [Token(Token = "0x170044B7")]
    public int SelectedIndex
    {
      [Token(Token = "0x6014B8C"), Address(RVA = "0x1D6F920", Offset = "0x1D6F920", VA = "0x1D6F920")] get
      {
        return new int();
      }
      [Token(Token = "0x6014B8D"), Address(RVA = "0x1D6F928", Offset = "0x1D6F928", VA = "0x1D6F928")] private set
      {
      }
    }

    [Token(Token = "0x170044B8")]
    public bool IsDefaultSelected
    {
      [Token(Token = "0x6014B8E"), Address(RVA = "0x1D6F930", Offset = "0x1D6F930", VA = "0x1D6F930")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170044B9")]
    public int AvatarCount
    {
      [Token(Token = "0x6014B8F"), Address(RVA = "0x1D6F940", Offset = "0x1D6F940", VA = "0x1D6F940")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170044BA")]
    private int SelectedAvatarId
    {
      [Token(Token = "0x6014B90"), Address(RVA = "0x1D6F988", Offset = "0x1D6F988", VA = "0x1D6F988")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6014B91")]
    [Address(RVA = "0x1D6FA00", Offset = "0x1D6FA00", VA = "0x1D6FA00")]
    public static AvatarSelectModel CreateByCurrent() => (AvatarSelectModel) null;

    [Token(Token = "0x6014B92")]
    [Address(RVA = "0x1D6FC3C", Offset = "0x1D6FC3C", VA = "0x1D6FC3C")]
    public AvatarSelectModel(List<PlayerAvatarData> playerAvatarDatas, int selectedIndex)
    {
    }

    [Token(Token = "0x6014B93")]
    [Address(RVA = "0x1D6FC6C", Offset = "0x1D6FC6C", VA = "0x1D6FC6C")]
    public void SetAvatarIndex(int index)
    {
    }

    [Token(Token = "0x6014B94")]
    [Address(RVA = "0x1D6F9A8", Offset = "0x1D6F9A8", VA = "0x1D6F9A8")]
    public PlayerAvatarData GetAvatarData(int index) => (PlayerAvatarData) null;

    [Token(Token = "0x6014B95")]
    [Address(RVA = "0x1D6FC98", Offset = "0x1D6FC98", VA = "0x1D6FC98")]
    public void Apply()
    {
    }
  }
}
