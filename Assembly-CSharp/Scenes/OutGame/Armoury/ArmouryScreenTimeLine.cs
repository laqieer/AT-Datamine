// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryScreenTimeLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x20037F5")]
  public class ArmouryScreenTimeLine : ArmouryTimeLineFacade
  {
    [Token(Token = "0x400F47E")]
    [FieldOffset(Offset = "0x20")]
    private ArmouryTimeLineFacade.Direction topIn;
    [Token(Token = "0x400F47F")]
    [FieldOffset(Offset = "0x30")]
    private ArmouryTimeLineFacade.Direction topOut;

    [Token(Token = "0x6016044")]
    [Address(RVA = "0x20EA500", Offset = "0x20EA500", VA = "0x20EA500")]
    public ArmouryScreenTimeLine(UITimelineController timeline)
    {
    }

    [Token(Token = "0x6016045")]
    [Address(RVA = "0x20EAC20", Offset = "0x20EAC20", VA = "0x20EAC20")]
    public void In(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6016046")]
    [Address(RVA = "0x20EAAB4", Offset = "0x20EAAB4", VA = "0x20EAAB4")]
    public void Out(UnityAction callback = null)
    {
    }
  }
}
