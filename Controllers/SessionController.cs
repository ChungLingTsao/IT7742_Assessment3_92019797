/* 
 * CustomerController.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: This controller class will be responsible for how the user interacts with the application.
 *				It is the bridge between the model and view components. 
 *				When a user performs a relevant action, the controller should send the appropriate response.
*/
using System.Windows.Forms;

namespace Assessment3
{
    public class SessionController
	{
		private SessionData _session;

		public int GetSessionID()
		{
			return _session.AccountID;
		}

		public void SetSessionID(int accountID)
		{
			_session.AccountID = accountID;
		}
	}
}
