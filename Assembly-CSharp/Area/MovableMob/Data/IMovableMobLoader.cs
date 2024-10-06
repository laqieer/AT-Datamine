// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.IMovableMobLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x2002839")]
  public interface IMovableMobLoader
  {
    [Token(Token = "0x600FD3F")]
    void Load();

    [Token(Token = "0x600FD40")]
    MovableMobInstanceDataBase CreateInstanceData();

    [Token(Token = "0x600FD41")]
    void Unload();
  }
}
