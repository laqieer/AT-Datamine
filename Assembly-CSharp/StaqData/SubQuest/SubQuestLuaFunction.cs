// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuest.SubQuestLuaFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using StaqData.Quest;

#nullable disable
namespace StaqData.SubQuest
{
  [Token(Token = "0x2002148")]
  public class SubQuestLuaFunction
  {
    [Token(Token = "0x17002C9C")]
    public SubQuestLuaFunction.Object Obj
    {
      [Token(Token = "0x600CBF4"), Address(RVA = "0x1BAA8A4", Offset = "0x1BAA8A4", VA = "0x1BAA8A4")] get
      {
        return (SubQuestLuaFunction.Object) null;
      }
    }

    [Token(Token = "0x600CBF5")]
    [Address(RVA = "0x1BAA8AC", Offset = "0x1BAA8AC", VA = "0x1BAA8AC")]
    public SubQuestLuaFunction(int subquestTaskID)
    {
    }

    [Token(Token = "0x2002149")]
    [MoonSharpUserData]
    public class Object : QuestLuaObject
    {
      [Token(Token = "0x600CBF6")]
      [Address(RVA = "0x1BAA92C", Offset = "0x1BAA92C", VA = "0x1BAA92C")]
      public void Initialize(int subquestTaskID)
      {
      }

      [Token(Token = "0x600CBF7")]
      [Address(RVA = "0x1BAA928", Offset = "0x1BAA928", VA = "0x1BAA928")]
      public Object()
      {
      }
    }
  }
}
