// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.SavePlayerPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001724")]
  public class SavePlayerPosition : IFreeMapButtonEventTask
  {
    [Token(Token = "0x17001480")]
    private FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x60082EC"), Address(RVA = "0x4202F58", Offset = "0x4202F58", VA = "0x4202F58")] get
      {
        return (FreeMapInstanceHolder) null;
      }
    }

    [Token(Token = "0x17001481")]
    private FreeMapUITransformHolder TransformHolder
    {
      [Token(Token = "0x60082ED"), Address(RVA = "0x4202F60", Offset = "0x4202F60", VA = "0x4202F60")] set
      {
      }
      [Token(Token = "0x60082EE"), Address(RVA = "0x4202F68", Offset = "0x4202F68", VA = "0x4202F68")] get
      {
        return (FreeMapUITransformHolder) null;
      }
    }

    [Token(Token = "0x17001482")]
    private int AreaID
    {
      [Token(Token = "0x60082EF"), Address(RVA = "0x4202F70", Offset = "0x4202F70", VA = "0x4202F70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60082F0")]
    [Address(RVA = "0x4200534", Offset = "0x4200534", VA = "0x4200534")]
    public SavePlayerPosition(FreeMapInstanceHolder instanceHolder, int areaID)
    {
    }

    [Token(Token = "0x60082F1")]
    [Address(RVA = "0x4202F78", Offset = "0x4202F78", VA = "0x4202F78")]
    public void SetTransformHolder(FreeMapUITransformHolder transformHolder)
    {
    }

    [Token(Token = "0x60082F2")]
    [Address(RVA = "0x4202F80", Offset = "0x4202F80", VA = "0x4202F80", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x60082F3")]
    [Address(RVA = "0x420319C", Offset = "0x420319C", VA = "0x420319C", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60082F4")]
    [Address(RVA = "0x42031A0", Offset = "0x42031A0", VA = "0x42031A0", Slot = "6")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x60082F5")]
    [Address(RVA = "0x4202F9C", Offset = "0x4202F9C", VA = "0x4202F9C")]
    protected void SavePosition(FreeMapPlayerInstance activePlayer)
    {
    }
  }
}
