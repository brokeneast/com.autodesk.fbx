#ifdef IGNORE_ALL_INCLUDE_SOME
// Unignore class
%rename("%s") FbxScene;

// As the ignore everything will include the constructor, destructor, methods etc
// in the class, these have to be explicitly unignored too:
%rename("%s") FbxScene::GetNodeCount;
#endif

%include "fbxsdk/scene/fbxscene.h"
