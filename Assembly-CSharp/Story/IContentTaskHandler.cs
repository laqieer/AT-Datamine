﻿// Decompiled with JetBrains decompiler
// Type: Story.IContentTaskHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000589")]
  public interface IContentTaskHandler
  {
    [Token(Token = "0x6001FF7")]
    void Add(IContentTask task);

    [Token(Token = "0x6001FF8")]
    void Clear();

    [Token(Token = "0x6001FF9")]
    void Start();

    [Token(Token = "0x6001FFA")]
    void Update();

    [Token(Token = "0x6001FFB")]
    bool IsBusy();
  }
}
