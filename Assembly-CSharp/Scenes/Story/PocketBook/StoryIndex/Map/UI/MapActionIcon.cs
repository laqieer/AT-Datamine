// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.Map.UI.MapActionIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.Common.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.Map.UI
{
  [Token(Token = "0x2002E11")]
  public class MapActionIcon : ActionIcon
  {
    [Token(Token = "0x400C5C0")]
    [FieldOffset(Offset = "0x60")]
    private StateMachine<UITweenGroup> stateMachine;

    [Token(Token = "0x6011FF1")]
    [Address(RVA = "0x43787D4", Offset = "0x43787D4", VA = "0x43787D4")]
    private void Start()
    {
    }

    [Token(Token = "0x6011FF2")]
    [Address(RVA = "0x43787D8", Offset = "0x43787D8", VA = "0x43787D8")]
    private void StateMachineInitializeIfNeed()
    {
    }

    [Token(Token = "0x6011FF3")]
    [Address(RVA = "0x437885C", Offset = "0x437885C", VA = "0x437885C")]
    public void Highlight(bool highlight)
    {
    }

    [Token(Token = "0x6011FF4")]
    [Address(RVA = "0x4378A1C", Offset = "0x4378A1C", VA = "0x4378A1C")]
    public MapActionIcon()
    {
    }

    [Token(Token = "0x2002E12")]
    private enum State
    {
      [Token(Token = "0x400C5C2")] In,
      [Token(Token = "0x400C5C3")] Out,
    }

    [Token(Token = "0x2002E13")]
    private class StateIn : StateMachineState<UITweenGroup>
    {
      [Token(Token = "0x400C5C4")]
      private const string GROUP_ID = "ActionIc_In";

      [Token(Token = "0x6011FF5")]
      [Address(RVA = "0x4378A20", Offset = "0x4378A20", VA = "0x4378A20", Slot = "5")]
      protected override void OnEnter(UITweenGroup entity)
      {
      }

      [Token(Token = "0x6011FF6")]
      [Address(RVA = "0x4378A94", Offset = "0x4378A94", VA = "0x4378A94", Slot = "6")]
      public override void Execute(UITweenGroup entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FF7")]
      [Address(RVA = "0x4378A98", Offset = "0x4378A98", VA = "0x4378A98", Slot = "7")]
      public override void Exit(UITweenGroup entity)
      {
      }

      [Token(Token = "0x6011FF8")]
      [Address(RVA = "0x4378A9C", Offset = "0x4378A9C", VA = "0x4378A9C", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FF9")]
      [Address(RVA = "0x437898C", Offset = "0x437898C", VA = "0x437898C")]
      public StateIn()
      {
      }
    }

    [Token(Token = "0x2002E14")]
    private class StateOut : StateMachineState<UITweenGroup>
    {
      [Token(Token = "0x400C5C5")]
      private const string GROUP_ID = "ActionIc_Out";

      [Token(Token = "0x6011FFA")]
      [Address(RVA = "0x4378AA4", Offset = "0x4378AA4", VA = "0x4378AA4", Slot = "5")]
      protected override void OnEnter(UITweenGroup entity)
      {
      }

      [Token(Token = "0x6011FFB")]
      [Address(RVA = "0x4378AFC", Offset = "0x4378AFC", VA = "0x4378AFC", Slot = "6")]
      public override void Execute(UITweenGroup entity, float deltaTime)
      {
      }

      [Token(Token = "0x6011FFC")]
      [Address(RVA = "0x4378B00", Offset = "0x4378B00", VA = "0x4378B00", Slot = "7")]
      public override void Exit(UITweenGroup entity)
      {
      }

      [Token(Token = "0x6011FFD")]
      [Address(RVA = "0x4378B2C", Offset = "0x4378B2C", VA = "0x4378B2C", Slot = "8")]
      public override int GetStateType() => new int();

      [Token(Token = "0x6011FFE")]
      [Address(RVA = "0x43789D4", Offset = "0x43789D4", VA = "0x43789D4")]
      public StateOut()
      {
      }
    }
  }
}
