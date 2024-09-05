// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.UI.IModifiableState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Tayx.Graphy.UI
{
  [Token(Token = "0x2000394")]
  public interface IModifiableState
  {
    [Token(Token = "0x600148F")]
    void SetState(GraphyManager.ModuleState newState, bool silentUpdate);
  }
}
