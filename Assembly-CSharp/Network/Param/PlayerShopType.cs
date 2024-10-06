// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerShopType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE0")]
  [Serializable]
  public class PlayerShopType
  {
    [Token(Token = "0x4007343")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int shop_id;
    [Token(Token = "0x4007344")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int shop_type;
    [Token(Token = "0x4007345")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string shop_name;
    [Token(Token = "0x4007346")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string banner_name;
    [Token(Token = "0x4007347")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int show_priority;
    [Token(Token = "0x4007348")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x4007349")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayerShopResetButtonType reset_button;

    [Token(Token = "0x17001BA5")]
    public int ShopId
    {
      [Token(Token = "0x6009C95"), Address(RVA = "0x48F2540", Offset = "0x48F2540", VA = "0x48F2540")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C96"), Address(RVA = "0x48F2548", Offset = "0x48F2548", VA = "0x48F2548")] set
      {
      }
    }

    [Token(Token = "0x17001BA6")]
    public int ShopType
    {
      [Token(Token = "0x6009C97"), Address(RVA = "0x48F2550", Offset = "0x48F2550", VA = "0x48F2550")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C98"), Address(RVA = "0x48F2558", Offset = "0x48F2558", VA = "0x48F2558")] set
      {
      }
    }

    [Token(Token = "0x17001BA7")]
    public string ShopName
    {
      [Token(Token = "0x6009C99"), Address(RVA = "0x48F2560", Offset = "0x48F2560", VA = "0x48F2560")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C9A"), Address(RVA = "0x48F2568", Offset = "0x48F2568", VA = "0x48F2568")] set
      {
      }
    }

    [Token(Token = "0x17001BA8")]
    public string BannerName
    {
      [Token(Token = "0x6009C9B"), Address(RVA = "0x48F2570", Offset = "0x48F2570", VA = "0x48F2570")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C9C"), Address(RVA = "0x48F2578", Offset = "0x48F2578", VA = "0x48F2578")] set
      {
      }
    }

    [Token(Token = "0x17001BA9")]
    public int ShowPriority
    {
      [Token(Token = "0x6009C9D"), Address(RVA = "0x48F2580", Offset = "0x48F2580", VA = "0x48F2580")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C9E"), Address(RVA = "0x48F2588", Offset = "0x48F2588", VA = "0x48F2588")] set
      {
      }
    }

    [Token(Token = "0x17001BAA")]
    public string EndAt
    {
      [Token(Token = "0x6009C9F"), Address(RVA = "0x48F2590", Offset = "0x48F2590", VA = "0x48F2590")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009CA0"), Address(RVA = "0x48F2598", Offset = "0x48F2598", VA = "0x48F2598")] set
      {
      }
    }

    [Token(Token = "0x17001BAB")]
    public PlayerShopResetButtonType ResetButton
    {
      [Token(Token = "0x6009CA1"), Address(RVA = "0x48F25A0", Offset = "0x48F25A0", VA = "0x48F25A0")] get
      {
        return (PlayerShopResetButtonType) null;
      }
      [Token(Token = "0x6009CA2"), Address(RVA = "0x48F25A8", Offset = "0x48F25A8", VA = "0x48F25A8")] set
      {
      }
    }

    [Token(Token = "0x6009CA3")]
    [Address(RVA = "0x48F25B0", Offset = "0x48F25B0", VA = "0x48F25B0")]
    public PlayerShopType()
    {
    }
  }
}
