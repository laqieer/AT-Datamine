// Decompiled with JetBrains decompiler
// Type: BaseVolumeComponentController`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x20002E4")]
[RequireComponent(typeof (Volume))]
public abstract class BaseVolumeComponentController<T> : MonoBehaviour where T : VolumeComponent
{
  [Token(Token = "0x40010BB")]
  [FieldOffset(Offset = "0x0")]
  protected T targetVolumeComponent;
  [Token(Token = "0x40010BC")]
  [FieldOffset(Offset = "0x0")]
  protected Volume targetVolume;
  [Token(Token = "0x40010BD")]
  [FieldOffset(Offset = "0x0")]
  public bool isActive;

  [Token(Token = "0x600121C")]
  private void Start()
  {
  }

  [Token(Token = "0x600121D")]
  private void Update()
  {
  }

  [Token(Token = "0x600121E")]
  private void InitializeTargetVolumeComponent()
  {
  }

  [Token(Token = "0x600121F")]
  public virtual void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001220")]
  protected BaseVolumeComponentController()
  {
  }
}
