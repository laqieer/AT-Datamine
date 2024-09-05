// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.IPlayerInputProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018F7")]
  public interface IPlayerInputProvider
  {
    [Token(Token = "0x14000121")]
    event MoveUpdateFunc OnMoveUpdate;

    [Token(Token = "0x14000122")]
    event SetMoveSpeedFunc SetMoveSpeed;

    [Token(Token = "0x14000123")]
    event SetAnimationRateFunc SetAnimationRate;
  }
}
