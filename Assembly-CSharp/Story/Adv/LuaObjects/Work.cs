// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.Work
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x200075B")]
  [MoonSharpUserData]
  public class Work
  {
    [Token(Token = "0x40021B0")]
    [FieldOffset(Offset = "0x10")]
    public bool Enable;
    [Token(Token = "0x40021B1")]
    [FieldOffset(Offset = "0x14")]
    public int IntValue;

    [Token(Token = "0x1700062E")]
    public int ID
    {
      [Token(Token = "0x600294A"), Address(RVA = "0x367FB08", Offset = "0x367FB08", VA = "0x367FB08")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700062F")]
    public string TextValue
    {
      [Token(Token = "0x600294B"), Address(RVA = "0x367FB10", Offset = "0x367FB10", VA = "0x367FB10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000630")]
    public int WorkID
    {
      [Token(Token = "0x600294C"), Address(RVA = "0x367FB18", Offset = "0x367FB18", VA = "0x367FB18")] get
      {
        return new int();
      }
      [Token(Token = "0x600294D"), Address(RVA = "0x367FB20", Offset = "0x367FB20", VA = "0x367FB20")] set
      {
      }
    }

    [Token(Token = "0x17000631")]
    public string Name
    {
      [Token(Token = "0x600294E"), Address(RVA = "0x367FB28", Offset = "0x367FB28", VA = "0x367FB28")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600294F"), Address(RVA = "0x367FB30", Offset = "0x367FB30", VA = "0x367FB30")] set
      {
      }
    }

    [Token(Token = "0x6002950")]
    [Address(RVA = "0x367FB38", Offset = "0x367FB38", VA = "0x367FB38")]
    public LuaSequence.ParamControl.HumanParameter GetHumanParam()
    {
      return (LuaSequence.ParamControl.HumanParameter) null;
    }

    [Token(Token = "0x6002951")]
    [Address(RVA = "0x367BBEC", Offset = "0x367BBEC", VA = "0x367BBEC")]
    public Work()
    {
    }
  }
}
