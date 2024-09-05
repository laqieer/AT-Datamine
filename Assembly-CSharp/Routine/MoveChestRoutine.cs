// Decompiled with JetBrains decompiler
// Type: Routine.MoveChestRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002247")]
  public class MoveChestRoutine : MovePositionRoutine
  {
    [Token(Token = "0x600D072")]
    [Address(RVA = "0x4CD839C", Offset = "0x4CD839C", VA = "0x4CD839C", Slot = "6")]
    protected override void SetArg(int[] arg, int[] preference)
    {
    }

    [Token(Token = "0x600D073")]
    [Address(RVA = "0x4CD879C", Offset = "0x4CD879C", VA = "0x4CD879C")]
    public MoveChestRoutine()
    {
    }

    [Token(Token = "0x2002248")]
    private class MoveChestPositionArg : MoveArg
    {
      [Token(Token = "0x600D074")]
      [Address(RVA = "0x4CD8798", Offset = "0x4CD8798", VA = "0x4CD8798")]
      public MoveChestPositionArg(int[] arg)
      {
      }

      [Token(Token = "0x600D075")]
      [Address(RVA = "0x4CD87A0", Offset = "0x4CD87A0", VA = "0x4CD87A0", Slot = "4")]
      protected override void SetArg(int[] arg)
      {
      }

      [Token(Token = "0x2002249")]
      private new enum ContextIndex
      {
        [Token(Token = "0x4009087")] ActionSetting,
        [Token(Token = "0x4009088")] MoveSetting,
        [Token(Token = "0x4009089")] ChestCoord,
      }
    }
  }
}
