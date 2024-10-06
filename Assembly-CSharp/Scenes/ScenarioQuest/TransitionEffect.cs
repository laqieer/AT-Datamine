// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.TransitionEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.ScenarioQuest
{
  [Token(Token = "0x200293B")]
  public class TransitionEffect
  {
    [Token(Token = "0x6010378")]
    [Address(RVA = "0x4750668", Offset = "0x4750668", VA = "0x4750668", Slot = "4")]
    public virtual IEnumerator EnableEffect(UITImelineControllerFacade timelineFacade)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010379")]
    [Address(RVA = "0x47506F0", Offset = "0x47506F0", VA = "0x47506F0", Slot = "5")]
    public virtual IEnumerator DisableEffect(UITImelineControllerFacade timelineFacade)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601037A")]
    [Address(RVA = "0x4750778", Offset = "0x4750778", VA = "0x4750778")]
    public TransitionEffect()
    {
    }
  }
}
