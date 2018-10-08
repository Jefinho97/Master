using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Master.View
{
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail ()
		{
            this.Master = new Menu();
            this.Detail = new NavigationPage(new Pagina2());
            App.MasterDetail = this;
		}
	}
}