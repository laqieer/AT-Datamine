// Decompiled with JetBrains decompiler
// Type: staq.Task.TaskBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Task
{
  [Token(Token = "0x2003C5C")]
  public class TaskBase
  {
    [Token(Token = "0x6017B93")]
    [Address(RVA = "0x37B4B54", Offset = "0x37B4B54", VA = "0x37B4B54", Slot = "4")]
    public virtual void start()
    {
    }

    [Token(Token = "0x6017B94")]
    [Address(RVA = "0x37B4D0C", Offset = "0x37B4D0C", VA = "0x37B4D0C", Slot = "5")]
    public virtual void update()
    {
    }

    [Token(Token = "0x6017B95")]
    [Address(RVA = "0x37B4D10", Offset = "0x37B4D10", VA = "0x37B4D10", Slot = "6")]
    public virtual bool isFinished() => new bool();

    [Token(Token = "0x6017B96")]
    [Address(RVA = "0x37B4BD8", Offset = "0x37B4BD8", VA = "0x37B4BD8", Slot = "7")]
    protected virtual void finish()
    {
    }

    [Token(Token = "0x6017B97")]
    [Address(RVA = "0x37B488C", Offset = "0x37B488C", VA = "0x37B488C")]
    public TaskBase()
    {
    }
  }
}
