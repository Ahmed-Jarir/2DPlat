using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>
///sets difficuly level
///</summary>
public class SelectSkin : MonoBehaviour
{
		/// <summary>
		/// Description:
		/// Calls the Set Difficulty fuction in Enemies with the
		/// difficuly as a parameter
		/// Input:
		/// none
		/// Return:
		/// void
		/// </summary>
		private static int Skin = 0;
		public static int getSkin(){
			 return Skin;
		}

		public static void setSkin(int skin){
				Skin = skin;
		}
}
