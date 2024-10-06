// Decompiled with JetBrains decompiler
// Type: staq.Task.TaskManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.Task
{
  [Token(Token = "0x2003C5D")]
  public class TaskManager : SingletonMonoBehaviour<TaskManager>
  {
    [Token(Token = "0x4010BBB")]
    [FieldOffset(Offset = "0x20")]
    public List<TaskBase> tasks;

    [Token(Token = "0x17004D44")]
    protected override bool IsDontDestroy
    {
      [Token(Token = "0x6017B98"), Address(RVA = "0x37B4D70", Offset = "0x37B4D70", VA = "0x37B4D70", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017B99")]
    [Address(RVA = "0x37B4D78", Offset = "0x37B4D78", VA = "0x37B4D78")]
    public void Update()
    {
    }

    [Token(Token = "0x6017B9A")]
    [Address(RVA = "0x37B4C64", Offset = "0x37B4C64", VA = "0x37B4C64")]
    public void regist(TaskBase task)
    {
    }

    [Token(Token = "0x6017B9B")]
    [Address(RVA = "0x37B4D18", Offset = "0x37B4D18", VA = "0x37B4D18")]
    public void remove(TaskBase task)
    {
    }

    [Token(Token = "0x6017B9C")]
    [Address(RVA = "0x37B501C", Offset = "0x37B501C", VA = "0x37B501C")]
    public TaskManager()
    {
    }
  }
}
