#region License
/*
Microsoft Public License (Ms-PL)
XnaTouch - Copyright © 2009 The XnaTouch Team

All rights reserved.

This license governs use of the accompanying software. If you use the software, you accept this license. If you do not
accept the license, do not use the software.

1. Definitions
The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same meaning here as under 
U.S. copyright law.

A "contribution" is the original software, or any additions or changes to the software.
A "contributor" is any person that distributes its contribution under this license.
"Licensed patents" are a contributor's patent claims that read directly on its contribution.

2. Grant of Rights
(A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, 
each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.
(B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, 
each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.

3. Conditions and Limitations
(A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.
(B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, 
your patent license from such contributor to the software ends automatically.
(C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution 
notices that are present in the software.
(D) If you distribute any portion of the software in source code form, you may do so only under this license by including 
a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object 
code form, you may only do so under a license that complies with this license.
(E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees
or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the extent
permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a particular
purpose and non-infringement.
*/
#endregion License

#region Using clause
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Remoting.Messaging;
#endregion Using clause

namespace XnaTouch.Framework.GamerServices
{


	public static class Guide
	{
		private static bool isScreenSaverEnabled;
		private static bool isTrialMode;
		private static bool isVisible;
		private static bool simulateTrialMode;
		
		public static IAsyncResult BeginShowKeyboardInput (
         PlayerIndex player,
         string title,
         string description,
         string defaultText,
         AsyncCallback callback,
         Object state)
		{
			isVisible = true;
			IAsyncResult ar = null;
			return ar;
			
		}

		public static IAsyncResult BeginShowKeyboardInput (
         PlayerIndex player,
         string title,
         string description,
         string defaultText,
         AsyncCallback callback,
         Object state,
         bool usePasswordMode)
		{
			isVisible = true;
			IAsyncResult ar = null;
			return ar;
		}

		public static string EndShowKeyboardInput (IAsyncResult ar)
		{
			try 
			{
				// Retrieve the delegate.
	            AsyncResult result = (AsyncResult) ar;
	            // AsyncMethodCaller caller = (AsyncMethodCaller) result.AsyncDelegate;
				
				// Retrieve the format string that was passed as state 
	            // information.
	            string formatString = (string) ar.AsyncState;

				return formatString;

			} 
			finally 
			{
				isVisible = false;
			}			
		}

		
		public static void ShowMarketplace (PlayerIndex player )
		{
			
		}
		
		public static void Show ()
		{
			/*GKPeerPickerController ppc = new GKPeerPickerController();
			ppc.ConnectionTypesMask = GKPeerPickerConnectionType.Nearby;
			ppc.Show();*/
			ShowSignIn(1, false);
		}
		
		public static void ShowSignIn (int paneCount, bool onlineOnly)
		{
			if ( paneCount != 1 )
			{
				new ArgumentException("paneCount Can only be 1 on iPhone");
				return;
			}
		}
		
		public static bool IsScreenSaverEnabled 
		{ 
			get
			{
				return isScreenSaverEnabled;
			}
			set
			{
				isScreenSaverEnabled = value;
			}
		}
		
		public static bool IsTrialMode 
		{ 
			get
			{
				return isTrialMode;
			}
			set
			{
				isTrialMode = value;
			}
		}
		
		public static bool IsVisible 
		{ 
			get
			{
				return isVisible;
			}
			set
			{
				isVisible = value;
			}
		}
		
		public static bool SimulateTrialMode 
		{ 
			get
			{
				return simulateTrialMode;
			}
			set
			{
				simulateTrialMode = value;
			}
		}
		
		public static bool Authenticating 
		{ 
			get;
			set;
		}
		
		public static bool Authenticated 
		{ 
			get;
			set;
		}
	}
}
