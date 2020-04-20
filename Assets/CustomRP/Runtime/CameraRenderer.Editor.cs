using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

partial class CameraRenderer
{

    partial void DrawGizmos();
    partial void PrepareBuffer();

#if UNITY_EDITOR

    partial void DrawGizmos()
    {
        if (Handles.ShouldRenderGizmos())
        {
            context.DrawGizmos(camera, GizmoSubset.PreImageEffects);
            context.DrawGizmos(camera, GizmoSubset.PostImageEffects);
        }
    }

	string SampleName { get; set; }

	partial void PrepareBuffer()
    {
        buffer.name = SampleName = camera.name;
    }

#else

	const string SampleName = bufferName;
#endif
}