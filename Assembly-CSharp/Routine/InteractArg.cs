// Decompiled with JetBrains decompiler
// Type: Routine.InteractArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200222F")]
  public class InteractArg : ActionArg
  {
    [Token(Token = "0x17002D4A")]
    public InteractArg.InteractSettingType InteractSetting
    {
      [Token(Token = "0x600D01C"), Address(RVA = "0x4CD2B74", Offset = "0x4CD2B74", VA = "0x4CD2B74")] get
      {
        return new InteractArg.InteractSettingType();
      }
      [Token(Token = "0x600D01D"), Address(RVA = "0x4CD2B7C", Offset = "0x4CD2B7C", VA = "0x4CD2B7C")] private set
      {
      }
    }

    [Token(Token = "0x17002D4B")]
    public int Limit
    {
      [Token(Token = "0x600D01E"), Address(RVA = "0x4CD2B84", Offset = "0x4CD2B84", VA = "0x4CD2B84")] get
      {
        return new int();
      }
      [Token(Token = "0x600D01F"), Address(RVA = "0x4CD2B8C", Offset = "0x4CD2B8C", VA = "0x4CD2B8C")] private set
      {
      }
    }

    [Token(Token = "0x600D020")]
    [Address(RVA = "0x4CD2B94", Offset = "0x4CD2B94", VA = "0x4CD2B94")]
    public InteractArg(int[] arg)
    {
    }

    [Token(Token = "0x600D021")]
    [Address(RVA = "0x4CD2B9C", Offset = "0x4CD2B9C", VA = "0x4CD2B9C", Slot = "4")]
    protected override void SetArg(int[] arg)
    {
    }

    [Token(Token = "0x2002230")]
    private enum ContextIndex
    {
      [Token(Token = "0x400905B")] Move,
      [Token(Token = "0x400905C")] InteractTarget,
      [Token(Token = "0x400905D")] InteractLimit,
    }

    [Token(Token = "0x2002231")]
    public enum InteractSettingType
    {
      [Token(Token = "0x400905F")] None,
      [Token(Token = "0x4009060")] Switch,
      [Token(Token = "0x4009061")] Warp,
      [Token(Token = "0x4009062")] Chest,
      [Token(Token = "0x4009063")] Door,
    }

    [Token(Token = "0x2002232")]
    public enum PrioritySettingType
    {
      [Token(Token = "0x4009065")] Near,
      [Token(Token = "0x4009066")] Far,
    }
  }
}
