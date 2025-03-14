using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;

namespace LP.AutoAnchoring.Editor
{
    public class AutoAnchorTool : EditorWindow
    {
        [MenuItem("Tools/Adjust Anchors for Selected UI Elements")]
        private static void AdjustAnchorsForSelection()
        {
            if (Selection.objects == null || Selection.objects.Length == 0)
            {
                Debug.LogWarning("No objects selected. Please select at least one UI element.");
                return;
            }

            foreach (var selectedObject in Selection.objects)
            {
                
                if (selectedObject is GameObject gameObject)
                {
       
                    RectTransform rectTransform = gameObject.GetComponent<RectTransform>();

                    if (rectTransform != null)
                    {
                        AdjustAnchors(rectTransform);
                    }
                    else
                    {
                        Debug.LogWarning($"The object '{gameObject.name}' does not have a RectTransform component. Skipping.");
                    }
                }
                else
                {
                    Debug.LogWarning("One or more selected objects are not GameObjects. Skipping invalid selections.");
                }
            }
        }

        public static void AdjustAnchors(RectTransform rectTransform)
        {
           
            RectTransform parentRectTransform = rectTransform.parent as RectTransform;
            if (parentRectTransform == null)
            {
                Debug.LogWarning($"The selected RectTransform '{rectTransform.name}' has no parent. Anchors cannot be adjusted.");
                return;
            }

            // Retrieve world corners of both the target and its parent
            Vector3[] targetCorners = new Vector3[4];
            Vector3[] parentCorners = new Vector3[4];

            rectTransform.GetWorldCorners(targetCorners);
            parentRectTransform.GetWorldCorners(parentCorners);

            // Get the parent's rectangle size
            Rect parentRect = parentRectTransform.rect;

            // Calculate anchor values relative to the parent's position
            float anchorMinX = (targetCorners[0].x - parentCorners[0].x) / parentRect.width;
            float anchorMaxX = (targetCorners[2].x - parentCorners[0].x) / parentRect.width;

            float anchorMinY = (targetCorners[0].y - parentCorners[0].y) / parentRect.height;
            float anchorMaxY = (targetCorners[1].y - parentCorners[0].y) / parentRect.height;

            // Apply calculated anchor values and reset offsets
            rectTransform.anchorMin = new Vector2(anchorMinX, anchorMinY);
            rectTransform.anchorMax = new Vector2(anchorMaxX, anchorMaxY);
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = Vector2.zero;
        }
    }
}
