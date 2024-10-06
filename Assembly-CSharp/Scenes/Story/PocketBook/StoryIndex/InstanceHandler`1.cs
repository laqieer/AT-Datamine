// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.InstanceHandler`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex
{
  [Token(Token = "0x2002DCE")]
  public class InstanceHandler<T> where T : InstanceHandler<T>.IManaged
  {
    [Token(Token = "0x400C4F1")]
    [FieldOffset(Offset = "0x0")]
    private Queue<T> queue;
    [Token(Token = "0x400C4F2")]
    [FieldOffset(Offset = "0x0")]
    private List<T> rentalList;

    [Token(Token = "0x6011E9A")]
    public InstanceHandler()
    {
    }

    [Token(Token = "0x6011E9B")]
    public void RegisterQueue(IEnumerable<T> instances)
    {
    }

    [Token(Token = "0x6011E9C")]
    public void RegisterQueue(T instance)
    {
    }

    [Token(Token = "0x6011E9D")]
    public void RegisterRentalList(IEnumerable<T> instances)
    {
    }

    [Token(Token = "0x6011E9E")]
    public T RegisterRentalList(T instance) => (T) null;

    [Token(Token = "0x6011E9F")]
    public T GetInstance() => (T) null;

    [Token(Token = "0x6011EA0")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x2002DCF")]
    public interface IManaged
    {
      [Token(Token = "0x6011EA1")]
      void OnInitialize();

      [Token(Token = "0x6011EA2")]
      void OnRelease();
    }
  }
}
