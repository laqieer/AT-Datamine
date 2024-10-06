// Decompiled with JetBrains decompiler
// Type: Story.Ending.SequenseTaskBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Ending
{
  [Token(Token = "0x200060D")]
  public abstract class SequenseTaskBase
  {
    [Token(Token = "0x6002304")]
    [Address(RVA = "0x2DA3374", Offset = "0x2DA3374", VA = "0x2DA3374", Slot = "4")]
    public virtual void Start()
    {
    }

    [Token(Token = "0x6002305")]
    [Address(RVA = "0x2DA3378", Offset = "0x2DA3378", VA = "0x2DA3378", Slot = "5")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x6002306")]
    [Address(RVA = "0x2DA337C", Offset = "0x2DA337C", VA = "0x2DA337C", Slot = "6")]
    public virtual bool IsEnded() => new bool();

    [Token(Token = "0x6002307")]
    [Address(RVA = "0x2DA3384", Offset = "0x2DA3384", VA = "0x2DA3384", Slot = "7")]
    public virtual void Cancel()
    {
    }

    [Token(Token = "0x6002308")]
    [Address(RVA = "0x2DA3388", Offset = "0x2DA3388", VA = "0x2DA3388")]
    protected SequenseTaskBase()
    {
    }
  }
}
