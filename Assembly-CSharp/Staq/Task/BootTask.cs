// Decompiled with JetBrains decompiler
// Type: staq.Task.BootTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Task
{
  [Token(Token = "0x2003C5B")]
  public class BootTask : TaskBase
  {
    [Token(Token = "0x4010BBA")]
    [FieldOffset(Offset = "0x10")]
    private BootPhase phase;

    [Token(Token = "0x6017B8A")]
    [Address(RVA = "0x37B4870", Offset = "0x37B4870", VA = "0x37B4870")]
    public BootTask()
    {
    }

    [Token(Token = "0x6017B8B")]
    [Address(RVA = "0x37B4894", Offset = "0x37B4894", VA = "0x37B4894", Slot = "5")]
    public override void update()
    {
    }

    [Token(Token = "0x6017B8C")]
    [Address(RVA = "0x37B48F0", Offset = "0x37B48F0", VA = "0x37B48F0")]
    public bool loadDebugSaveData() => new bool();

    [Token(Token = "0x6017B8D")]
    [Address(RVA = "0x37B4994", Offset = "0x37B4994", VA = "0x37B4994")]
    public bool loadPlayerSaveData() => new bool();

    [Token(Token = "0x6017B8E")]
    [Address(RVA = "0x37B4A3C", Offset = "0x37B4A3C", VA = "0x37B4A3C")]
    public bool savePlayerSecretKey() => new bool();

    [Token(Token = "0x6017B8F")]
    [Address(RVA = "0x37B48AC", Offset = "0x37B48AC", VA = "0x37B48AC")]
    private void updatePhase()
    {
    }

    [Token(Token = "0x6017B90")]
    [Address(RVA = "0x37B4B3C", Offset = "0x37B4B3C", VA = "0x37B4B3C", Slot = "4")]
    public override void start()
    {
    }

    [Token(Token = "0x6017B91")]
    [Address(RVA = "0x37B4BD0", Offset = "0x37B4BD0", VA = "0x37B4BD0", Slot = "7")]
    protected override void finish()
    {
    }

    [Token(Token = "0x6017B92")]
    [Address(RVA = "0x37B4C54", Offset = "0x37B4C54", VA = "0x37B4C54", Slot = "6")]
    public override bool isFinished() => new bool();
  }
}
