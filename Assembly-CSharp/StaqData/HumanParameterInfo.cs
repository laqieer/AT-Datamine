// Decompiled with JetBrains decompiler
// Type: StaqData.HumanParameterInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020BF")]
  public class HumanParameterInfo
  {
    [Token(Token = "0x4008B0F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, HumanParameterData> table;

    [Token(Token = "0x17002A75")]
    public Dictionary<int, HumanParameterData> Table
    {
      [Token(Token = "0x600C647"), Address(RVA = "0x1CD6050", Offset = "0x1CD6050", VA = "0x1CD6050")] get
      {
        return (Dictionary<int, HumanParameterData>) null;
      }
      [Token(Token = "0x600C648"), Address(RVA = "0x1CD6058", Offset = "0x1CD6058", VA = "0x1CD6058")] set
      {
      }
    }

    [Token(Token = "0x600C649")]
    [Address(RVA = "0x1CD6060", Offset = "0x1CD6060", VA = "0x1CD6060")]
    public HumanParameterData Get(int humanParameterID) => (HumanParameterData) null;

    [Token(Token = "0x600C64A")]
    [Address(RVA = "0x1CD617C", Offset = "0x1CD617C", VA = "0x1CD617C")]
    public void Apply(int humanParameterID, int value)
    {
    }

    [Token(Token = "0x600C64B")]
    [Address(RVA = "0x1CD62EC", Offset = "0x1CD62EC", VA = "0x1CD62EC")]
    public void DebugUpdateMax()
    {
    }

    [Token(Token = "0x600C64C")]
    [Address(RVA = "0x1CD63CC", Offset = "0x1CD63CC", VA = "0x1CD63CC")]
    public void DebugUpdateReset()
    {
    }

    [Token(Token = "0x600C64D")]
    [Address(RVA = "0x1CD64A8", Offset = "0x1CD64A8", VA = "0x1CD64A8")]
    public HumanParameterInfo()
    {
    }
  }
}
