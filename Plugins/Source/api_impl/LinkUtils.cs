﻿// Kerbal Attachment System API
// Mod idea: KospY (http://forum.kerbalspaceprogram.com/index.php?/profile/33868-kospy/)
// API design and implemenation: igor.zavoychinskiy@gmail.com
// License: https://github.com/KospY/KAS/blob/master/LICENSE.md

using KASAPIv1;
using System;
using System.Linq;

namespace KASImpl {

class LinkUtilsImpl : ILinkUtils {
  /// <inheritdoc/>
  public ILinkTarget FindLinkTargetFromSource(ILinkSource source) {
    return source.attachNode.attachedPart.FindModulesImplementing<ILinkTarget>()
        .FirstOrDefault(x => x.attachNode != null && x.attachNode.attachedPart == source.part);
  }

  /// <inheritdoc/>
  public ILinkSource FindLinkSourceFromPart(Part sourcePart) {
    return sourcePart.FindModulesImplementing<ILinkSource>().FirstOrDefault(
        x => (x.linkState == LinkState.Linked
              && x.attachNode != null && x.attachNode.attachedPart != null));
  }
}

}  // namespace