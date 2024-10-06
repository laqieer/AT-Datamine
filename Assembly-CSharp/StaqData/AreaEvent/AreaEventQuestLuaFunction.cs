// Decompiled with JetBrains decompiler
// Type: StaqData.AreaEvent.AreaEventQuestLuaFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using StaqData.Quest;

#nullable disable
namespace StaqData.AreaEvent
{
  [Token(Token = "0x2002155")]
  public class AreaEventQuestLuaFunction
  {
    [Token(Token = "0x17002CC2")]
    public AreaEventQuestLuaFunction.Object Obj
    {
      [Token(Token = "0x600CC4F"), Address(RVA = "0x1BAD9A8", Offset = "0x1BAD9A8", VA = "0x1BAD9A8")] get
      {
        return (AreaEventQuestLuaFunction.Object) null;
      }
      [Token(Token = "0x600CC50"), Address(RVA = "0x1BAD9B0", Offset = "0x1BAD9B0", VA = "0x1BAD9B0")] set
      {
      }
    }

    [Token(Token = "0x600CC51")]
    [Address(RVA = "0x1BAD9B8", Offset = "0x1BAD9B8", VA = "0x1BAD9B8")]
    public AreaEventQuestLuaFunction(int areaeventquestTaskID)
    {
    }

    [Token(Token = "0x2002156")]
    [MoonSharpUserData]
    public class Object : QuestLuaObject
    {
      [Token(Token = "0x600CC52")]
      [Address(RVA = "0x1BADA38", Offset = "0x1BADA38", VA = "0x1BADA38")]
      public void Initialize(int areaeventQuestTaskID)
      {
      }

      [Token(Token = "0x600CC53")]
      [Address(RVA = "0x1BADA34", Offset = "0x1BADA34", VA = "0x1BADA34")]
      public Object()
      {
      }
    }
  }
}
