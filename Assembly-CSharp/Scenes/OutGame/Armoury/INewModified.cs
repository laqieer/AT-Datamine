// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.INewModified
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003818")]
  internal interface INewModified
  {
    [Token(Token = "0x170048DE")]
    bool IsNew { [Token(Token = "0x60160E6")] get; }

    [Token(Token = "0x60160E7")]
    void ChangeNew(bool isNew);
  }
}
