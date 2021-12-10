using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Triplano.Extentions
{

	public static class TriplanoExtentions
	{
#region List/Array/Dictionary Related Extentions

		public static T GetRandom<T>(this IList<T> list)
		{
			return list[Random.Range(0, list.Count)];
		}

#endregion

#region Vector Related Extentions

		public static Vector2 ToVector2(this Vector3 vec3)
		{
			return new Vector2(vec3.x, vec3.y);
		}

		public static Vector3Int ToVector3Int(this Vector3 vec3)
		{
			return new Vector3Int((int) vec3.x, (int) vec3.y, (int) vec3.z);
		}

#endregion

#region Transform Related Extentions

		public static void ResetLocalPositionAndRotation(this Transform transform)
		{
			ResetLocalPosition(transform);
			ResetLocalRotation(transform);
		}

		public static void ResetLocalPosition(this Transform transform)
		{
			transform.localPosition = Vector3.zero;
		}

		public static void ResetLocalRotation(this Transform transform)
		{
			transform.localRotation = Quaternion.identity;
		}

#endregion
		
	}


}
