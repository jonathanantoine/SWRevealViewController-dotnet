using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SWRevealViewController-dotnet {
    
    public enum FrontViewPosition {
        LeftSideMostRemoved,
        LeftSideMost,
        LeftSide,
        Left,
        Right,
        RightMost,
        RightMostRemoved
    }

    public enum SWRevealControllerOperation {
        ReplaceRearController,
        ReplaceFrontController,
        ReplaceRightController
    }
}
