// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPassiveTalkMessageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200126C")]
  [Serializable]
  public sealed class StoryFreeActionPassiveTalkMessageData : IMasterDataEntity
  {
    [Token(Token = "0x400581A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400581B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;

    [Token(Token = "0x17000FD6")]
    public int Key
    {
      [Token(Token = "0x60068B8"), Address(RVA = "0x48C936C", Offset = "0x48C936C", VA = "0x48C936C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068B9")]
    [Address(RVA = "0x48C9374", Offset = "0x48C9374", VA = "0x48C9374", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068BA")]
    [Address(RVA = "0x48C9480", Offset = "0x48C9480", VA = "0x48C9480", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FD7")]
    public string Message1_1
    {
      [Token(Token = "0x60068BB"), Address(RVA = "0x48C9508", Offset = "0x48C9508", VA = "0x48C9508")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FD8")]
    public string Message1_2
    {
      [Token(Token = "0x60068BC"), Address(RVA = "0x48C9634", Offset = "0x48C9634", VA = "0x48C9634")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FD9")]
    public string Message2_1
    {
      [Token(Token = "0x60068BD"), Address(RVA = "0x48C967C", Offset = "0x48C967C", VA = "0x48C967C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FDA")]
    public string Message2_2
    {
      [Token(Token = "0x60068BE"), Address(RVA = "0x48C96C4", Offset = "0x48C96C4", VA = "0x48C96C4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FDB")]
    public string Message3_1
    {
      [Token(Token = "0x60068BF"), Address(RVA = "0x48C970C", Offset = "0x48C970C", VA = "0x48C970C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FDC")]
    public string Message3_2
    {
      [Token(Token = "0x60068C0"), Address(RVA = "0x48C9754", Offset = "0x48C9754", VA = "0x48C9754")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FDD")]
    public string Message4_1
    {
      [Token(Token = "0x60068C1"), Address(RVA = "0x48C979C", Offset = "0x48C979C", VA = "0x48C979C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FDE")]
    public string Message4_2
    {
      [Token(Token = "0x60068C2"), Address(RVA = "0x48C97E4", Offset = "0x48C97E4", VA = "0x48C97E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60068C3")]
    [Address(RVA = "0x48C9550", Offset = "0x48C9550", VA = "0x48C9550")]
    private string GetMessage(string tag) => (string) null;

    [Token(Token = "0x60068C4")]
    [Address(RVA = "0x48C982C", Offset = "0x48C982C", VA = "0x48C982C")]
    public StoryFreeActionPassiveTalkMessageData()
    {
    }
  }
}
