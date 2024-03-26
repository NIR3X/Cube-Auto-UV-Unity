using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeAutoUV : MonoBehaviour
{
    [SerializeField] bool xAxis = true, yAxis = true, zAxis = true;
    [SerializeField] protected GameObject cube;
    private Vector2[] uvMapBak = null;

    public virtual void AutoUV()
    {
        if (cube != null
#if UNITY_EDITOR
            && EditorApplication.isPlayingOrWillChangePlaymode
#endif
        )
        {
            Mesh cubeMesh = cube.GetComponent<MeshFilter>().mesh;
            Vector2[] uvMap = uvMapBak == null ? cubeMesh.uv : uvMapBak;
            uvMapBak = (Vector2[])uvMap.Clone();

            if (xAxis)
            {
                foreach (int i in new int[] {
                    0, 1, 2, 3 /* Front */
                })
                {
                    uvMap[i] *= new Vector2(transform.localScale.x, transform.localScale.y);
                }

                foreach (int i in new int[] {
                    6, 7, 10, 11 /* Back */
                })
                {
                    uvMap[i] *= new Vector2(-transform.localScale.x, -transform.localScale.y);
                }
            }

            if (yAxis)
            {
                foreach (int i in new int[] {
                    4, 5, 8, 9, /* Top */
                    12, 13, 14, 15 /* Bottom */
                })
                {
                    uvMap[i] *= new Vector2(transform.localScale.x, transform.localScale.z);
                }
            }

            if (zAxis)
            {
                foreach (int i in new int[] {
                    16, 17, 18, 19, /* Left */
                    20, 21, 22, 23 /* Right */
                })
                {
                    uvMap[i] *= new Vector2(transform.localScale.z, transform.localScale.y);
                }
            }

            cubeMesh.uv = uvMap;
        }
    }

    private void Start()
    {
        AutoUV();
    }
}
