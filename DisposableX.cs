using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dispose
{
	public class DisposeExample : IDisposable
	{
		// some fields that require cleanup
		private bool disposed = false; // to detect redundant calls

		public DisposeExample()
		{
			// allocate resources
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					// dispose-only, i.e. non-finalizable logic
				}

				// shared cleanup logic
				disposed = true;
			}
		}

		~DisposeExample()
		{
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}

	public class ComplexCleanupExtender : DisposeExample
	{
		// some new fields that require cleanup
		private bool disposed = false; // to detect redundant calls

		public ComplexCleanupExtender() : base()
		{
			// allocate more resources (in addition to base’s)
		}

		protected override void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					// dispose-only, i.e. non-finalizable logic
				}

				// new shared cleanup logic
				disposed = true;
			}

			base.Dispose(disposing);
		}
	}
}
