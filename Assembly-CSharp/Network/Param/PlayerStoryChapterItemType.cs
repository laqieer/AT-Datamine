// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryChapterItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE5")]
  [Serializable]
  public class PlayerStoryChapterItemType
  {
    [Token(Token = "0x4007355")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007356")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int item_count;
    [Token(Token = "0x4007357")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int use_count;
    [Token(Token = "0x4007358")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool is_read_through;

    [Token(Token = "0x17001BB7")]
    public int ItemId
    {
      [Token(Token = "0x6009CBE"), Address(RVA = "0x48F2690", Offset = "0x48F2690", VA = "0x48F2690")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CBF"), Address(RVA = "0x48F2698", Offset = "0x48F2698", VA = "0x48F2698")] set
      {
      }
    }

    [Token(Token = "0x17001BB8")]
    public int ItemCount
    {
      [Token(Token = "0x6009CC0"), Address(RVA = "0x48F26A0", Offset = "0x48F26A0", VA = "0x48F26A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CC1"), Address(RVA = "0x48F26A8", Offset = "0x48F26A8", VA = "0x48F26A8")] set
      {
      }
    }

    [Token(Token = "0x17001BB9")]
    public int UseCount
    {
      [Token(Token = "0x6009CC2"), Address(RVA = "0x48F26B0", Offset = "0x48F26B0", VA = "0x48F26B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CC3"), Address(RVA = "0x48F26B8", Offset = "0x48F26B8", VA = "0x48F26B8")] set
      {
      }
    }

    [Token(Token = "0x17001BBA")]
    public bool IsReadThrough
    {
      [Token(Token = "0x6009CC4"), Address(RVA = "0x48F26C0", Offset = "0x48F26C0", VA = "0x48F26C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009CC5"), Address(RVA = "0x48F26C8", Offset = "0x48F26C8", VA = "0x48F26C8")] set
      {
      }
    }

    [Token(Token = "0x6009CC6")]
    [Address(RVA = "0x48F26D4", Offset = "0x48F26D4", VA = "0x48F26D4")]
    public PlayerStoryChapterItemType()
    {
    }
  }
}
