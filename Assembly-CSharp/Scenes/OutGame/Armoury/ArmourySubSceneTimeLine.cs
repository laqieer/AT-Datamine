// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmourySubSceneTimeLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x20037FE")]
  public class ArmourySubSceneTimeLine : ArmouryTimeLineFacade
  {
    [Token(Token = "0x400F49F")]
    [FieldOffset(Offset = "0x20")]
    private ArmouryTimeLineFacade.Direction topIn;
    [Token(Token = "0x400F4A0")]
    [FieldOffset(Offset = "0x30")]
    private ArmouryTimeLineFacade.Direction topOut;

    [Token(Token = "0x6016082")]
    [Address(RVA = "0x20ECFF8", Offset = "0x20ECFF8", VA = "0x20ECFF8")]
    public ArmourySubSceneTimeLine(UITimelineController timeline)
    {
    }

    [Token(Token = "0x6016083")]
    [Address(RVA = "0x20ED084", Offset = "0x20ED084", VA = "0x20ED084")]
    public void In(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6016084")]
    [Address(RVA = "0x20ED098", Offset = "0x20ED098", VA = "0x20ED098")]
    public void Out(UnityAction callback = null)
    {
    }
  }
}
