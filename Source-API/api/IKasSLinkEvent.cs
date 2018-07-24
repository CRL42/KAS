﻿// Kerbal Attachment System
// Mod idea: KospY (http://forum.kerbalspaceprogram.com/index.php?/profile/33868-kospy/)
// Module author: igor.zavoychinskiy@gmail.com
// License: Public Domain

namespace KASAPIv1 {

/// <summary>A holder for simple source-to-target event.</summary>
public interface IKasLinkEvent {
  /// <summary>Link source.</summary>
  ILinkSource source { get; }
  /// <summary>Link target.</summary>
  ILinkTarget target { get; }
  /// <summary>Actor who changed the links tate.</summary>
  LinkActorType actor { get; }
}

}  // namespace
