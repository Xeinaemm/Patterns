using System.Collections;

namespace Patterns.LazyLoading.Ghosts
{
	public abstract class DomainObject
	{
		private LoadStatus Status;

		protected DomainObject(int id) => Id = id;

		protected int Id { get; }

		public bool IsGhost => Status == LoadStatus.Ghost;

		public bool IsLoaded => Status == LoadStatus.Loaded;

		private void Loading()
		{
			Status = LoadStatus.Loading;
		}

		private void Loaded()
		{
			Status = LoadStatus.Loaded;
		}

		protected virtual void Load()
		{
			if (!IsGhost) return;
			var rows = GetDataRow();
			LoadLine(rows);
		}

		private void LoadLine(ArrayList dataRow)
		{
			if (!IsGhost) return;
			Loading();
			DoLoadLine(dataRow);
			Loaded();
		}

		protected abstract void DoLoadLine(ArrayList dataRow);
		protected abstract ArrayList GetDataRow();
	}
}