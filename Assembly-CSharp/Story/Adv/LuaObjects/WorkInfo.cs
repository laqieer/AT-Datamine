// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.WorkInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x200075A")]
  [MoonSharpUserData]
  public class WorkInfo
  {
    [Token(Token = "0x1700062B")]
    public Work[] Works
    {
      [Token(Token = "0x6002942"), Address(RVA = "0x367F9E8", Offset = "0x367F9E8", VA = "0x367F9E8")] get
      {
        return (Work[]) null;
      }
      [Token(Token = "0x6002943"), Address(RVA = "0x367F9F0", Offset = "0x367F9F0", VA = "0x367F9F0")] set
      {
      }
    }

    [Token(Token = "0x1700062C")]
    public bool CanSelect
    {
      [Token(Token = "0x6002944"), Address(RVA = "0x367F9F8", Offset = "0x367F9F8", VA = "0x367F9F8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002945"), Address(RVA = "0x367FA00", Offset = "0x367FA00", VA = "0x367FA00")] set
      {
      }
    }

    [Token(Token = "0x1700062D")]
    public int RandomWorkID
    {
      [Token(Token = "0x6002946"), Address(RVA = "0x367FA0C", Offset = "0x367FA0C", VA = "0x367FA0C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002947"), Address(RVA = "0x367FA14", Offset = "0x367FA14", VA = "0x367FA14")] set
      {
      }
    }

    [Token(Token = "0x6002948")]
    [Address(RVA = "0x367FA1C", Offset = "0x367FA1C", VA = "0x367FA1C")]
    public Work Get(int workID) => (Work) null;

    [Token(Token = "0x6002949")]
    [Address(RVA = "0x367BBE4", Offset = "0x367BBE4", VA = "0x367BBE4")]
    public WorkInfo()
    {
    }
  }
}
