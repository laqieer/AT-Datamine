// Decompiled with JetBrains decompiler
// Type: FreeMap.Adv.IFreeMapAdvControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Adv
{
  [Token(Token = "0x2001972")]
  public interface IFreeMapAdvControl
  {
    [Token(Token = "0x6009122")]
    GameObject GetAreaObjectModelRef(string objectAccessName);

    [Token(Token = "0x6009123")]
    GameObject GetPlayerObjectModelRef();

    [Token(Token = "0x6009124")]
    void ShowVisibleObjectAll();

    [Token(Token = "0x6009125")]
    void HideVisibleObjectAll();

    [Token(Token = "0x6009126")]
    void ChangeAudioListener(bool enableBootAudioListener);
  }
}
