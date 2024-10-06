// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.IMovableMobAnchorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200283E")]
  public interface IMovableMobAnchorData
  {
    [Token(Token = "0x170037BB")]
    string AnchorName { [Token(Token = "0x600FD5F")] get; }

    [Token(Token = "0x170037BC")]
    Vector3 AnchorPosition { [Token(Token = "0x600FD60")] get; }

    [Token(Token = "0x170037BD")]
    float FadeRadius { [Token(Token = "0x600FD61")] get; }
  }
}
