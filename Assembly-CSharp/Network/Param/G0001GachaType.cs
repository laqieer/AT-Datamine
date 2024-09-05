// Decompiled with JetBrains decompiler
// Type: Network.Param.G0001GachaType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A5D")]
  [Serializable]
  public class G0001GachaType
  {
    [Token(Token = "0x40070D6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int id;
    [Token(Token = "0x40070D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string name;
    [Token(Token = "0x40070D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int group_id;
    [Token(Token = "0x40070D9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int roll_count;
    [Token(Token = "0x40070DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string start_at;
    [Token(Token = "0x40070DB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x40070DC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int limit;
    [Token(Token = "0x40070DD")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int daily_limit;
    [Token(Token = "0x40070DE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int count;
    [Token(Token = "0x40070DF")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private int daily_count;
    [Token(Token = "0x40070E0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int payment_type_id;
    [Token(Token = "0x40070E1")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int payment_id;
    [Token(Token = "0x40070E2")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int payment_amount;
    [Token(Token = "0x40070E3")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private int remain_advertisement_count;
    [Token(Token = "0x40070E4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private bool is_badge_enable;
    [Token(Token = "0x40070E5")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private int stepup_id;
    [Token(Token = "0x40070E6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int max_execute_count;
    [Token(Token = "0x40070E7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<G0000GachaAdditionType> additions;
    [Token(Token = "0x40070E8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private int target_id;

    [Token(Token = "0x1700190C")]
    public int Id
    {
      [Token(Token = "0x600970B"), Address(RVA = "0x48EF6A4", Offset = "0x48EF6A4", VA = "0x48EF6A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600970C"), Address(RVA = "0x48EF6AC", Offset = "0x48EF6AC", VA = "0x48EF6AC")] set
      {
      }
    }

    [Token(Token = "0x1700190D")]
    public string Name
    {
      [Token(Token = "0x600970D"), Address(RVA = "0x48EF6B4", Offset = "0x48EF6B4", VA = "0x48EF6B4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600970E"), Address(RVA = "0x48EF6BC", Offset = "0x48EF6BC", VA = "0x48EF6BC")] set
      {
      }
    }

    [Token(Token = "0x1700190E")]
    public int GroupId
    {
      [Token(Token = "0x600970F"), Address(RVA = "0x48EF6C4", Offset = "0x48EF6C4", VA = "0x48EF6C4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009710"), Address(RVA = "0x48EF6CC", Offset = "0x48EF6CC", VA = "0x48EF6CC")] set
      {
      }
    }

    [Token(Token = "0x1700190F")]
    public int RollCount
    {
      [Token(Token = "0x6009711"), Address(RVA = "0x48EF6D4", Offset = "0x48EF6D4", VA = "0x48EF6D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009712"), Address(RVA = "0x48EF6DC", Offset = "0x48EF6DC", VA = "0x48EF6DC")] set
      {
      }
    }

    [Token(Token = "0x17001910")]
    public string StartAt
    {
      [Token(Token = "0x6009713"), Address(RVA = "0x48EF6E4", Offset = "0x48EF6E4", VA = "0x48EF6E4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009714"), Address(RVA = "0x48EF6EC", Offset = "0x48EF6EC", VA = "0x48EF6EC")] set
      {
      }
    }

    [Token(Token = "0x17001911")]
    public string EndAt
    {
      [Token(Token = "0x6009715"), Address(RVA = "0x48EF6F4", Offset = "0x48EF6F4", VA = "0x48EF6F4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009716"), Address(RVA = "0x48EF6FC", Offset = "0x48EF6FC", VA = "0x48EF6FC")] set
      {
      }
    }

    [Token(Token = "0x17001912")]
    public int Limit
    {
      [Token(Token = "0x6009717"), Address(RVA = "0x48EF704", Offset = "0x48EF704", VA = "0x48EF704")] get
      {
        return new int();
      }
      [Token(Token = "0x6009718"), Address(RVA = "0x48EF70C", Offset = "0x48EF70C", VA = "0x48EF70C")] set
      {
      }
    }

    [Token(Token = "0x17001913")]
    public int DailyLimit
    {
      [Token(Token = "0x6009719"), Address(RVA = "0x48EF714", Offset = "0x48EF714", VA = "0x48EF714")] get
      {
        return new int();
      }
      [Token(Token = "0x600971A"), Address(RVA = "0x48EF71C", Offset = "0x48EF71C", VA = "0x48EF71C")] set
      {
      }
    }

    [Token(Token = "0x17001914")]
    public int Count
    {
      [Token(Token = "0x600971B"), Address(RVA = "0x48EF724", Offset = "0x48EF724", VA = "0x48EF724")] get
      {
        return new int();
      }
      [Token(Token = "0x600971C"), Address(RVA = "0x48EF72C", Offset = "0x48EF72C", VA = "0x48EF72C")] set
      {
      }
    }

    [Token(Token = "0x17001915")]
    public int DailyCount
    {
      [Token(Token = "0x600971D"), Address(RVA = "0x48EF734", Offset = "0x48EF734", VA = "0x48EF734")] get
      {
        return new int();
      }
      [Token(Token = "0x600971E"), Address(RVA = "0x48EF73C", Offset = "0x48EF73C", VA = "0x48EF73C")] set
      {
      }
    }

    [Token(Token = "0x17001916")]
    public int PaymentTypeId
    {
      [Token(Token = "0x600971F"), Address(RVA = "0x48EF744", Offset = "0x48EF744", VA = "0x48EF744")] get
      {
        return new int();
      }
      [Token(Token = "0x6009720"), Address(RVA = "0x48EF74C", Offset = "0x48EF74C", VA = "0x48EF74C")] set
      {
      }
    }

    [Token(Token = "0x17001917")]
    public int PaymentId
    {
      [Token(Token = "0x6009721"), Address(RVA = "0x48EF754", Offset = "0x48EF754", VA = "0x48EF754")] get
      {
        return new int();
      }
      [Token(Token = "0x6009722"), Address(RVA = "0x48EF75C", Offset = "0x48EF75C", VA = "0x48EF75C")] set
      {
      }
    }

    [Token(Token = "0x17001918")]
    public int PaymentAmount
    {
      [Token(Token = "0x6009723"), Address(RVA = "0x48EF764", Offset = "0x48EF764", VA = "0x48EF764")] get
      {
        return new int();
      }
      [Token(Token = "0x6009724"), Address(RVA = "0x48EF76C", Offset = "0x48EF76C", VA = "0x48EF76C")] set
      {
      }
    }

    [Token(Token = "0x17001919")]
    public int RemainAdvertisementCount
    {
      [Token(Token = "0x6009725"), Address(RVA = "0x48EF774", Offset = "0x48EF774", VA = "0x48EF774")] get
      {
        return new int();
      }
      [Token(Token = "0x6009726"), Address(RVA = "0x48EF77C", Offset = "0x48EF77C", VA = "0x48EF77C")] set
      {
      }
    }

    [Token(Token = "0x1700191A")]
    public bool IsBadgeEnable
    {
      [Token(Token = "0x6009727"), Address(RVA = "0x48EF784", Offset = "0x48EF784", VA = "0x48EF784")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009728"), Address(RVA = "0x48EF78C", Offset = "0x48EF78C", VA = "0x48EF78C")] set
      {
      }
    }

    [Token(Token = "0x1700191B")]
    public int StepupId
    {
      [Token(Token = "0x6009729"), Address(RVA = "0x48EF798", Offset = "0x48EF798", VA = "0x48EF798")] get
      {
        return new int();
      }
      [Token(Token = "0x600972A"), Address(RVA = "0x48EF7A0", Offset = "0x48EF7A0", VA = "0x48EF7A0")] set
      {
      }
    }

    [Token(Token = "0x1700191C")]
    public int MaxExecuteCount
    {
      [Token(Token = "0x600972B"), Address(RVA = "0x48EF7A8", Offset = "0x48EF7A8", VA = "0x48EF7A8")] get
      {
        return new int();
      }
      [Token(Token = "0x600972C"), Address(RVA = "0x48EF7B0", Offset = "0x48EF7B0", VA = "0x48EF7B0")] set
      {
      }
    }

    [Token(Token = "0x1700191D")]
    public List<G0000GachaAdditionType> Additions
    {
      [Token(Token = "0x600972D"), Address(RVA = "0x48EF7B8", Offset = "0x48EF7B8", VA = "0x48EF7B8")] get
      {
        return (List<G0000GachaAdditionType>) null;
      }
      [Token(Token = "0x600972E"), Address(RVA = "0x48EF7C0", Offset = "0x48EF7C0", VA = "0x48EF7C0")] set
      {
      }
    }

    [Token(Token = "0x1700191E")]
    public int TargetId
    {
      [Token(Token = "0x600972F"), Address(RVA = "0x48EF7C8", Offset = "0x48EF7C8", VA = "0x48EF7C8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009730"), Address(RVA = "0x48EF7D0", Offset = "0x48EF7D0", VA = "0x48EF7D0")] set
      {
      }
    }

    [Token(Token = "0x6009731")]
    [Address(RVA = "0x48EF7D8", Offset = "0x48EF7D8", VA = "0x48EF7D8")]
    public G0001GachaType()
    {
    }
  }
}
