using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public class NotifyPropertyChange : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		//Conditional("DEBUG") Example: I use this so that I don't have to go back and edit my code later during release, but during debugging I want to be sure I didn't make any typos.This function checks that I type a property name correctly when trying to use it in my INotifyPropertyChanged stuff.
		[Conditional("DEBUG")]
		[DebuggerStepThrough]
		[Obsolete("I copied this from web for research. I don't fully understand the affidat of this code yet.",true)]
		protected void VerifyPropertyName(String propertyName)
		{
			if (TypeDescriptor.GetProperties(this)[propertyName] == null)
				Debug.Fail(String.Format("Invalid property name. Type: {0}, Name: {1}",
					GetType(), propertyName));
		}

	}
}
