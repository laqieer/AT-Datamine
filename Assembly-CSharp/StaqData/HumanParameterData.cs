// Decompiled with JetBrains decompiler
// Type: StaqData.HumanParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C0")]
  public class HumanParameterData
  {
    [Token(Token = "0x4008B13")]
    private const int initValue = 0;

    [Token(Token = "0x17002A76")]
    public int ID
    {
      [Token(Token = "0x600C64E"), Address(RVA = "0x1CD6524", Offset = "0x1CD6524", VA = "0x1CD6524")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A77")]
    public int Level
    {
      [Token(Token = "0x600C64F"), Address(RVA = "0x1CD652C", Offset = "0x1CD652C", VA = "0x1CD652C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C650"), Address(RVA = "0x1CD6534", Offset = "0x1CD6534", VA = "0x1CD6534")] private set
      {
      }
    }

    [Token(Token = "0x17002A78")]
    public int Value
    {
      [Token(Token = "0x600C651"), Address(RVA = "0x1CD653C", Offset = "0x1CD653C", VA = "0x1CD653C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C652"), Address(RVA = "0x1CD6544", Offset = "0x1CD6544", VA = "0x1CD6544")] private set
      {
      }
    }

    [Token(Token = "0x600C653")]
    [Address(RVA = "0x1CD614C", Offset = "0x1CD614C", VA = "0x1CD614C")]
    public HumanParameterData(int id)
    {
    }

    [Token(Token = "0x600C654")]
    [Address(RVA = "0x1CD6240", Offset = "0x1CD6240", VA = "0x1CD6240")]
    public void SetValue(int value)
    {
    }
  }
}
