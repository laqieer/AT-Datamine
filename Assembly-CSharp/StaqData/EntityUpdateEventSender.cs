// Decompiled with JetBrains decompiler
// Type: StaqData.EntityUpdateEventSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FF5")]
  public class EntityUpdateEventSender : EntityUpdateEventSender.IEventListener
  {
    [Token(Token = "0x400886F")]
    [FieldOffset(Offset = "0x10")]
    private List<EntityUpdateEventSender.IEventListener> listeners;

    [Token(Token = "0x600BE61")]
    [Address(RVA = "0x2000AD8", Offset = "0x2000AD8", VA = "0x2000AD8")]
    public void AddListener(EntityUpdateEventSender.IEventListener listener)
    {
    }

    [Token(Token = "0x600BE62")]
    [Address(RVA = "0x2000B80", Offset = "0x2000B80", VA = "0x2000B80")]
    public void RemoveListener(EntityUpdateEventSender.IEventListener listener)
    {
    }

    [Token(Token = "0x600BE63")]
    [Address(RVA = "0x2000BD8", Offset = "0x2000BD8", VA = "0x2000BD8", Slot = "4")]
    public void OnUpdate()
    {
    }

    [Token(Token = "0x600BE64")]
    [Address(RVA = "0x2000CD8", Offset = "0x2000CD8", VA = "0x2000CD8")]
    public EntityUpdateEventSender()
    {
    }

    [Token(Token = "0x2001FF6")]
    public interface IEventListener
    {
      [Token(Token = "0x600BE65")]
      void OnUpdate();
    }
  }
}
