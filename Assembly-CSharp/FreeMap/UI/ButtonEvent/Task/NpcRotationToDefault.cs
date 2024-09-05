// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.NpcRotationToDefault
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001721")]
  public class NpcRotationToDefault : NpcRotationBase
  {
    [Token(Token = "0x1700147A")]
    private FreeMapSceneManager SceneManager
    {
      [Token(Token = "0x60082DC"), Address(RVA = "0x4202C7C", Offset = "0x4202C7C", VA = "0x4202C7C")] get
      {
        return (FreeMapSceneManager) null;
      }
    }

    [Token(Token = "0x60082DD")]
    [Address(RVA = "0x4202C84", Offset = "0x4202C84", VA = "0x4202C84")]
    public NpcRotationToDefault(
      FreeMapSceneManager sceneManager,
      FreeMapInstanceHolder instanceHolder,
      InstanceID instanceID)
    {
    }

    [Token(Token = "0x60082DE")]
    [Address(RVA = "0x4202CD0", Offset = "0x4202CD0", VA = "0x4202CD0", Slot = "7")]
    public override void Execute()
    {
    }
  }
}
